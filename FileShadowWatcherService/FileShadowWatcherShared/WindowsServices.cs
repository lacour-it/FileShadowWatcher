using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace FileShadowWatcherShared
{
    public static class WindowsServices
    {
        public static bool IsServiceInstalled(string serviceName)
        {
            // get list of Windows services
            ServiceController[] services = ServiceController.GetServices();

            // try to find service name
            foreach (ServiceController service in services)
            {
                if (service.ServiceName == serviceName)
                    return true;
            }
            return false;
        }

        public static bool IsServiceRunning(string serviceName)
        {
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    if (service.Status== ServiceControllerStatus.Running)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    slLogger.WriteLogLine("Service-information could not be retrieved");
                    return false;
                }
            }
        }

        public static bool IsServicePaused(string serviceName)
        {
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    if (service.Status == ServiceControllerStatus.Paused)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    slLogger.WriteLogLine("Service-information could not be retrieved");
                    return false;
                }
            }
        }

        public static string GetServiceStatus(string serviceName)
        {
            string result = null;
            using (ServiceController service = new ServiceController(serviceName))
            {
                try
                {
                    result = service.Status.ToString();
                }
                catch
                {
                    slLogger.WriteLogLine("Service-information could not be retrieved");
                    return null;
                }
            }
            return result;
        }

        public static bool StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                return true;
            }
            catch
            {
                slLogger.WriteLogLine("Service could not be started");
                return false;
            }
        }

        public static bool StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                return true;
            }
            catch
            {
                slLogger.WriteLogLine("Service could not be stopped");
                return false;
            }
        }

        public static bool ContinueService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Continue();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                return true;
            }
            catch
            {
                slLogger.WriteLogLine("Service could not be continued");
                return false;
            }
        }

        public static bool PauseService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Pause();
                service.WaitForStatus(ServiceControllerStatus.Paused, timeout);
                return true;
            }
            catch
            {
                slLogger.WriteLogLine("Service could not be paused");
                return false;
            }

        }
               
        public static bool RestartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                return true;
            }
            catch
            {
                slLogger.WriteLogLine("Service could not be restarted");
                return false;
            }
        }
    }
}
