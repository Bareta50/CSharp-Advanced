using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Enum;
namespace StaticClasses.Entities.Moddels;

public class Order : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public OrderStatus Status { get; set; }

    public Order(int id, string title, string description, OrderStatus status) : base(id)
    {
        Title = title;
        Description = description;
        Status = status;
    }

    public string GetInfo()
    {
        return $"{TextHelper.CapitalizeFirstLetter(Title)} - {Description}";
    }
}
