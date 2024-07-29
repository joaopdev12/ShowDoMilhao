using ShowDoMilhao.Models;

namespace ShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new() {

           new Pergunta
            {
               Id = 1,
               Enunciado = "Qual é o nome dado ao estado da agua em forma de gelo?",
               Alternativas = new()
               {
                    new Alternativa {Correta = false, Descricao = "LÍQUIDO"},
                    new Alternativa {Correta = true, Descricao = "SÓLIDO"},
                    new Alternativa {Correta = false, Descricao = "GASOSO"},
                    new Alternativa {Correta = false, Descricao = "VAPOROSO"},
               }
            },

           new Pergunta
            {
               Id = 2,
               Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
               Alternativas = new()
               {
                    new Alternativa {Correta = false, Descricao = "RIO DE JANEIRO"},
                    new Alternativa {Correta = true, Descricao = "RIO GRANDE DO SUL"},
                    new Alternativa {Correta = false, Descricao = "SANTA CATARINA"},
                    new Alternativa {Correta = false, Descricao = "GOIÁS"},
               }
            },

           new Pergunta
            {
               Id = 3,
               Enunciado = "Qual era o apelido da cantora Elis Regina?",
               Alternativas = new()
               {
                    new Alternativa {Correta = false, Descricao = "GAUCHINHA"},
                    new Alternativa {Correta = true, Descricao = "PAULISTINHA"},
                    new Alternativa {Correta = false, Descricao = "PIMENTINHA"},
                    new Alternativa {Correta = false, Descricao = "ANDORINHA"},
               }
            },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
