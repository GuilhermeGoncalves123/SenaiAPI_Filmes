using api_filmes_senai.Utilss;
namespace api_filmes_senai.Utilss;

public static class Criptografia
{
    public static string GerarHash(string senha)
    {
        return BCrypt.Net.BCrypt.Hashpassword(senha);
    }

    public static bool ComprarHash(string senhaInformada, string senhaBanco)
    {
        return BCrypt.Net>BCrypt.Verify(senhaInformada, senhaBanco);
    }
}
