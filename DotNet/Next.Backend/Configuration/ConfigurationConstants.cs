namespace Next.Backend.Configuration;

/// <summary>
/// Contains contants related to the configuration.
/// </summary>
public sealed class ConfigurationConstants
{
    /// <summary>
    /// Gets the default configuration path when Next is running inside a container.
    /// </summary>
    public static readonly string DefaultDockerConfigurationPath = "/var/next";

    /// <summary>
    /// Gets the Next docker configuration environment key.
    /// </summary>
    public static readonly string DockerConfigurationKey = "NEXT_CONFIGURATION";

    /// <summary>
    /// Prevents from creating a <see cref="ConfigurationConstants"/> instance from outside.
    /// </summary>
    private ConfigurationConstants()
    {
    }
}