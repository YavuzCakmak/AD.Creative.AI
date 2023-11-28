using AdCreative.Backend;

namespace AdCreative.Service
{
    public class DistributedIntegrationService
    {
        private static bool IsPutInProgress = false;

        public void PutItem(string content)
        {
            IsPutInProgress = true;
            try
            {
                UniqueContents.UniqueContent.Add(content);
            }
            finally
            {
                IsPutInProgress = false;
            }
        }

        public string GetItem()
        {
            if (IsPutInProgress)
            {
                return GetItem();
            }
            return UniqueContents.UniqueContent.FirstOrDefault();
        }
    }

}
