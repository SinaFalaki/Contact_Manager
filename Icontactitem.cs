using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact
{
    public interface Icontactitem

    {
        void add(Contact contact);
        void remove(string number);
        void Update(string number, Contact contact);
        bool searchNumber(string number);
        bool searchName(string name);

    }
}
