using System.Collections.ObjectModel;

namespace MeuDinheiro.Models
{
    public class TransactionModel
    {
        public TransactionModel()
        {

        }

        public TransactionModel(string titulo, decimal preco, string tipo, string categoria)
        {
            Id = Id + 1;
            Titulo = titulo;
            Preco = preco;
            Tipo = tipo;
            Categoria = categoria;
            Data = DateTime.UtcNow.Date;
        }

        public int Id {  get; set; } = 0;
        public string Titulo { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public DateTime Data { get; set; }

        public ObservableCollection<TransactionModel> TransactionList { get; set; } = new ObservableCollection<TransactionModel>();

        public void AddTransaction(TransactionModel transaction)
        {
            TransactionList.Add(transaction);
        }
    }
}
