create procedure pa_consulta(
@consulta int
)
as
begin
select * from Producto where CodCat=@consulta;
end