using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TireTak.Class;
using System.Windows.Forms;

namespace TireTak.Class
{

    class TiresClass
    {
        private int _tire_id;
        private string _tire_brand;
        private string _tire_model;
        private string _tire_size;
        private string _tire_db;
        private string _tire_built_price;
        private string _tire_sale_price;
        private string _tire_r;

        #region Properties
        public int tire_id
        {
            get
            {
                return _tire_id;
            }

            set
            {
                _tire_id = value;
            }
        }

        public string tire_brand
        {
            get
            {
                return _tire_brand;
            }

            set
            {
                _tire_brand = value;
            }
        }

        public string tire_model
        {
            get
            {
                return _tire_model;
            }

            set
            {
                _tire_model = value;
            }
        }

        public string tire_size
        {
            get
            {
                return _tire_size;
            }

            set
            {
                _tire_size = value;
            }
        }
        public string tire_db
        {
            get
            {
                return _tire_db;
            }

            set
            {
                _tire_db = value;
            }
        }
        public string tire_built_price
        {
            get
            {
                return _tire_built_price;
            }

            set
            {
                _tire_built_price = value;
            }
        }
        public string tire_sale_price
        {
            get
            {
                return _tire_sale_price;
            }

            set
            {
                _tire_sale_price = value;
            }
        }
        public string tire_r
        {
            get
            {
                return _tire_r;
            }

            set
            {
                _tire_r = value;
            }
        }

        #endregion

    }
    }


