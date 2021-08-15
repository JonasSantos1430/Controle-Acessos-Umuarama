/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT TOP (1000) [Id_Registro]
      ,[Data]
      ,[Placa]
      ,[Modelo]
      ,[Cor]
      ,[Motorista]
      ,[RG]
      ,[Tipo_Registro]
      ,[Horário]
      ,[Casa]
  FROM [VEIC].[dbo].[Acessos]


  delete from Acessos where Id_Registro='4'