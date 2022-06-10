namespace CrudMvc.Models
{
    public class Curriculum
    {
        public int Id { get; set; }

        public string Nombre { get; set; }


        /*[DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }*/

        public string Apellido { get; set; }

        public string Genero { get; set; }

        public decimal Edad { get; set; }
    }
}

