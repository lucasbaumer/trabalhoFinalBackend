﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFinal.Core.Entities
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set;}
        [Required]
        [MaxLength(15)]
        public string Cpf { get; set;}
        [Required]
        [MaxLength(50)]
        public string Email { get; set;}
        [Required]
        [MaxLength(16)]
        public string Telefone { get; set;}
        
    }
}
