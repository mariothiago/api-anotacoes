namespace anotacoesapi.Infrastructure.Repository.Scripts
{
    public class AnotacoesScript
    {
        internal static string GetAll = $@"SELECT * FROM anotacoes";

        internal static string GetById = $@"SELECT id, titulo, texto FROM anotacoes WHERE ID = @id";

        internal static string Create = $@"INSERT INTO anotacoes (
                                            titulo, 
                                            texto) 
                                           values(
                                            @titulo, 
                                            @texto)";

        internal static string Update = $@"UPDATE anotacoes SET titulo = @titulo,
                                         texto = @texto 
                                        WHERE ID = @id";

        internal static string Delete = $@"DELETE FROM anotacoes WHERE ID = @id";
    }
}
