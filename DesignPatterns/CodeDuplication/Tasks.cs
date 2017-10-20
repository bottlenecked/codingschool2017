using System;

namespace CodingSchool2017
{
    public class Tasks
    {

        public void Run()
        {
            TryRecoverOnError(() =>
            {
                GatherStats("good_customers");
                GatherStats("bad_customers");
                GatherStats("average_customers");
            });

            TryRecoverOnError(() =>
            {
                DeriveFoo("good_customer");
                DeriveFoo("bad_customers");
                DeriveFoo("average_customers");
            });
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