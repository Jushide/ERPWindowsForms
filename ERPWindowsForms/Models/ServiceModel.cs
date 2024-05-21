using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ERPWindowsForms.Models
{
    internal class ServiceTickets 
    {
        List<ServiceModel> ServiceTicketsList = new List<ServiceModel>();

        public void AddServiceTickets(ServiceModel serviceModel)
        {
            ServiceTicketsList.Add(serviceModel);
        }

        public void EditServiceTickets(Guid guid, string serviceStatus, string desc)
        {
            var serviceTicket = ServiceTicketsList.Find(st => st.Id == guid);
            serviceTicket.Status = serviceStatus;
            serviceTicket.Description = desc;
        }

        public List<ServiceModel> GetAllServiceTickets()
        {
            return ServiceTicketsList;
        }

        public ServiceModel GetServiceTicket(Guid guid)
        {
            return ServiceTicketsList.Find(st => st.Id == guid);
        }
    }

    internal enum ServiceStatus
    {
        PENDING = 0,
        IN_REALIZATION = 1,
        TO_VERIFY = 2,
        DONE = 3,
    }

    internal class ServiceModel
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        private ServiceModel()
        {
        }

        public static ServiceModel Create(
            string serialNumber,
            string name,
            string description)
        {
            return new ServiceModel
            {
                Id = Guid.NewGuid(),
                SerialNumber = serialNumber,
                Name = name,
                Description = description,
                Status = "PENDING"
            };
        }

        public void Update(
            string status,
            string description = null
            )
        {
            Description = description;
            Status = status;
        }
    }
}
