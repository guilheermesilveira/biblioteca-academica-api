﻿namespace Biblioteca.Domain.Entities;

public class Livro : Entity
{
    public string Titulo { get; set; } = null!;
    public string Autor { get; set; } = null!;
    public string Edicao { get; set; } = null!;
    public string Editora { get; set; } = null!;
    public int AnoPublicacao { get; set; }
    public int QuantidadeExemplares { get; set; }
    public string? CaminhoCapa { get; set; }
}