using Biblioteca.Application.DTOs.Emprestimo;

namespace Biblioteca.Application.Contracts.Services;

public interface IEmprestimoService
{
    Task<EmprestimoDto?> RealizarEmprestimo(RealizarEmprestimoDto dto);
    Task<EmprestimoDto?> RealizarRenovacao(int id, RealizarRenovacaoOuEntregaDto dto);
    Task<EmprestimoDto?> RealizarEntrega(int id, RealizarRenovacaoOuEntregaDto dto);
    Task<EmprestimoDto?> ObterPorId(int id);
    Task<List<EmprestimoDto>> ObterTodos();
    Task<List<EmprestimoDto>?> ObterHistoricoDeEmprestimoDeUmUsuario(int usuarioId);
    Task<List<EmprestimoDto>?> ObterHistoricoDeEmprestimoDeUmUsuario(string usuarioMatricula);
    Task<List<EmprestimoDto>?> ObterHistoricoDeEmprestimoDeUmLivro(int livroId);
}