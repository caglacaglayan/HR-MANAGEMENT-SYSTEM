﻿using EntityLayer.Concrete.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPersonService
    {
        List<Person> GetList();
        void AddPerson(Person person);
        void DeletePerson(Person person);
        void UpdatePerson(Person person);
        Person GetByID(int id);
    }
}
