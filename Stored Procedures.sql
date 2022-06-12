/* to select categories from warehouse by warehouse id  */ 

exec warehouse_data 1

create or alter proc warehouse_data @id int 
as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and i.WarehouseId=@id
Union 
select ca.*,cc.Production_Date,cc.Quantity,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc where coo.To_ID=@id
and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date , (e.Quantity-e.Eq-e.outq+e.inq)as Quantity from temptable e





-- Reports
/* report about warehouse in peroid  */ 

exec warehouse_data_startDate_endDate 1,'2009-03-30','2022-04-30'


create or alter proc warehouse_data_startDate_endDate  @id int , @startDate date , @endDate date
as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date and e.Date >=@startDate and  e.Date <=@endDate),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date and c.Date >=@startDate and  c.Date <=@endDate ),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date and c.Date >=@startDate and  c.Date <=@endDate),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and i.WarehouseId=@id and i.Date >=@startDate and  i.Date <=@endDate
Union
select ca.*,cc.Production_Date,cc.Quantity,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date and e.Date >=@startDate and  e.Date <=@endDate),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and c.Date >=@startDate and  c.Date <=@endDate ),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID and c.Date >=@startDate and  c.Date <=@endDate ),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc where coo.To_ID=@id
and  coo.Date >=@startDate and  coo.Date <=@endDate and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date , (e.Quantity-e.Eq-e.outq+e.inq)as Quantity from temptable e


/* report about catogory with catogory code*/ 

exec catogoryReport 4050

create or alter proc catogoryReport @catogoryCode nvarchar(50) 
as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,i.WarehouseId as [WarehouseId],
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=i.WarehouseId
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=i.WarehouseId
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=i.WarehouseId
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and ca.Code=@catogoryCode
Union 
select ca.*,cc.Production_Date,cc.Quantity,coo.To_ID as [WarehouseId],
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=coo.To_ID
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=coo.To_ID
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=coo.To_ID
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc where ca.Code=@catogoryCode
and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date ,e.WarehouseId, (e.Quantity-e.Eq-e.outq+e.inq)as Quantity from temptable e

/* report about catogory with catogory code*/ 

exec catogoryReportWithDate 4050 ,'2019-2-2','2022-4-30'

create or alter proc catogoryReportWithDate @catogoryCode nvarchar(50) ,@startDate date , @endDate date
as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,i.WarehouseId as [WarehouseId],
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=i.WarehouseId
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date and e.Date>=@startDate and e.Date<=@endDate),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=i.WarehouseId
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date and c.Date>=@startDate and c.Date<=@endDate),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=i.WarehouseId
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date  and c.Date>=@startDate and c.Date<=@endDate),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and ca.Code=@catogoryCode and  i.Date>=@startDate and i.Date<=@endDate
Union 
select ca.*,cc.Production_Date,cc.Quantity,coo.To_ID as [WarehouseId],
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=coo.To_ID
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date  and e.Date>=@startDate and e.Date<=@endDate),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=coo.To_ID
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date  and c.Date>=@startDate and c.Date<=@endDate),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=coo.To_ID
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID  and c.Date>=@startDate and c.Date<=@endDate),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc where ca.Code=@catogoryCode  and coo.Date>=@startDate and coo.Date<=@endDate
and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date ,e.WarehouseId, (e.Quantity-e.Eq-e.outq+e.inq)as Quantity from temptable e

--11

/* report about catogory movement with warehouse id*/ 

exec ReportAboutCatogoriesMovement 1

create or alter proc ReportAboutCatogoriesMovement  @id int 
as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date ),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and i.WarehouseId=@id
Union 
select ca.*,cc.Production_Date,0,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc where coo.To_ID=@id
and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date , e.Quantity as ImportedQuantity, e.Eq as ExportedQuantity,
e.inq as ConvertedInQuantity ,e.outq as ConvertedOutQuantity  from temptable e 

-- Reports
/* report about catogory stord peroid equal or more than  */ 

exec warehouse_data_with_Period 1,2


create or alter proc warehouse_data_with_Period  @id int , @period /* number of months */int 

as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date and DATEDIFF(month,e.Date,getdate())>=@period),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date and DATEDIFF(month,c.Date,getdate())>=@period) ,0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date and DATEDIFF(month,c.Date,getdate())>=@period),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and i.WarehouseId=@id and DATEDIFF(month,i.Date,getdate())>=@period
Union
select ca.*,cc.Production_Date,cc.Quantity,
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=@id
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date and DATEDIFF(month,e.Date,getdate())>=@period),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and DATEDIFF(month,c.Date,getdate())>=@period),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=@id
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID and DATEDIFF(month,c.Date,getdate())>=@period ),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc where coo.To_ID=@id
and DATEDIFF(month,coo.Date,getdate())>=@period and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date , (e.Quantity-e.Eq-e.outq+e.inq)as Quantity from temptable e

-- Reports
/* report about catogory stord peroid equal or more than  */ 

exec catagoriesExpiredPeroid 80


create or alter proc catagoriesExpiredPeroid  @period /* number of months */int 
as
with temptable as(
select  ca.*,ic.Production_Date,ic.Quantity ,i.WarehouseId as WarehouseId ,ca.Expired_period-DATEDIFF(month,ic.Production_Date,getdate()) as [expiredAfterMonths],
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=i.WarehouseId
and ec.CategoryCode=ic.CategoryCode and ec.Production_Date=ic.Production_Date ),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=i.WarehouseId
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date ) ,0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=i.WarehouseId
and cc.CategoryCode=ic.CategoryCode and cc.Production_Date=ic.Production_Date ),0 ) as inq
from Import i , Import_Categories ic , Category ca , [Convert] co ,Convert_Categories coc
where i.Id=ic.ImportId and ic.CategoryCode=ca.Code and ca.Expired_period-DATEDIFF(month,ic.Production_Date,getdate())<=@period
Union
select ca.*,cc.Production_Date,cc.Quantity,coo.To_ID as WarehouseId,ca.Expired_period-DATEDIFF(month,cc.Production_Date,getdate()) as [expiredAfterMonths],
isnull((select sum(ec.Quantity) from Export e inner join Export_Categories ec on e.Id=ec.ExportId where e.WarehouseId=coo.To_ID
and ec.CategoryCode=cc.CategoryCode and ec.Production_Date=cc.Production_Date ),0 ) as Eq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.From_ID=coo.To_ID
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date ),0 ) as outq,
isnull((select sum(cc.Quantity) from [Convert] c inner join Convert_Categories cc on c.ConvertID=cc.ConvertId where c.To_ID=coo.To_ID
and cc.CategoryCode=cc.CategoryCode and cc.Production_Date=cc.Production_Date and coo.ConvertID!=c.ConvertID),0 ) as inq
from Category ca , [Convert] coo , Convert_Categories cc 
where ca.Expired_period-DATEDIFF(month,cc.Production_Date,getdate())<=@period and ca.Code=cc.CategoryCode and coo.ConvertID=cc.ConvertId)
select distinct e.Code,e.Name,e.Unit,e.Expired_period,e.Production_Date ,e.WarehouseId ,[expiredAfterMonths],(e.Quantity-e.Eq-e.outq+e.inq)as Quantity from temptable e







