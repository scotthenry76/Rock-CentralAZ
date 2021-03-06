/* List PersonBadges with Attributes */
SELECT
    [et].[Name] as [EntityType.Name]
    ,[et].[FriendlyName] as [EntityType.FriendlyName]
    ,[et].[AssemblyName] as [EntityType.AssemblyName]
    ,[et].[Guid] as [EntityType.Guid]	
    ,[pb].[Name] as [PersonBadge.Name]
    ,[pb].[Name] as [PersonBadge.Description]    
    ,[pb].[Order] as [PersonBadge.Order]
    ,[pb].[Guid] as [PersonBadge.Guid]
    ,cast( 
        (select 
            ft.Guid [FieldType.Guid]              
            ,a.Name
            ,a.[Key]
            ,a.[Description]
            ,a.[Order]
            ,a.DefaultValue
            ,a.[Guid]
            ,av.Value [AttributeValue.Value]
            ,av.Guid [AttributeValue.Guid] 
        from 
            Attribute a 
        left outer join 
            AttributeValue av on av.AttributeId = a.Id 
        join 
            EntityType et on a.EntityTypeId = et.Id
        join
            FieldType ft on a.FieldTypeId = ft.Id
        where 
            et.Name = 'Rock.Model.PersonBadge' 
        and 
            av.EntityId = [pb].[Id]
        order by a.[Order], a.[Name]
        FOR XML PATH ('Attribute'), root ('root' ) ) as XML) [PersonBadge.AttributeValues]
FROM            
    [PersonBadge] AS [pb]
join
    [EntityType] as [et] on [pb].[EntityTypeId] = [et].[Id]
--where et.Name = 'Rock.PersonProfile.Badge.LastVisitOnSite'
order by et.Name
FOR XML PATH ('PersonBadge'), root ('root' )
