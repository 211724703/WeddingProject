using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Service
{
    public interface ISadottypeService
    {
        void AddSadottype(CSadottype Sad);
        void DeleteSadottype(CSadottype Sad);
        void UpdateSadottype(CSadottype Sad);
        List<CSadottype> GetAllSadottype();
    }
}
