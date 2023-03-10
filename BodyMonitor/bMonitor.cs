namespace BodyMonitor;

public class bMonitor
{
    private double temperature;
    private int heartRate;
    private int bloodPressure;
    private int age;

    
    public bMonitor(double temperature, int heartRate, int bloodPressure, int age)
    {
        this.temperature = temperature;
        this.heartRate = heartRate;
        this.bloodPressure = bloodPressure;
        this.age = age;
    }

    public void CheckBodyState()
    {
        CheckTemperature();
        CheckHeartRate();
        CheckBloodPressure();
    }

    
    private void CheckTemperature()
    {
        if (temperature < 36.0 || temperature > 37.5)
        {
            Warning temperatureWarning = new Warning("❗️Temperature is out of normal range.", false, 1);
            Console.WriteLine("WARNING: " + temperatureWarning.message);
            DBC.LogWarning(temperatureWarning);
            

        }
        else
        {
            Warning temperatureWarning = new Warning("Temperature is normal.", true, 0);
            Console.WriteLine("WARNING: " + temperatureWarning.message);
            DBC.LogWarning(temperatureWarning);
        }
    }

    private void CheckHeartRate()
    {
        if (age <= 7)
        {
            if (heartRate < 70 || heartRate > 110)
            {
                Warning heartRateWarning = new Warning("❗️Heart rate is out of normal range for children.", false, 2);
                Console.WriteLine("WARNING: " + heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
            else
            {
                Warning heartRateWarning = new Warning("Heart rate is normal for children.", true, 0);
                Console.WriteLine(heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
        }
        else if (age >= 8 && age <= 17)
        {
            if (heartRate < 60 || heartRate > 100)
            {
                Warning heartRateWarning = new Warning("❗️Heart rate is out of normal range for teenagers.", false, 2);
                Console.WriteLine("WARNING: " + heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
            else
            {
                Warning heartRateWarning = new Warning("Heart rate is normal for teenagers.", true, 0);
                Console.WriteLine(heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
        }
        else if (age >= 18 && age <= 65)
        {
            if (heartRate < 60 || heartRate > 100)
            {
                Warning heartRateWarning = new Warning("❗️Heart rate is out of normal range for adults.", false, 1);
                Console.WriteLine("WARNING: " + heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
            else
            {
                Warning heartRateWarning = new Warning("Heart rate is normal for adults.", true, 0);
                Console.WriteLine(heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
        }
        else
        {
            if (heartRate < 50 || heartRate > 90)
            {
                Warning heartRateWarning = new Warning("❗️Heart rate is out of normal range for seniors.", false, 2);
                Console.WriteLine("WARNING: " + heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
            else
            {
                Warning heartRateWarning = new Warning("Heart rate is normal for seniors.", true, 0);
                Console.WriteLine(heartRateWarning.message);
                // Do something else with the heartRateWarning object, like logging it or notifying the user.
                DBC.LogWarning(heartRateWarning);
            }
        }
    }

    private void CheckBloodPressure()
    {
        if (bloodPressure < 90 || bloodPressure > 120)
        {
            Warning bloodPressureWarning = new Warning("❗️Blood pressure is out of normal range.", false, 1);
            Console.WriteLine("WARNING: " + bloodPressureWarning.message);
            // Do something else with the bloodPressureWarning object, like logging it or notifying the user.
            DBC.LogWarning(bloodPressureWarning);
        }
        else
        {
            Warning bloodPressureWarning = new Warning("Blood pressure is normal.", true, 0);
            Console.WriteLine(bloodPressureWarning.message);
            // Do something else with the bloodPressureWarning object, like logging it or notifying the user.
            DBC.LogWarning(bloodPressureWarning);
        }
    }
}
