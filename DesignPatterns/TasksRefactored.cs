using System;
using System.Collections.Generic;

namespace CodingSchool2017
{
    public class TasksRefactored
    {
        public void Run()
        {
            var methods = new Action<string>[]{
                GatherStats,
                DeriveFoo,
            };

            var customerGroups = new[]{
                "good_customers",
                "bad_customers",
                "average_customers",
            };

            foreach (var method in methods)
            {
                TryRecoverOnError(() =>
                {
                    foreach (var customerGroup in customerGroups)
                    {
                        method(customerGroup);
                    }
                });
            }
        }

        private void GatherStats(string customerGroup)
        {
            //gather stats for customer group
        }

        private void DeriveFoo(string customerGroup)
        {
            //derive foo for customer group
        }

        private void TryRecoverOnError(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                //log the exception
            }
        }
    }
}