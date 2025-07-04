using Playground;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundTeste
{
    public class CalculadoraFinanceiraTeste
    {
        private CalculadoraFinanceira _calculadoraFinanceira;

        public CalculadoraFinanceiraTeste()
        {
            _calculadoraFinanceira = new CalculadoraFinanceira();
        }

        [Fact]
        public void CalculadoraDeJurosTeste()
        {
            //arrange
            decimal capitalInicial = 1000;
            decimal taxaJurosMensal = 0.01m; 
            int periodoMeses = 12; 

            //act
            decimal resultado = _calculadoraFinanceira.CalcularJurosSimples(capitalInicial, taxaJurosMensal, periodoMeses);

            //assert

            Assert.Equal(1120.00m, resultado);

        }
        [Fact]
        public void CalculadoraDeJurosSimplesTeste()
        {
            //arrange
            decimal capitalInicial = 0;
            decimal taxaJurosMensal = 0.01m; 
            int periodoMeses = 12; 

            //act
            decimal resultado = _calculadoraFinanceira.CalcularJurosSimples(capitalInicial, taxaJurosMensal, periodoMeses);

            //assert

            Assert.Equal(0.00m, resultado);

        }
        public void CalcularJurosnegativos()
        {

        }
    }
}