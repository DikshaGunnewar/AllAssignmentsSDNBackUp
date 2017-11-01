using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Trirand.Web.Mvc;

namespace Grid.Models
{
    public class Order11
    {
        public JQGrid OrderGrid { get; set; }
        public Order11()
        {
           public JQGrid OrdersGrid { get; set; }

        public OrdersJqGridModel()
        {
            OrdersGrid = new JQGrid
            {
                Columns = new List<JQGridColumn>()
                {
                    new JQGridColumn
                    {
                        // Always set PrimaryKey for Add,Edit,Delete operations
                        // If not set, the first column will be assumed as primary key
                        DataField = "OrderID",
                        PrimaryKey = true,
                        Editable = false,
                        Width = 50,
                        DataType = typeof(int)
                    },
                    new JQGridColumn
                    {
                        DataField = "CustomerID",
                        Editable = true,
                        Width = 100,
                        DataType = typeof(string),
                        //ShowColumnMenu = true,
                    },
                    new JQGridColumn
                    {
                        DataField = "OrderDate",
                        Editable = true,
                        Width = 100,
                        DataFormatString = "{0:yyyy/MM/dd}",
                        DataType = typeof(DateTime),
                        //ShowColumnMenu = true,
                    },
                    new JQGridColumn
                    {
                        DataField = "Freight",
                        Editable = true,
                        Width = 75,
                        DataType = typeof(double),
                       // ShowColumnMenu = true
                    },
                    new JQGridColumn
                    {
                        DataField = "ShipName",
                        Editable =  true,
                        Width = 150,
                        DataType = typeof(string)
                    }
                },

                Width = Unit.Pixel(640),
                Height = Unit.Pixel(250),

                ToolBarSettings = new ToolBarSettings
                {
                    ShowRefreshButton = true
                }
            };
        }
        }
    }
//}