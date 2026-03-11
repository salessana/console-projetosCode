class Produto
{
    private static int contadorid = 1;

    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Categoria { get; set; }
    public decimal Preco { get; set; }

    private List<Produto> produtos = new List<Produto>();

    public void CadastrarProduto(Produto produtoParaCadastrar)
    {
        produtoParaCadastrar.Id = contadorid++;
        produtos.Add(produtoParaCadastrar);

        string precoFormatado = produtoParaCadastrar.Preco.ToString("F2");
        Console.WriteLine($"Produto cadastrado com sucesso! Id: {produtoParaCadastrar.Id} | Nome: {produtoParaCadastrar.Nome} | Preço: {precoFormatado} ");
    }


    public void RemoverProduto(int Id)
    {
        Produto? prod = produtos.Find(p => p.Id == Id);
        if (prod != null)
        {
            produtos.Remove(prod);
            Console.WriteLine($"Produto foi removido com sucesso! \n ");

        }
        else
        {
            Console.WriteLine($"produto nao \n");

        }
    }


    public void ListarProdutos()
    {
        console.WriteLine($"=== Lista de Produtos === ");
        if (produto.Count == 0)
        {
            console.WriteLine($"Nenhum produto cadastrado. \n");
            return;

        }
        foreach (var item in produtos)
        {
            console.WriteLine($"Id: {item.Id} | Nome: {item.Categoria} | Preço: {precoFormatado}");
        }
        
    }

public bool ListaVazia(){
    return produtos.Count == 0; //retorna true ou false
}

}