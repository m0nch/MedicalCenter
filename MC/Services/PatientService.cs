using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class PatientService : IPatientService
    {
        private readonly PatientRepository _patientRepository;

        public PatientService(PatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public void Add(Patient model)
        {
            _patientRepository.Add(model);
        }

        public Patient Get(Guid id)
        {
            return _patientRepository.Get(id);
        }

        public List<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }

        public void Remove(Patient model)
        {
            _patientRepository.Remove(model);
        }

        public void Update(Patient model)
        {
            var oldPatient = _patientRepository.Get(model._id);
            var index = _patientRepository.IndexOf(oldPatient);
            _patientRepository.Update(model, index);
        }

    }
}
