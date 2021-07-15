CREATE PROCEDURE SP_NuevaListaArticuloVenta(
@IdVenta INT,
@IdArticulo SMALLINT,
@Cantidad SMALLINT
)
AS
BEGIN
	INSERT INTO ListaArticuloVenta (IdVenta, IdArticulo, Cantidad)
	VALUES (@IdVenta, @IdArticulo, @Cantidad)
END