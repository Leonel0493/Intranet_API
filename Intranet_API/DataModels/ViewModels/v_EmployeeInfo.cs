namespace Intranet_API.DataModels.ViewModels
{
    public class v_EmployeeInfo
    {
        public int idEmployee { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string thirdName { get; set; }
        public string firstSurname { get; set; }
        public string middleSurname { get; set; }
        public string marriedSurname { get; set; }
        public string addres { get; set; }
        public string Municipio { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string Unidad { get; set; }
        public string Direccion { get; set; }
        public string Cargo { get; set; }
        public bool? active { get; set; }
    }
}
