using SharpPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Dtos;

public record SaveOrderDto(List<Product> Products, Customer Customer, Address Address);

