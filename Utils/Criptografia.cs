using api_filmes_senai.Utilss;
using BCrypt.Net;
namespace api_filmes_senai.Utilss;

public static class Criptografia
{
    public static string GerarHash(string senha)
    {
        return BCrypt.Net.BCrypt.HashPassword(senha);
    }

    public static bool ComprarHash(string senhaInformada, string senhaBanco)
    {
        return BCrypt.Net.BCrypt.Verify(senhaInformada, senhaBanco);
    }
}
