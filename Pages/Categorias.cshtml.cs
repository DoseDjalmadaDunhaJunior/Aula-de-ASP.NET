using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages;

public class CategoriasModel : PageModel
{
    public List<Categoria> Categorias { get; set; } = new();
    public async Task OnGet()
    {
        await Task.Delay(1000);
        for(int i = 0; i < 20;i++){
            Categorias.Add(new Categoria(i, $"Categoria {i}", $"Descricao {i}"));
        }
    }

    public void OnPost()
    {
    }

}

public record  Categoria(

    int Id,
    string Nome,
    string Descricao
);