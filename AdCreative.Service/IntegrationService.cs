﻿using AdCreative.Backend;

namespace AdCreative.Service
{
    public class IntegrationService
    {
        public IntegrationService()
        {

        }

        public string ProcessItem(string itemContent)
        {
            lock (UniqueContents.UniqueContent)
            {
                if (UniqueContents.UniqueContent.Contains(itemContent))
                {
                    return "Item already processed";
                }

                Thread.Sleep(2000);

                UniqueContents.UniqueContent.Add(itemContent);

                return $"Item processed successfully: {itemContent}";
            }
        }
    }
}
