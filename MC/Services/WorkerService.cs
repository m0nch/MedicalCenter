using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class WorkerService : StaffService, IWorkerService, IStaffService
    {
        private readonly WorkerRepository _workerRepository;

        public WorkerService(WorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }
        public void Add(Worker model)
        {
            _workerRepository.Add(model);
        }

        public new Worker Get(Guid id)
        {
            return _workerRepository.Get(id);
        }

        public new List<Staff> GetAll()
        {
            return _workerRepository.GetAll();
        }

        public void Remove(Worker model)
        {
            _workerRepository.Remove(model);
        }

        public void Update(Worker model)
        {
            var oldWorker = _workerRepository.Get(model._id);
            var index = _workerRepository.IndexOf(oldWorker);
            _workerRepository.Update(model, index);
        }


    }
}
