/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [IdPedido]
      ,[PrecioUnidad]
      ,[cantidad]
      ,[Descuento]
  FROM [Detalle_Pedidos].[dbo].[detallepedidos]