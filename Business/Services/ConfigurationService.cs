using Domain.Entities;
using Repository.DataAcess.SerialObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ConfigurationService
    {
        private readonly ConfigData _context;

        public ConfigurationService()
        {
            _context = new ConfigData();
        }

        public Configuration Read()
        {
            return _context.ReadData();
        }

        public void Set(Configuration configuration)
        {
            if(configuration != null)
            {
                _context.SetData(configuration);
            }
            else
            {
                throw new NullReferenceException("A configuração não pode ser nula");
            }
        }
    }
}
