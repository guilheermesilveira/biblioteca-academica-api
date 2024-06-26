﻿using AutoMapper;
using Biblioteca.Domain.Entities;

namespace Biblioteca.Application.Configuration;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        #region Auth

        CreateMap<DTOs.Auth.LoginDto, Administrador>().ReverseMap();

        #endregion

        #region Usuario

        CreateMap<DTOs.Usuario.UsuarioDto, Usuario>().ReverseMap();
        CreateMap<DTOs.Usuario.AdicionarUsuarioDto, Usuario>().ReverseMap();
        CreateMap<DTOs.Usuario.AtualizarUsuarioDto, Usuario>().ReverseMap();

        #endregion

        #region Livro

        CreateMap<DTOs.Livro.LivroDto, Livro>().ReverseMap();
        CreateMap<DTOs.Livro.AdicionarLivroDto, Livro>().ReverseMap();
        CreateMap<DTOs.Livro.AtualizarLivroDto, Livro>().ReverseMap();

        #endregion

        #region Emprestimo

        CreateMap<DTOs.Emprestimo.EmprestimoDto, Emprestimo>().ReverseMap();
        CreateMap<DTOs.Emprestimo.RealizarEmprestimoDto, Emprestimo>().ReverseMap();

        #endregion
    }
}