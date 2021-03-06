USE [master]
GO
/****** Object:  Database [PADARIA_SISTEMA]    Script Date: 23/03/2015 09:34:14 ******/
CREATE DATABASE [PADARIA_SISTEMA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PADARIA_SISTEMA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\PADARIA_SISTEMA.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PADARIA_SISTEMA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\PADARIA_SISTEMA_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PADARIA_SISTEMA] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PADARIA_SISTEMA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PADARIA_SISTEMA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET ARITHABORT OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET  MULTI_USER 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PADARIA_SISTEMA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PADARIA_SISTEMA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [PADARIA_SISTEMA]
GO
/****** Object:  StoredProcedure [dbo].[_aspAlteraEstoquePorID]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlteraEstoquePorID]

@Id int,
@quantidade int,
@operacao varchar(1)
AS
BEGIN
	      
	   DECLARE @IdProduto int;

	   IF(@operacao = '+')BEGIN		     
	   SELECT @IdProduto = B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE  B.ID = @Id;	   
	   UPDATE ESTOQUE SET QUANTIDADE += @quantidade WHERE ID = @IdProduto;	  
	   SELECT @IdProduto as Retorno;		
	   END
	   ELSE IF(@operacao = '-') BEGIN
	   IF  EXISTS(SELECT B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE A.QUANTIDADE >= @quantidade AND B.ID = @Id) BEGIN	 	  
	   SELECT @IdProduto = B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE  B.ID = @Id;	 
	   UPDATE ESTOQUE SET QUANTIDADE -= @quantidade WHERE ID = @IdProduto;
	   SELECT @IdProduto as Retorno;
	   END
	   END
	   ELSE BEGIN
	    SELECT @IdProduto = B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE  B.ID = @Id;	 
	   UPDATE ESTOQUE SET QUANTIDADE -= @quantidade WHERE ID = @IdProduto;
	   SELECT @IdProduto as Retorno;	  
	   END
	 
END










GO
/****** Object:  StoredProcedure [dbo].[_aspAlterarCaixa]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlterarCaixa]
@valor numeric(18,2),
@Operacao varchar(1),
@IdUsuario int
AS
BEGIN
BEGIN TRAN
IF EXISTS(SELECT * FROM CAIXA)BEGIN
IF(@Operacao = '+')BEGIN
UPDATE CAIXA SET VALOR += @valor, IDUSUARIO = @IdUsuario;
SELECT 1 AS RETORNO;
END
IF(@Operacao = '-')BEGIN
UPDATE CAIXA SET VALOR -= @valor, IDUSUARIO = @IdUsuario;
SELECT 1 AS RETORNO;
END
END
ELSE BEGIN
INSERT INTO CAIXA(VALOR,IDUSUARIO) VALUES(@valor,@IdUsuario);
select @@IDENTITY as retorno;
END
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspAlterarCategoria]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlterarCategoria]
@Id int,
@Nome varchar(50)
AS
BEGIN
IF EXISTS (SELECT * FROM CATEGORIA WHERE ID = @Id)BEGIN
UPDATE CATEGORIA SET NOME = @Nome WHERE ID = @Id;
SELECT 1 AS RETORNO;
END


END










GO
/****** Object:  StoredProcedure [dbo].[_aspAlterarCliente]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlterarCliente]
@Id int,
@Nome varchar(50),
@CPF varchar(15),
@Celular varchar(15)
AS
BEGIN
BEGIN TRAN
IF EXISTS(SELECT * FROM CLIENTE WHERE ID =@Id)BEGIN

UPDATE CLIENTE 
SET NOME = @Nome,
CPF = @CPF,
CELULAR=@Celular 
WHERE ID=@Id;

SELECT @Id AS RETORNO;

COMMIT TRAN
END
END






GO
/****** Object:  StoredProcedure [dbo].[_aspAlterarComanda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlterarComanda]
@Id int,
@Codigo varchar(50)
AS
BEGIN
UPDATE COMANDA SET CODIGO=@Codigo WHERE ID=@Id;
SELECT @Id AS RETORNO;
END






GO
/****** Object:  StoredProcedure [dbo].[_aspAlterarFiado]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlterarFiado]
@IDCLIENTE INT,
@VALORPAGO NUMERIC(18,2)
AS
BEGIN
BEGIN TRAN
UPDATE FIADO SET VALOR -= @VALORPAGO WHERE [ID CLIENTE] = @IDCLIENTE;
UPDATE CAIXA SET VALOR += @VALORPAGO;
IF EXISTS(SELECT * FROM FIADO WHERE [ID CLIENTE] = @IDCLIENTE AND VALOR <=0)BEGIN
DELETE FROM FIADO WHERE VALOR <= 0;
END
SELECT @IDCLIENTE AS RETORNO;
COMMIT TRAN
END





GO
/****** Object:  StoredProcedure [dbo].[_aspAlterarProduto]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspAlterarProduto]

@nome varchar(50),
@codigo varchar(max),
@categoria int,
@precocompra numeric(18,2),
@precovenda numeric(18,2),
@descricao varchar(70),
@Porcentagem decimal,
@QtdMin int,
@QtdMax int,
@Quantidade int,
@ID INT
AS
BEGIN
IF(@precovenda >   0)BEGIN
UPDATE  PRODUTO
SET
NOME=@nome,
CODIGO=@codigo,
CATEGORIA=@categoria,
PRECOCOMPRA=@precocompra,
PRECOVENDA=@precovenda,
Descricao=@descricao
 WHERE ID=@ID; 
 IF(@ID <> 0 )BEGIN
 UPDATE ESTOQUE SET QUANTIDADE = @Quantidade, QUANTIDADEMAXIMA = @QtdMax, QUANTIDADEMINIMA = @QtdMin WHERE ID=@ID; ;
 SELECT 1 AS RETORNO; 
 END
 END
 ELSE
 UPDATE  PRODUTO
SET
NOME=@nome,
CODIGO=@codigo,
CATEGORIA=@categoria,
Descricao=@descricao,
PORCENTAGEM = @Porcentagem
 WHERE ID=@ID; 
 IF(@ID <> 0 )BEGIN
 UPDATE ESTOQUE SET QUANTIDADE = @Quantidade, QUANTIDADEMAXIMA = @QtdMax, QUANTIDADEMINIMA = @QtdMin WHERE ID=@ID; ;
 SELECT 1 AS RETORNO;
 END

END

/*UPDATE T1 SET T1.Campo = T2.Campo

FROM T1 INNER JOIN T2 ON T1.Chave = T2.Chave*/










GO
/****** Object:  StoredProcedure [dbo].[_aspALterarUsuario]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspALterarUsuario]
@Id int,
@Nome varchar(15),
@Senha varchar(15),
@Permissao varchar(15)
AS
BEGIN
BEGIN TRAN
IF EXISTS(SELECT * FROM USUARIOS WHERE ID=@Id)begin
UPDATE USUARIOS SET NOME=@Nome,Senha=@Senha,Permicao=@Permissao where ID=@Id;
select @Id;
COMMIT TRAN
END
END






GO
/****** Object:  StoredProcedure [dbo].[_aspDeletarDatas]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspDeletarDatas]
AS
BEGIN
BEGIN TRAN
DELETE FROM DATA;
DBCC CHECKIDENT(Data, RESEED, 0);
SELECT 1 AS RETORNO;
COMMIT TRAN
END


GO
/****** Object:  StoredProcedure [dbo].[_aspDeleteCategoria]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspDeleteCategoria]
@Id int
AS
BEGIN
IF EXISTS(SELECT * FROM CATEGORIA WHERE ID = @Id)BEGIN
DELETE FROM CATEGORIA WHERE ID=@Id;
IF(@Id <> 0)BEGIN
SELECT 1 AS RETORNO;
END
END

END 











GO
/****** Object:  StoredProcedure [dbo].[_aspDeleteCliente]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspDeleteCliente]
@Id int
AS
BEGIN
BEGIN TRAN
IF EXISTS(SELECT * FROM CLIENTE WHERE ID =@Id)BEGIN
DELETE FROM CLIENTE WHERE ID=@Id;
SELECT @Id AS RETORNO;
COMMIT TRAN
END
END






GO
/****** Object:  StoredProcedure [dbo].[_aspDeleteComanda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
creaTE PROCEDURE [dbo].[_aspDeleteComanda]
@ID int
AS
BEGIN 
BeGIN TRAN
DELETE COMANDA WHERE ID=@ID;
SELECT @ID;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspDeleteProduto]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspDeleteProduto]
@id int
AS
BEGIN
BEGIN TRAN
DELETE FROM ESTOQUE WHERE ID=@id;
DELETE FROM PRODUTO WHERE ID=@id;
IF(@id <> 0)BEGIN
select 1 as retorno;
COMMIT TRAN
END
END










GO
/****** Object:  StoredProcedure [dbo].[_aspDeleteUsuario]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspDeleteUsuario]
@Id int
AS
BEGIN
BEGIN TRAN
DELETE FROM USUARIOS WHERE ID=@Id;
COMMIT TRAN
END

SELECT * FROM USUARIOS






GO
/****** Object:  StoredProcedure [dbo].[_aspDeletVendaPorComandaAtiva]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[_aspDeletVendaPorComandaAtiva]
@CodigoComanda varchar(50)
AS
BEGIN
DECLARE @ID INT;
BEGIN TRAN
SELECT @ID=A.ID FROM COMANDA A WHERE A.CODIGO = @CodigoComanda/*'0100'*/;
IF(@ID > 0)BEGIN
BEGIN TRAN
DELETE FROM VendaComComandaAtiva WHERE IDCOMANDA = @ID;
SELECT 1 AS RETORNO;
COMMIT TRAN
END
COMMIT TRAN
END







GO
/****** Object:  StoredProcedure [dbo].[_aspExCluirEstoque]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspExCluirEstoque]
@IdProduto int,
@quantidade int
AS
BEGIN
/*DECLARE @idNovo int;
DECLARE @quant int;*/

  BEGIN TRAN
   --742709100208
   
     /* SELECT @idNovo =  A.IDPRODUTO,@quant = A.QUANTIDADE 
	  FROM EstoqueEmAndamento as A 
	  WHERE A.IDPRODUTO = @IdProduto;*/
             
	  UPDATE ESTOQUE SET QUANTIDADE -= @quantidade WHERE ID = @IdProduto;
	  DECLARE @Q int;
	  --IF EXISTS (SELECT * FROM ESTOQUE WHERE ID = @IdProduto AND QUANTIDADE >= @quantidade)BEGIN
      --IF
	  SELECT @Q = A.QUANTIDADE FROM ESTOQUE as A WHERE ID=@IdProduto

	  IF(@Q >= 0)BEGIN
	   SELECT @IdProduto AS RETORNO;
	  END
  	 
	  --DELETE  FROM  EstoqueEmAndamento;
    -- END
	COMMIT TRAN
END








GO
/****** Object:  StoredProcedure [dbo].[_aspFecharCaixa]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspFecharCaixa]
as
begin
BEGIN TRAN
delete from CAIXA;
SELECT 1 AS RETORNO;
COMMIT TRAN
end






GO
/****** Object:  StoredProcedure [dbo].[_aspInsertCaixa]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertCaixa]
@Caixa numeric(18,2),
@IdUsuario int
AS
BEGIN
IF EXISTS(SELECT * FROM CAIXA)BEGIN
BEGIN TRAN
update CAIXA set VALOR = @Caixa, IDUSUARIO = @IdUsuario;
SELECT 1 AS RETORNO;
COMMIT TRAN
END
ELSE BEGIN
BEGIN TRAN
INSERT INTO CAIXA(VALOR,IDUSUARIO) VALUES(@Caixa,@IdUsuario);
COMMIT TRAN
END
END








GO
/****** Object:  StoredProcedure [dbo].[_aspInsertCategoria]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertCategoria]
@nome varchar(50)
AS
BEGIN
  DECLARE @IdCategoria int;
  IF NOT EXISTS(SELECT * FROM CATEGORIA WHERE NOME =@nome)BEGIN
 INSERT INTO CATEGORIA(NOME) VALUES(@nome);
 SET @IdCategoria = @@IDENTITY;
 IF(@IdCategoria <> 0)BEGIN
 SELECT @IdCategoria AS RETORNO;
 END
 END
END










GO
/****** Object:  StoredProcedure [dbo].[_aspInsertCliente]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertCliente]
@Nome varchar(50),
@cpf VARCHAR(15),
@telefone varchar(15)
AS
BEGIN
BEGIN TRAN
IF(@Nome <> '' AND @cpf <> '' AND @telefone <> '')BEGIN
INSERT INTO CLIENTE(NOME,CPF,CELULAR)
VALUES(@Nome,@cpf,@telefone)
SELECT @@IDENTITY AS RETORNO;
END
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspInsertComanda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertComanda]
@codigo Varchar(50)
AS
BEGIN
BEGIN TRAN
INSERT INTO COMANDA(CODIGO) VALUES(@codigo);
SELECT @@IDENTITY AS RETORNO;
COMMIT TRAN
END








GO
/****** Object:  StoredProcedure [dbo].[_asPInsertData]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_asPInsertData]
@Data varchar(15)
AS
BEGIN
BEGIN TRAN
DECLARE @ID INT;
IF NOT EXISTS(SELECT * FROM DATA WHERE DATA=@Data)BEGIN
insert into data(data) values(@Data);
select @ID = @@IDENTITY;
/*IF(@ID = 30)BEGIN
DELETE FROM DATA;
DBCC CHECKIDENT(Data, RESEED, 0);
END*/
END
COMMIT TRAN
END


GO
/****** Object:  StoredProcedure [dbo].[_aspInsertDataDiferente]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertDataDiferente]
AS
BEGIN
BEGIN TRAN
DECLARE @ID INT, @Data varchar(12);
SET @Data = GETDATE();
IF NOT EXISTS(SELECT * FROM DATA WHERE DATA=@Data) BEGIN
insert into data(data) values(@Data);
select @ID = @@IDENTITY;
/*IF(@ID = 30)BEGIN
DELETE FROM DATA;
DBCC CHECKIDENT(Data, RESEED, 0);
END*/
END
COMMIT TRAN
END


GO
/****** Object:  StoredProcedure [dbo].[_aspInsertFiado]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertFiado]
@IDFUNCIONARIO INT,
@IDCLIENTE INT,
@VALOR NUMERIC(18,2)
AS
BEGIN
IF NOT EXISTS(SELECT * FROM FIADO WHERE [ID CLIENTE]=@IDCLIENTE)BEGIN
INSERT INTO FIADO([ID CLIENTE],IDFUNCIONARIO,VALOR) VALUES(@IDCLIENTE,@IDFUNCIONARIO,@VALOR);
select @@IDENTITY as retorno;
END
ELSE BEGIN
DECLARE @ID INT;
SELECT @ID = A.ID FROM FIADO AS A WHERE [ID CLIENTE] = @IDCLIENTE;
UPDATE FIADO SET VALOR += @VALOR where ID = @ID;
END
END




GO
/****** Object:  StoredProcedure [dbo].[_aspInsertLogin]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertLogin]
@Nome varchar(15),
@Senha varchar(15),
@Permicao varchar(15)
AS
BEGIN
BEGIN TRAN
IF NOT EXISTS(SELECT * FROM USUARIOS WHERE NOME=@Nome)BEGIN
INSERT INTO USUARIOS(NOME,SENHA,Permicao)
VALUES(@Nome,@Senha,@Permicao);
SELECT @@IDENTITY AS RETORNO;
END
COMMIT TRAN
END	






GO
/****** Object:  StoredProcedure [dbo].[_aspInsertProduto]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertProduto]
@nome varchar(50),
@codigo varchar(max),
@categoria int,
@precocompra numeric(18,2),
@precovenda numeric(18,2),
@descricao varchar(70),
@Porcentagem decimal,
@QUANTIDADE INT,
@QtdMinimo int,
@QtdMaximo int
AS
BEGIN

     /*IF(@precovenda <> 0 OR @QtdMinimo <> 0 OR @Porcentagem = 0)BEGIN*/
     DECLARE @IdProduto INT, @IdEstoque INT;
	 IF NOT EXISTS(SELECT * FROM PRODUTO WHERE CODIGO=@codigo) BEGIN
	 INSERT INTO PRODUTO(CODIGO,CATEGORIA,NOME,PRECOCOMPRA,PRECOVENDA,DESCRICAO,PORCENTAGEM) VALUES(@codigo,@categoria,@nome,@precocompra,@precovenda,@descricao,@Porcentagem);
	 SET @IdProduto = @@IDENTITY;
	-- SELECT @IdProduto AS CODPROD
	 INSERT INTO ESTOQUE(ID,QUANTIDADE,QUANTIDADEMINIMA,QUANTIDADEMAXIMA) VALUES(@IdProduto,@QUANTIDADE,@QtdMinimo,@QtdMaximo);
	 
	 --SELECT @IdEstoque AS CODESTO;
	 IF(@IdProduto <> 0)BEGIN
	   SELECT @IdEstoque AS RETORNO ;
	 END
	/* END*/
	 
	END
	

END
 /*IF(@precovenda = 0 OR @QtdMinimo = 0 OR @Porcentagem > 0)BEGIN
	  IF NOT EXISTS(SELECT * FROM PRODUTO WHERE CODIGO=@codigo) BEGIN
	 INSERT INTO PRODUTO(CODIGO,CATEGORIA,NOME,PRECOCOMPRA,PRECOVENDA,DESCRICAO,PORCENTAGEM) VALUES(@codigo,@categoria,@nome,0,0,@descricao,@Porcentagem);
	 SELECT @@IDENTITY;

	  END
	END*/









GO
/****** Object:  StoredProcedure [dbo].[_aspInsertTipoPagamentoFormVenda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertTipoPagamentoFormVenda]
AS
BEGIN
DECLARE @QUANTIDADE INT; 
SELECT @QUANTIDADE = COUNT(*) FROM TIPOPAGAMENTO;
IF(@QUANTIDADE = 0)BEGIN
INSERT INTO TIPOPAGAMENTO(TIPO) VALUES('Dinheiro');
INSERT INTO TIPOPAGAMENTO(TIPO) VALUES('Cartão');
INSERT INTO TIPOPAGAMENTO(TIPO) VALUES('Fiado');
END


END


/*

SELECT OBJECT_NAME(OBJECT_ID) TableName, st.row_count
 FROM sys.dm_db_partition_stats st
 WHERE index_id < 2
 ORDER BY st.row_count DESC







*/



GO
/****** Object:  StoredProcedure [dbo].[_aspInsertVenda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspInsertVenda]
@VENDATOTAL numeric(18,2),
@LucroTotal numeric(18,2),
@Data varchar(15),
@IDPAGAMENTO int,
@Idusuario int
AS
BEGIN

INSERT INTO VENDA(VENDATOTAL,LUCROTOTAL,DATA,IDUSUARIO,IDTIPOPAGAMENTO)
VALUES(@VENDATOTAL,@LucroTotal,@Data,@Idusuario,@IDPAGAMENTO);
SELECT @@IDENTITY AS RETORNO;

END







GO
/****** Object:  StoredProcedure [dbo].[_aspPegaQuantidadeDeRegistros]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspPegaQuantidadeDeRegistros]
as
begin
declare @q int;
SELECT COUNT(*) AS Quantidade FROM DATA;
end



GO
/****** Object:  StoredProcedure [dbo].[_aspPegarDataDoBanco]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspPegarDataDoBanco]
AS
BEGIN
select GETDATE() as data;

END


GO
/****** Object:  StoredProcedure [dbo].[_aspPegarDiasValidos]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspPegarDiasValidos]
as
begin
declare @q int;
SELECT @q =  30 - COUNT(*) FROM DATA;
SELECT @q AS DATA;
end



GO
/****** Object:  StoredProcedure [dbo].[_aspSelecionaVendaForaDaComandaPorCodigo]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelecionaVendaForaDaComandaPorCodigo]
@quantidade int,
@codigoProduto varchar(50)
AS
BEGIN
DECLARE @IdProduto int;
SELECT ID,NOME,CODIGO,
SUM(@quantidade * PRECOVENDA) TOTAL, @quantidade Quantidade,
Sum(@quantidade * (PRECOVENDA - PRECOCOMPRA)) Lucro from PRODUTO 
WHERE CODIGO = @codigoProduto AND PRECOCOMPRA > 0 AND PRECOCOMPRA > 0
GROUP BY CODIGO,NOME,ID;
END








GO
/****** Object:  StoredProcedure [dbo].[_aspSelecionaVendaForaDaComandaPorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelecionaVendaForaDaComandaPorId]
@quantidade int,
@IdProduto INT
AS
BEGIN

SELECT distinct ID,NOME,CODIGO,SUM(@quantidade * PRECOVENDA) TOTAL, @quantidade Quantidade,Sum(@quantidade * (PRECOVENDA - PRECOCOMPRA)) Lucro
FROM PRODUTO 
WHERE ID = @IdProduto AND PRECOCOMPRA > 0 AND PRECOVENDA > 0 GROUP BY CODIGO,NOME,ID;
END








GO
/****** Object:  StoredProcedure [dbo].[_aspSelectCaixa]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREate PROCEDURE [dbo].[_aspSelectCaixa]

AS
BEGIN
SELECT A.VALOR FROM CAIXA AS A ;
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectCliente]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectCliente]

AS
BEGIN
SELECT distinct A.ID,NOME,A.CPF,A.CELULAR,Sum(B.VALOR) AS TOTAL
FROM CLIENTE AS A INNER JOIN FIADO AS B ON A.ID=B.[ID CLIENTE]
group by A.NOME,A.CPF,A.CELULAR,a.ID;
END





GO
/****** Object:  StoredProcedure [dbo].[_aspSelectClientePorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectClientePorId]
@Id int
AS
BEGIN
SELECT A.ID,A.NOME,A.CPF,A.CELULAR FROM CLIENTE AS A WHERE ID=@ID;
END




GO
/****** Object:  StoredProcedure [dbo].[_aspSelectClienteSemValor]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_aspSelectClienteSemValor]

AS
BEGIN
SELECT distinct A.ID,NOME,A.CPF,A.CELULAR FROM CLIENTE AS A;
END





GO
/****** Object:  StoredProcedure [dbo].[_aspSelectComanda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[_aspSelectComanda]

AS
BEGIN
SELECT A.ID,A.CODIGO FROM COMANDA AS A;
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectComandaPorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectComandaPorId]
@ID INT
AS
BEGIN
BEGIN TRAN
SELECT * FROM COMANDA WHERE ID=@ID;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectCpfPorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectCpfPorId]
@Id INT
as
BEGIN
SELECT B.CPF FROM CLIENTE AS B WHERE B.ID= @Id;
END




GO
/****** Object:  StoredProcedure [dbo].[_aspSelectEstoqueEmOutraTabela]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectEstoqueEmOutraTabela]
as
begin
SELECT IDPRODUTO, QUANTIDADE FROM EstoqueEmAndamento
end







GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullCategoria]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectFullCategoria]
AS
BEGIN
SELECT DISTINCT(A.NOME),A.ID FROM CATEGORIA AS A ;
 
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullCategoriaPorID]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectFullCategoriaPorID]
@ID int
AS
BEGIN
SELECT DISTINCT(A.NOME),A.ID FROM CATEGORIA AS A /*inner JOIN PRODUTO AS B ON A.ID = A.ID*/ WHERE A.ID = @ID;
 
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullCategoriaPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectFullCategoriaPorNome]
@Nome varchar(50)
AS

BEGIN
IF EXISTS(SELECT * FROM CATEGORIA WHERE NOME LIKE '%'+@Nome+'%')BEGIN
SELECT A.NOME,A.ID FROM CATEGORIA AS A WHERE NOME LIKE '%'+@Nome+'%';
END

END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullProdutoComNomeDaCategoria]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectFullProdutoComNomeDaCategoria]
@Categoria varchar(50),
@Peso varchar(3)
AS
BEGIN
IF EXISTS(SELECT  A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO FROM PRODUTO AS A INNER JOIN CATEGORIA AS B ON A.CATEGORIA = B.ID WHERE B.NOME LIKE '%'+@Categoria+'%')BEGIN       
IF(@Peso = 'Nao')begin
SELECT  A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,C.QUANTIDADE,A.DESCRICAO FROM PRODUTO AS A
        INNER JOIN CATEGORIA AS B ON A.CATEGORIA = B.ID INNER JOIN ESTOQUE AS C ON A.ID = C.ID WHERE B.NOME LIKE '%'+@Categoria+'%' AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA > 0;

END
 ELSE IF(@Peso = 'Pes')BEGIN
 SELECT  A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,C.QUANTIDADE FROM PRODUTO AS A
        INNER JOIN CATEGORIA AS B ON A.CATEGORIA = B.ID INNER JOIN ESTOQUE AS C ON A.ID = C.ID WHERE B.NOME LIKE '%'+@Categoria+'%';
 END
  else if(@Peso = 'Sim') begin
  SELECT  A.ID,A.CODIGO,A.NOME,A.CATEGORIA,a.PORCENTAGEM,A.DESCRICAO FROM PRODUTO AS A
        INNER JOIN CATEGORIA AS B ON A.CATEGORIA = B.ID INNER JOIN ESTOQUE AS C ON A.ID = C.ID WHERE B.NOME LIKE '%'+@Categoria+'%' AND A.PORCENTAGEM> 0;

  END



END
END











GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullProdutoPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectFullProdutoPorNome]
@Nome varchar(50)
AS
BEGIN

SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,B.QUANTIDADE 
       FROM PRODUTO AS A INNER JOIN ESTOQUE as B ON A.ID = B.ID WHERE NOME LIKE '%'+@Nome+'%';


END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullProdutoSemParametro]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_aspSelectFullProdutoSemParametro]
AS
BEGIN
SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,B.QUANTIDADE
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.PRECOVENDA<>0 AND A.PRECOCOMPRA<>0;
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullProdutoSemParametroPorPeso]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[_aspSelectFullProdutoSemParametroPorPeso]
AS
BEGIN
SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PORCENTAGEM,A.DESCRICAO
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.PRECOVENDA=0 AND A.PRECOCOMPRA=0 and A.PORCENTAGEM > 0;
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullTipoPagamento]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[_aspSelectFullTipoPagamento]
 as
 begin
 SELECT A.ID,A.TIPO FROM TIPOPAGAMENTO AS A;
 end






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectFullUsuario]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectFullUsuario]
AS
BEGIN
SELECT A.ID,A.NOME,A.SENHA,A.Permicao FROM USUARIOS AS A;
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectIdPorCpfFiado]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectIdPorCpfFiado]
@Cpf varchar(15)
as
BEGIN
SELECT B.ID FROM CLIENTE AS B WHERE CPF= @Cpf;
END




GO
/****** Object:  StoredProcedure [dbo].[_aspSelectIdPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectIdPorNome]
@nOME varchar(50)
as
BEGIN
SELECT B.ID FROM CLIENTE AS B WHERE B.NOME= @nOME;
END




GO
/****** Object:  StoredProcedure [dbo].[_aspSelectIDTipoPagamentoPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectIDTipoPagamentoPorNome]
@Nome varchar(15)
AS
BEGIN
SELECT a.ID FROM TIPOPAGAMENTO as a where TIPO=@Nome;
END







GO
/****** Object:  StoredProcedure [dbo].[_aspSelectIdUsuarioPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectIdUsuarioPorNome]
@Nome varchar(50)
AS
BEGIN
BEGIN TRAN
SELECT ID FROM USUARIOS WHERE NOME =@Nome;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectLogin]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectLogin]
@Nome varchar(15),
@Senha varchar(15)
AS
BEGIN
BEGIN TRAN
SELECT A.NOME,A.Permicao AS Permissão,a.SENHA FROM USUARIOS AS A WHERE NOME=@Nome AND SENHA = @Senha;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectLoginPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectLoginPorNome]
@Nome varchar(15)
AS
BEGIN
BEGIN TRAN
SELECT * FROM USUARIOS WHERE NOME=@Nome;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectNomeCategoriaPorID]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectNomeCategoriaPorID]
@Nome varchar(50)
AS
BEGIN
SELECT distinct(A.ID) FROM CATEGORIA AS A WHERE A.NOME = @Nome;
END











GO
/****** Object:  StoredProcedure [dbo].[_aspSelectNomeFiado]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectNomeFiado]
AS
BEGIN
SELECT B.NOME FROM CLIENTE AS B;
END




GO
/****** Object:  StoredProcedure [dbo].[_aspSelectPermissaoPorUsuario]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectPermissaoPorUsuario]
@Nome varchar(15)
AS
BEGIN
BEGIN TRAN
SELECT a.Permicao FROM USUARIOS AS A WHERE NOME = @Nome;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectProdutoFullComEstoque]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectProdutoFullComEstoque]
AS
BEGIN
/*IF EXISTS(SELECT * FROM PRODUTO WHERE PRECOVENDA > 0)BEGIN*/
SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,/*,A.PRECOCOMPRA,*/A.DESCRICAO
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID /*WHERE A.PRECOCOMPRA <> 0 AND A.PRECOVENDA <> 0;END*/;
/*ELSE IF EXISTS(SELECT * FROM PRODUTO WHERE PORCENTAGEM > 0)BEGIN*/
/*SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,,A.PRECOCOMPRA,A.PORCENTAGEM,A.DESCRICAO
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.PRECOCOMPRA <> 0 AND A.PRECOVENDA <> 0;END*/
END











GO
/****** Object:  StoredProcedure [dbo].[_aspSelectProdutoPorCodigo]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectProdutoPorCodigo]
@Codigo varchar(Max),
@Peso VARchar(3)
AS
BEGIN
IF EXISTS(SELECT * FROM PRODUTO WHERE CODIGO=@Codigo)BEGIN
 IF(@Peso = 'Nao') BEGIN
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,B.QUANTIDADE
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.CODIGO = @Codigo AND A.PRECOVENDA > 0 AND A.PRECOCOMPRA >0;
 END
 ELSE IF(@Peso = 'Pes')BEGIN
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,B.QUANTIDADE
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.CODIGO = @Codigo;
 END
 ELSE BEGIN
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,a.PORCENTAGEM,A.DESCRICAO
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.CODIGO = @Codigo AND A.PORCENTAGEM > 0;
 END
 end	
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectProdutoPorCodigoEPorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectProdutoPorCodigoEPorId]
@ID INT,
@CODIGO VARCHAR(50)
AS
BEGIN
IF(@ID <> 0 AND @CODIGO = 'c')BEGIN
BEGIN TRAN
SELECT a.ID,a.CODIGO,a.NOME,b.QUANTIDADE,b.QUANTIDADEMINIMA as MIN,b.QUANTIDADEMAXIMA as MAX
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B ON A.ID = B.ID 
WHERE A.ID=@ID AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA > 0; 
COMMIT TRAN
END
ELSE IF (@ID = 0 AND @CODIGO <> 'c')BEGIN
BEGIN TRAN
SELECT a.ID,a.CODIGO,a.NOME,b.QUANTIDADE,b.QUANTIDADEMINIMA as MIN,b.QUANTIDADEMAXIMA as MAX
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B ON A.ID = B.ID 
WHERE A.CODIGO=@CODIGO  AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA > 0;
COMMIT TRAN
END
ELSE IF(@ID = -1 AND @CODIGO = -1)BEGIN
BEGIN TRAN
SELECT a.ID,a.CODIGO,a.NOME,b.QUANTIDADE,b.QUANTIDADEMAXIMA AS MAX ,b.QUANTIDADEMINIMA as MIN
FROM PRODUTO AS A INNER JOIN ESTOQUE AS B ON A.ID = B.ID  AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA > 0
COMMIT TRAN
END
END



GO
/****** Object:  StoredProcedure [dbo].[_aspSelectProdutoPorID]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectProdutoPorID]
@ID int,
@Peso varchar(3)
AS
BEGIN
 IF EXISTS(SELECT * FROM PRODUTO WHERE ID=ID)BEGIN
 IF(@Peso = 'Nao')begin
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA as CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,B.QUANTIDADE
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID  WHERE A.ID = @ID AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA >0 ;
 end
 ELSE IF(@Peso = 'Pes')BEGIN
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA  as CATEGORIA ,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,A.PORCENTAGEM,B.QUANTIDADE,B.QUANTIDADEMAXIMA AS QTDMAX,B.QUANTIDADEMINIMA AS QTDMIN
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID   WHERE A.ID= @ID;
 END
  else if(@Peso = 'Sim') begin
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA  as CATEGORIA,A.PORCENTAGEM,A.DESCRICAO
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID  WHERE A.ID = @ID AND A.PORCENTAGEM > 0;
end
 END 
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectProdutoPorNome]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectProdutoPorNome]
@NOME VARCHAR(50),
@Peso varchar(3)
AS
BEGIN
IF EXISTS(SELECT * FROM PRODUTO AS A WHERE A.NOME LIKE '%'+@NOME+'%')BEGIN
IF(@Peso = 'Nao')BEGIN
SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO,B.QUANTIDADE
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.NOME LIKE '%'+@NOME+'%' AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA >0 ;
 END
 
 IF(@Peso = 'Pes')BEGIN
 SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA/*,A.PRECOCOMPRA,A.PRECOVENDA,B.QUANTIDADE,*/,A.DESCRICAO
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.NOME LIKE '%'+@NOME+'%';
 END
 
  IF(@Peso = 'Sim')BEGIN
SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PORCENTAGEM,A.DESCRICAO
 FROM PRODUTO AS A INNER JOIN ESTOQUE AS B  ON A.ID = B.ID WHERE A.NOME LIKE '%'+@NOME+'%' AND A.PORCENTAGEM > 0 AND A.PRECOCOMPRA = 0 AND A.PRECOVENDA =0;
 END
END
 IF(@Peso = 'Otr')BEGIN
IF EXISTS(SELECT * FROM PRODUTO AS A WHERE A.NOME LIKE '%'+@NOME+'%' AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA > 0 )BEGIN

SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA/*,A.PRECOCOMPRA,A.PRECOVENDA,A.DESCRICAO*/,B.QUANTIDADE 
       FROM PRODUTO AS A INNER JOIN ESTOQUE as B ON A.ID = B.ID WHERE NOME LIKE '%'+@NOME+'%';
	   END
	   ELSE BEGIN
	   SELECT A.ID,A.CODIGO,A.NOME,A.CATEGORIA,A.PORCENTAGEM
       FROM PRODUTO AS A INNER JOIN ESTOQUE as B ON A.ID = B.ID WHERE NOME LIKE '%'+@NOME+'%';
	   END
	   
END
END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectProutoFullComPeso]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectProutoFullComPeso]
@NOME VARCHAR(30)
AS
BEGIN

IF EXISTS(SELECT * FROM PRODUTO AS A WHERE A.NOME LIKE '%'+@NOME+'%' AND A.PRECOCOMPRA > 0 AND A.PRECOVENDA > 0 )BEGIN
SELECT A.ID,A.CODIGO,A.NOME,a.DESCRICAO 
       FROM PRODUTO AS A INNER JOIN ESTOQUE as B ON A.ID = B.ID WHERE NOME LIKE '%'+@NOME+'%';
	   END



END


GO
/****** Object:  StoredProcedure [dbo].[_aspSelectValorDaVendaComComandaAtiva]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectValorDaVendaComComandaAtiva]
@CodigoComanda varchar(50)
AS
BEGIN

DECLARE @QUANTIDADE INT;
DECLARE @TotalFull numeric(18,2) 


/*SET @QUANTIDADE = (SELECT  A.QUANTIDADE 
FROM VendaComComandaAtiva 
AS A INNER JOIN PRODUTO 
AS B ON A.IDPRODUTO = B.ID INNER JOIN COMANDA 
AS C ON A.IDCOMANDA = C.ID WHERE C.CODIGO = @CodigoComanda);

IF(@QUANTIDADE <> 0)BEGIN*/
SELECT A.ID,A.IDCOMANDA,A.IDPRODUTO,A.PRECOTOTAL,A.QUANTIDADE,B.NOME,C.CODIGO, SUM(A.QUANTIDADE*(B.PRECOVENDA - B.PRECOCOMPRA)) total FROM VendaComComandaAtiva AS A INNER JOIN 
PRODUTO AS B ON A.IDPRODUTO = B.ID INNER JOIN COMANDA AS C ON A.IDCOMANDA = C.ID WHERE C.CODIGO = @CodigoComanda 
GROUP BY A.ID
,A.IDCOMANDA
,A.IDPRODUTO,
A.PRECOTOTAL,
A.QUANTIDADE,
B.PRECOVENDA,
B.NOME,
C.CODIGO;

END










GO
/****** Object:  StoredProcedure [dbo].[_aspSelectValorDaVendaComComandaAtivaPorPreco]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectValorDaVendaComComandaAtivaPorPreco]
@CodigoComanda varchar(50)
AS 
BEGIN
SELECT 
A.ID,A.IDCOMANDA,A.IDPRODUTO,A.PRECOTOTAL,A.QUANTIDADE,B.NOME,C.CODIGO,SUM((A.PRECOTOTAL * B.PORCENTAGEM /100 )) as totalMax FROM VendaComComandaAtiva AS A INNER JOIN PRODUTO AS B ON A.IDPRODUTO = B.ID 
INNER JOIN COMANDA AS C ON A.IDCOMANDA = C.ID WHERE C.CODIGO = @CodigoComanda AND A.QUANTIDADE = 0
GROUP BY 
A.ID
,A.IDCOMANDA
,A.IDPRODUTO
,A.PRECOTOTAL
,A.QUANTIDADE
,B.PRECOVENDA
,B.NOME
,C.CODIGO;
END



GO
/****** Object:  StoredProcedure [dbo].[_aspSelectValoresNegativosNoEstoque]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectValoresNegativosNoEstoque]

AS
BEGIN
SELECT A.QUANTIDADE,
	   B.NOME FROM ESTOQUE as A INNER JOIN PRODUTO AS B  ON A.ID = B.ID WHERE QUANTIDADE < 0 AND B.PRECOVENDA <> 0 AND B.PRECOCOMPRA <>0;
END








GO
/****** Object:  StoredProcedure [dbo].[_aspSelectVenda]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectVenda]

AS
BEGIN
SELECT a.ID,a.VENDATOTAL [Total Vendido] ,
sum(a.LUCROTOTAL) [Lucro Bruto Total]
,a.DATA [Data Da Venda]
,a.IDUSUARIO [ID Do Funcionario],
b.TIPO [Tipo Do Pagamento]
FROM VENDA as a INNER JOIN TIPOPAGAMENTO AS B ON A.IDTIPOPAGAMENTO = B.ID 
GROUP BY A.DATA,A.ID,A.IDUSUARIO,A.LUCROTOTAL,A.VENDATOTAL,b.TIPO;


END







GO
/****** Object:  StoredProcedure [dbo].[_aspSelectVendaComandaAtivaPorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectVendaComandaAtivaPorId]
@IdComanda int 
as
begin
--DECLARE @NOMEPROD VARCHAR(50);
--DECLARE @QTD INT;
--DECLARE @IDPROD INT;
--SELECT  @ID= A.ID  FROM COMANDA as A WHERE ID=@IdComanda;

--SELECT @IDPROD = A.IDPRODUTO
--FROM VendaComComandaAtiva AS A 
--WHERE A.IDCOMANDA=@IdComanda;

--BEGIN TRAN
--DECLARE @NOME VARCHAR(50);
--DECLARE @QUAN INT;
--SELECT @NOMEPROD=A.NOME FROM PRODUTO AS A WHERE ID=@IDPROD;
 
SELECT distinct(B.NOME) AS NOME,sum(A.QUANTIDADE) AS QUANTIDADE FROM VendaComComandaAtiva AS A
INNER JOIN PRODUTO AS B ON a.IDPRODUTO=b.ID where A.IDCOMANDA =@IdComanda group by nome,QUANTIDADE;
--COMMIT TRAN
end





GO
/****** Object:  StoredProcedure [dbo].[_aspSelectVendaEntreData]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectVendaEntreData]
@dataUm varchar(15),
@dataDois varchar(15),
@Tipo varchar(15)
AS
BEGIN
IF(@Tipo = 'Todos')BEGIN
SELECT a.ID,a.VENDATOTAL [Total Vendido] ,
sum(a.LUCROTOTAL) [Lucro Bruto Total]
,a.DATA [Data Da Venda]
,a.IDUSUARIO [ID Do Funcionario]
FROM VENDA as a WHERE Convert(date,DATA) BETWEEN Convert(date,@dataUm) AND Convert(date,@dataDois)
GROUP BY A.ID,A.DATA,A.IDUSUARIO,A.LUCROTOTAL,A.VENDATOTAL;
END
ELSE BEGIN
SELECT a.ID,a.VENDATOTAL [Total Vendido] ,
sum(a.LUCROTOTAL) [Lucro Bruto Total]
,a.DATA [Data Da Venda]
,a.IDUSUARIO [ID Do Funcionario],
B.TIPO [Tipo Do Pagamento]
FROM VENDA as a INNER JOIN TIPOPAGAMENTO AS B ON A.IDTIPOPAGAMENTO=B.ID AND B.TIPO = @Tipo
WHERE Convert(date,DATA) BETWEEN Convert(date,@dataUm) AND Convert(date,@dataDois)
GROUP BY A.ID,A.DATA,A.IDUSUARIO,A.LUCROTOTAL,A.VENDATOTAL,B.TIPO;
END
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSelectVendaPorData]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSelectVendaPorData]	
@DataUm Varchar(15),
@tipo varchar(15)
AS
BEGIN
IF(@tipo = 'Todos')begin
SELECT
a.ID,
A.VENDATOTAL [Total Vendido]
,A.LUCROTOTAL [Lucro Bruto Total]
,A.DATA [Data Da Venda]
,A.IDUSUARIO [ID Do Funcionario]
FROM VENDA AS A where  Convert(date,A.DATA) = Convert(date,@DataUm)
end
ELSE BEGIN
SELECT 
a.ID,
A.VENDATOTAL [Total Vendido]
,A.LUCROTOTAL [Lucro Bruto Total]
,A.DATA [Data Da Venda]
,A.IDUSUARIO [ID Do Funcionario],
B.TIPO [Tipo Do Pagamento]
FROM VENDA AS A inner JOIN TIPOPAGAMENTO AS B ON A.IDTIPOPAGAMENTO = B.ID
WHERE Convert(date,A.DATA) = Convert(date,@DataUm) and b.TIPO =@tipo;
END
END






GO
/****** Object:  StoredProcedure [dbo].[_aspSomaVendaComandaPorPesoId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_aspSomaVendaComandaPorPesoId]
@IDCOMANDA int,
@IDPRODUTO int,
@PRECOVENDA numeric(18,2)
AS
BEGIN
begin tran

INSERT INTO VendaComComandaAtiva(IDCOMANDA,IDPRODUTO,QUANTIDADE,PRECOTOTAL)
VALUES(@IDCOMANDA,@IDPRODUTO,0,@PRECOVENDA);
SELECT @@IDENTITY AS RETORNO;
COMMIT TRAN
END


GO
/****** Object:  StoredProcedure [dbo].[_aspSomaVendaComandaPorPesoPorCodigo]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_aspSomaVendaComandaPorPesoPorCodigo]
@IDCOMANDA int,
@CoDigoProduto varchar(50),
@PRECOVENDA numeric(18,2)
AS

BEGIN
DECLARE @TOTAL NUMERIC(18,2),@IdProduto int;
SELECT @TOTAL =  A.PRECOVENDA,@IdProduto = A.ID 
FROM PRODUTO AS A 
WHERE A.CODIGO =@CoDigoProduto 
GROUP BY A.ID,A.PRECOVENDA;
INSERT INTO VendaComComandaAtiva(IDCOMANDA,IDPRODUTO,QUANTIDADE,PRECOTOTAL)
VALUES(@IDCOMANDA,@IdProduto,0,@PRECOVENDA);
SELECT @@IDENTITY AS RETORNO;
END


GO
/****** Object:  StoredProcedure [dbo].[_spAlterarEstoque]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_spAlterarEstoque]
@Codigo varchar(max),
@quantidade int,
@operacao varchar(1)
AS
BEGIN     
	   DECLARE @IdProduto int;

	   IF(@operacao = '+')BEGIN		     
	   SELECT @IdProduto = B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE  B.CODIGO = @Codigo;	   
	   UPDATE ESTOQUE SET QUANTIDADE += @quantidade WHERE ID = @IdProduto;	  
	   SELECT @IdProduto as Retorno;		
	   END
	   ELSE IF(@operacao = '-') BEGIN
	   IF  EXISTS(SELECT B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE A.QUANTIDADE >= @quantidade AND B.CODIGO = @Codigo) BEGIN	 	  
	   SELECT @IdProduto = B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE  B.CODIGO = @Codigo;	 
	   UPDATE ESTOQUE SET QUANTIDADE -= @quantidade WHERE ID = @IdProduto;
	   SELECT @IdProduto as Retorno;
	   END
	   END
	   ELSE BEGIN 
	   SELECT @IdProduto = B.ID FROM ESTOQUE AS A INNER JOIN PRODUTO AS B ON A.ID = B.ID WHERE  B.CODIGO = @Codigo;	 
	   UPDATE ESTOQUE SET QUANTIDADE -= @quantidade WHERE ID = @IdProduto;
	   SELECT @IdProduto as Retorno;	   
	 END
END










GO
/****** Object:  StoredProcedure [dbo].[aspDeletVendaPorComandaAtivaPorId]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[aspDeletVendaPorComandaAtivaPorId]
@IdComanda int
AS
BEGIN
DECLARE @ID INT;
IF EXISTS(SELECT A.ID FROM VendaComComandaAtiva AS A WHERE IDCOMANDA = @IdComanda)BEGIN
SELECT @ID=A.ID FROM COMANDA A WHERE A.ID = @IdComanda/*'0100'*/;
END
BEGIN TRAN
DELETE FROM VendaComComandaAtiva WHERE IDCOMANDA = @ID;
SELECT 1 AS RETORNO;
COMMIT TRAN
END






GO
/****** Object:  StoredProcedure [dbo].[T__aspSomaVendaComComandaAtivaPorCodigoDoProduto]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[T__aspSomaVendaComComandaAtivaPorCodigoDoProduto]
@IDCOMANDA int,
@CoDigoProduto varchar(50),
@QUANTIDADE int
AS
BEGIN
DECLARE @TOTAL NUMERIC(18,2),@IdProduto int;
SELECT @TOTAL = SUM(@QUANTIDADE * A.PRECOVENDA),@IdProduto = A.ID 
FROM PRODUTO AS A 
WHERE A.CODIGO =@CoDigoProduto 
GROUP BY A.ID;
INSERT INTO VendaComComandaAtiva(IDCOMANDA,IDPRODUTO,QUANTIDADE,PRECOTOTAL)
VALUES(@IDCOMANDA,@IdProduto,@QUANTIDADE,@TOTAL);
SELECT @@IDENTITY AS RETORNO;
END









GO
/****** Object:  StoredProcedure [dbo].[T__aspSomaVendaComComandaAtivaPorIDDoProduto]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T__aspSomaVendaComComandaAtivaPorIDDoProduto]
@IDCOMANDA int,
@IDPRODUTO int,
@QUANTIDADE int
AS
BEGIN
DECLARE @TOTAL NUMERIC(18,2);

begin tran
SELECT @TOTAL = SUM(@QUANTIDADE * A.PRECOVENDA) FROM PRODUTO AS A WHERE A.ID=@IDPRODUTO;
INSERT INTO VendaComComandaAtiva(IDCOMANDA,IDPRODUTO,QUANTIDADE,PRECOTOTAL)
VALUES(@IDCOMANDA,@IDPRODUTO,@QUANTIDADE,@TOTAL);
SELECT @@IDENTITY AS RETORNO;
COMMIT TRAN
END











GO
/****** Object:  Table [dbo].[CAIXA]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAIXA](
	[VALOR] [numeric](18, 2) NULL,
	[IDUSUARIO] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NOME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](50) NOT NULL,
	[CPF] [varchar](15) NOT NULL,
	[CELULAR] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COMANDA]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COMANDA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DATA]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DATA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DATA] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ESTOQUE]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTOQUE](
	[ID] [int] NOT NULL,
	[QUANTIDADE] [int] NOT NULL,
	[QUANTIDADEMINIMA] [int] NOT NULL,
	[QUANTIDADEMAXIMA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FIADO]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FIADO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID CLIENTE] [int] NOT NULL,
	[VALOR] [numeric](18, 2) NULL,
	[IDFUNCIONARIO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUTO]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUTO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO] [varchar](50) NULL,
	[NOME] [varchar](50) NOT NULL,
	[CATEGORIA] [int] NOT NULL,
	[PRECOCOMPRA] [numeric](18, 2) NOT NULL,
	[PRECOVENDA] [numeric](18, 2) NOT NULL,
	[DESCRICAO] [varchar](70) NULL,
	[PORCENTAGEM] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOPAGAMENTO]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TIPOPAGAMENTO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TIPO] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOME] [varchar](20) NOT NULL,
	[SENHA] [varchar](20) NOT NULL,
	[Permicao] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[NOME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDA]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDA](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[VENDATOTAL] [numeric](18, 2) NOT NULL,
	[LUCROTOTAL] [numeric](18, 2) NOT NULL,
	[DATA] [varchar](15) NOT NULL,
	[IDUSUARIO] [int] NULL,
	[IDTIPOPAGAMENTO] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VendaComComandaAtiva]    Script Date: 23/03/2015 09:34:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendaComComandaAtiva](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPRODUTO] [int] NOT NULL,
	[IDCOMANDA] [int] NOT NULL,
	[QUANTIDADE] [int] NOT NULL,
	[PRECOTOTAL] [numeric](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CAIXA]  WITH CHECK ADD FOREIGN KEY([IDUSUARIO])
REFERENCES [dbo].[USUARIOS] ([ID])
GO
ALTER TABLE [dbo].[ESTOQUE]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[PRODUTO] ([ID])
GO
ALTER TABLE [dbo].[FIADO]  WITH CHECK ADD FOREIGN KEY([ID CLIENTE])
REFERENCES [dbo].[CLIENTE] ([ID])
GO
ALTER TABLE [dbo].[FIADO]  WITH CHECK ADD FOREIGN KEY([IDFUNCIONARIO])
REFERENCES [dbo].[USUARIOS] ([ID])
GO
ALTER TABLE [dbo].[PRODUTO]  WITH CHECK ADD FOREIGN KEY([CATEGORIA])
REFERENCES [dbo].[CATEGORIA] ([ID])
GO
ALTER TABLE [dbo].[VENDA]  WITH CHECK ADD  CONSTRAINT [chave_estrangeira_TipoPagamento] FOREIGN KEY([IDTIPOPAGAMENTO])
REFERENCES [dbo].[TIPOPAGAMENTO] ([ID])
GO
ALTER TABLE [dbo].[VENDA] CHECK CONSTRAINT [chave_estrangeira_TipoPagamento]
GO
ALTER TABLE [dbo].[VENDA]  WITH CHECK ADD FOREIGN KEY([IDUSUARIO])
REFERENCES [dbo].[USUARIOS] ([ID])
GO
ALTER TABLE [dbo].[VendaComComandaAtiva]  WITH CHECK ADD FOREIGN KEY([IDCOMANDA])
REFERENCES [dbo].[COMANDA] ([ID])
GO
ALTER TABLE [dbo].[VendaComComandaAtiva]  WITH CHECK ADD FOREIGN KEY([IDPRODUTO])
REFERENCES [dbo].[PRODUTO] ([ID])
GO
USE [master]
GO
ALTER DATABASE [PADARIA_SISTEMA] SET  READ_WRITE 
GO
