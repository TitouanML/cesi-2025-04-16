using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Exercice01.Interfaces
{
    public interface IMachine
    {
        void Print();
        void Scan();
        void Fax();
    }

    public interface IPrinter
    {
        void Print();
    }

    public interface IScaner
    {
        void Scan();
    }

    public interface IFaxer
    {
        void Fax();
    }

}
