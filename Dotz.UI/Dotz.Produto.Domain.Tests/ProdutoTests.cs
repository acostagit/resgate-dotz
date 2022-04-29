using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dotz.Produto.Domain.ProdutoTests
{
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod]
        public void Produto_AdicionarProduto_NovoProduto_DeveSalvarNoBanco()
        {
            //Arrange //Produto(1, "Produto1", 45.00, DateTime.Now,135, 500);
            var produto = new Produto("Produto1", 45, DateTime.Now, 135, 500);

            //Act
            produto.AdicionarProduto(produto);

            //Assert
            Assert.Equals(500, produto.QuantidadeEstoque);
        }
       
    }
}
