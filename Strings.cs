using System.Text;

namespace Strings;

public class Strings
{
    static void Main(string[] args)
    {
        /*var id = Guid.NewGuid();
        id = new Guid("e58e496e-38b7-4af6-8985-ef877c659445");
        Console.WriteLine(id.ToString().Substring(0,8)); */
        
        var price = 10.2;
        var texto = "O preço do produto é " + price + " apenas na promoção";
        
        //Console.WriteLine(texto);
        
        var texto2 = string.Format("O preço do produto é {0} apenas na promoção", price);
        
        //Console.WriteLine(texto2);
        
        var texto3 = $@"O preço do produto
        é {price} apenas na promoção";
        
        /* O $serve como método de concatenação de string. O @ serve para ignorar caracteres especiais e permitir que
         a string saia de uma linha, ocupando mais linhas*/
        
        //Console.WriteLine(texto3);
        
        /* Comparação de texto
         */
        
        //var texto4 = "Testando";
        var texto5 = "Este texto é um teste";
        
        /*
        Console.WriteLine(texto4.CompareTo("Testando"));
        Console.WriteLine(texto4.CompareTo("testando"));
        Console.WriteLine((texto5.Contains("teste")));
        Console.WriteLine((texto5.Contains("Teste", StringComparison.OrdinalIgnoreCase))); //ignora o case sensitive
        */
        
        /*
        Console.WriteLine((texto5.StartsWith("Este")));
        Console.WriteLine((texto5.StartsWith("este")));
        Console.WriteLine(texto5.EndsWith("teste"));
        Console.WriteLine(texto5.EndsWith("Teste"));
        */
        
        /*
        Console.WriteLine(texto5.Equals("Este texto é um teste"));
        Console.WriteLine(texto5.Equals("este texto é um teste"));
        */
        
        
        //Posição de um item num array/lista
        
        /*
        Console.WriteLine(texto5.IndexOf("é"));
        Console.WriteLine(texto5.IndexOf("um"));
        Console.WriteLine(texto5.LastIndexOf("s"));
        */
        
        //Converter string para minusculo ou maiusculo

        //Console.WriteLine(texto5.ToUpper());
        
        //Inserir e remover elementos
        
        /*
        Console.WriteLine(texto5.Insert(5, "AQUI "));
        Console.WriteLine(texto5.Remove(5, 0));
        */
        
        //Quantidade de caracteres que uma string tem
        //Console.WriteLine(texto5.Length);
        
        
        //Usando o replatce, Case sensitive
        
        /*
        Console.WriteLine(texto5.Replace("Este","isto"));
        Console.WriteLine(texto5.Replace("e","X"));
        */

        //Usando o Split
        
        var divisao = texto5.Split(" ");
        
        /*
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);
        Console.WriteLine(divisao[4]);
        */

        //Usando subtrings
        
        var resultado = texto5.Substring(5, 5);
        //Console.WriteLine(resultado);

        
        //LImpando espaços no começo e no fim de um a string
        var texto6 = " Este texto é um teste ";
        //Console.WriteLine(texto6.Trim());
        
        //Usando o StringBuilder
        var stgbuilder = new StringBuilder();
        stgbuilder.Append("Este texto é um teste");
        stgbuilder.Append(" E este também");
        
        stgbuilder.ToString();
        
        //Console.WriteLine(stgbuilder);
    }
}
