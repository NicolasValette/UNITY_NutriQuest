using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NutriQuest.Interfaces
{
    public interface ICollectible
    {
        public void OnCollect(GameObject collectorObject);
    }
}
