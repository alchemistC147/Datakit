using System;
using AppTypes;
using Microsoft.Extensions.Configuration;

namespace dataOperations
{
    public class checkData
    {
        private getData getData = new getData();
        public bool checkCredentials(User usuario)
        {

            string res = getData.getIdUser(usuario.userName );
            if (res != null && res != String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}