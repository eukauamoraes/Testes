using RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testes
{
    public class ValidadorCPFTests
    {
        private ValidadorCPF _validador;
        public ValidadorCPFTests()
        {
            _validador = new ValidadorCPF();
        }

        [Fact]

        public void DeveRetornarTrueParaCpfValido()
        {



            // Arrange
            string cpfValido = "47472168807";
            //int cpfinvalido  = "234236423643;

            // Act
            bool resultado = _validador.Validar(cpfValido);

            // Assert
            Assert.True(resultado);



        }

        [Fact]

        public void DeveRetornarFalseParaCpfinvalidado()
        {



            // Arrange
            //string cpfValido = "11144477735";
            string cpfinvalido = "234236423643";

            // Act
            bool resultado = _validador.Validar(cpfinvalido);

            // Assert
            Assert.False(resultado);

        }
        public void DeveRetornarTrueParaCpfigual()
        {



            // Arrange
            string cpfValido = "11111111111";
       

            // Act
            bool resultado = _validador.Validar(cpfValido);

            // Assert
            Assert.True(resultado);



        }
        public void DeveRetornarFalseParaCpfIgual()
        {



            // Arrange
           
            string cpfinvalido = "234236423643";

            // Act
            bool resultado = _validador.Validar(cpfinvalido);

            // Assert
            Assert.False(resultado);
        }
    }
}
    

