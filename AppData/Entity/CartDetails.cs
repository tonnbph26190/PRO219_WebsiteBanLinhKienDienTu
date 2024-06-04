﻿using AppData.Entity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppData.Models
{
    public class CartDetails:BaseEntity
    {
        public Guid Id { get; set; }    
        
        public Guid? IdUser { get; set; }
        public string IdVirtualItem { get; set; }   
        public int Status { get; set; }
        public string? MetadataJson
        {
            get
            {
                if (Metadata!=null)
                {
                    return JsonConvert.SerializeObject(Metadata);
                }
                return null;
            }
            set
            {
                try
                {
                    Metadata= JsonConvert.DeserializeObject<List<MetadataEntity>>(value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        public string? Decription { get; set; }
        [NotMapped]
        public List<MetadataEntity>? Metadata { get; set; }

        public virtual VirtualItem  VirtualItem { get; set; }
        public virtual Cart Carts { get; set; }
    }
}
