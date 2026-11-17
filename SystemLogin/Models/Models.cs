namespace SistemaDeLogin.Models;
 public class Usuario {
    public int id {get; set;}
    public string Username {get; set;} = string.Empty;
    public string SenhaHash {get;set;} = string.Empty;
}