CREATE PROCEDURE SP_NuevaVenta (

@IdVendedor SMALLINT,
@IdCliente BIGINT,
@Monto MONEY,
@Fecha DATE
)
AS
BEGIN
	DECLARE @IdVenta INT

	SELECT @IdVenta = MAX(Id) FROM Ventas
	SET @IdVenta = @IdVenta + 1

	INSERT INTO Ventas VALUES (@IdVenta, @IdVendedor, @IdCliente, @Monto, @Fecha)
END