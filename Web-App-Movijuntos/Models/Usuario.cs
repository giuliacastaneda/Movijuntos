using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Web_App_Movijuntos.Models;

[Index(nameof(Email), IsUnique = true)]
[Index(nameof(Apelido), IsUnique = true)]
public class Usuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }

    [Required(ErrorMessage = "Obrigatório informar E-mail.")]
    public string Email { get; private set; } = "";

    [Required(ErrorMessage = "Obrigatório informar apelido.")]
    public string Apelido { get; private set; } = "";

    [Required(ErrorMessage = "Obrigatório informar  o nome.")]
    public string Nome { get; private set; } = "";

    [Required(ErrorMessage = "Obrigatório informar data de nascimento.")]
    public DateOnly Nascimento { get; private set; }

    [Required(ErrorMessage = "Obrigatório informar senha.")]
    public string Senha { get; private set; } = "";

    [Required]
    public int DVerificador { get; private set; } = new Random().Next(1000, 10000);

    public Usuario(string nome, string apelido, string email, DateOnly nascimento, string senha)
    {
        AlterarNome(nome);
        AlterarApelido(apelido);
        AlterarEmail(email);
        AlterarNascimento(nascimento);
        AlterarSenha(senha, 0);
    }

    public void AtualizarDVerificador()
    {
        DVerificador = new Random().Next(1000, 10000);
    }

    public void AlterarNome(string novoNome)
    {
        string regex = @"^[A-Za-zÀ-ÖØ-öø-ÿ ]{2,}$";
        if (!Regex.IsMatch(novoNome.Trim(), regex))
            throw new ArgumentException("Nome inválido!");

        Nome = novoNome;
    }

    public void AlterarApelido(string novoApelido)
    {
        if (novoApelido.Trim().Contains(" "))
            throw new ArgumentException("Apelido não pode conter espaços.");

        Apelido = novoApelido;
    }

    public void AlterarSenha(string novaSenha, int ativarHash = 1)
    {
        if (novaSenha.Length < 6)
            throw new ArgumentException("Senha deve ter no mínimo 6 caracteres.");

        if (ativarHash == 1)
            Senha = BCrypt.Net.BCrypt.HashPassword(novaSenha);
        else
            Senha = novaSenha;
    }

    public void AlterarEmail(string novoEmail)
    {
        if (!novoEmail.Contains("@"))
            throw new ArgumentException("Email inválido.");
        if (!novoEmail.Contains("."))
            throw new ArgumentException("Email inválido");
        if (novoEmail.Contains(" "))
            throw new ArgumentException("Email inválido");

        Email = novoEmail;
    }

    public void AlterarNascimento(DateOnly novaData)
    {
        if (novaData == DateOnly.MinValue)
            throw new Exception("A data de nascimento é obrigatória.");

        if (novaData > DateOnly.FromDateTime(DateTime.Now))
            throw new Exception("A data de nascimento não pode ser no futuro.");

        Nascimento = novaData;
    }

}