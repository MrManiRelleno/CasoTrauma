using System;
using System.ComponentModel.DataAnnotations;

public class EmergenciaModel
{
    public int NumeroVictimas { get; set; }

    [Required]
    public string Descripcion { get; set; } ="None";

    public DateTime Fecha { get; set; }

}
