namespace Softlr;

[SuppressMessage(SONARQUBE, S2339)]
public static partial class Suppress
{
    public const string CA1000 = "CA1000:Do not declare static members on generic types";
    public const string CA1001 = "CA1001:Types that own disposable fields should be disposable";
    public const string CA1002 = "CA1002:Do not expose generic lists";
    public const string CA1003 = "CA1003:Use generic event handler instances";
    public const string CA1005 = "CA1005:Avoid excessive parameters on generic types";
    public const string CA1008 = "CA1008:Enums should have zero value";
    public const string CA1010 = "CA1010:Collections should implement generic interface";
    public const string CA1012 = "CA1012:Abstract types should not have constructors";
    public const string CA1014 = "CA1014:Mark assemblies with CLSCompliantAttribute";
    public const string CA1016 = "CA1016:Mark assemblies with AssemblyVersionAttribute";
    public const string CA1017 = "CA1017:Mark assemblies with ComVisibleAttribute";
    public const string CA1018 = "CA1018:Mark attributes with AttributeUsageAttribute";
    public const string CA1019 = "CA1019:Define accessors for attribute arguments";
    public const string CA1021 = "CA1021:Avoid out parameters";
    public const string CA1024 = "CA1024:Use properties where appropriate";
    public const string CA1027 = "CA1027:Mark enums with FlagsAttribute";
    public const string CA1028 = "CA1028:Enum storage should be Int32";
    public const string CA1030 = "CA1030:Use events where appropriate";
    public const string CA1031 = "CA1031:Do not catch general exception types";
    public const string CA1032 = "CA1032:Implement standard exception constructors";
    public const string CA1033 = "CA1033:Interface methods should be callable by child types";
    public const string CA1034 = "CA1034:Nested types should not be visible";
    public const string CA1036 = "CA1036:Override methods on comparable types";
    public const string CA1040 = "CA1040:Avoid empty interfaces";
    public const string CA1041 = "CA1041:Provide ObsoleteAttribute message";
    public const string CA1043 = "CA1043:Use integral or string argument for indexers";
    public const string CA1044 = "CA1044:Properties should not be write only";
    public const string CA1045 = "CA1045:Do not pass types by reference";
    public const string CA1046 = "CA1046:Do not overload operator equals on reference types";
    public const string CA1047 = "CA1047:Do not declare protected members in sealed types";
    public const string CA1050 = "CA1050:Declare types in namespaces";
    public const string CA1051 = "CA1051:Do not declare visible instance fields";
    public const string CA1052 = "CA1052:Static holder types should be sealed";
    public const string CA1053 = "CA1053:Static holder types should not have constructors";
    public const string CA1054 = "CA1054:URI parameters should not be strings";
    public const string CA1055 = "CA1055:URI return values should not be strings";
    public const string CA1056 = "CA1056:URI properties should not be strings";
    public const string CA1058 = "CA1058:Types should not extend certain base types";
    public const string CA1060 = "CA1060:Move P/Invokes to NativeMethods class";
    public const string CA1061 = "CA1061:Do not hide base class methods";
    public const string CA1062 = "CA1062:Validate arguments of public methods";
    public const string CA1063 = "CA1063:Implement IDisposable correctly";
    public const string CA1064 = "CA1064:Exceptions should be public";
    public const string CA1065 = "CA1065:Do not raise exceptions in unexpected locations";
    public const string CA1066 = "CA1066:Implement IEquatable when overriding Equals";
    public const string CA1067 = "CA1067:Override Equals when implementing IEquatable";
    public const string CA1068 = "CA1068:CancellationToken parameters must come last";
    public const string CA1069 = "CA1069:Enums should not have duplicate values";
    public const string CA1070 = "CA1070:Do not declare event fields as virtual";
    public const string CA1200 = "CA1200:Avoid using cref tags with a prefix";
    public const string CA1303 = "CA1303:Do not pass literals as localized parameters";
    public const string CA1304 = "CA1304:Specify CultureInfo";
    public const string CA1305 = "CA1305:Specify IFormatProvider";
    public const string CA1307 = "CA1307:Specify StringComparison for clarity";
    public const string CA1308 = "CA1308:Normalize strings to uppercase";
    public const string CA1309 = "CA1309:Use ordinal StringComparison";
    public const string CA1310 = "CA1310:Specify StringComparison for correctness";
    public const string CA1401 = "CA1401:P/Invokes should not be visible";
    public const string CA1416 = "CA1416:Validate platform compatibility";
    public const string CA1417 = "CA1417:Do not use OutAttribute on string parameters for P/Invokes";
    public const string CA1418 = "CA1418:Use valid platform string";

    public const string CA1419 =
        "CA1419:Provide a parameterless constructor that is as visible as the containing type for concrete types " +
        "derived from 'System.Runtime.InteropServices.SafeHandle'";

    public const string CA1501 = "CA1501:Avoid excessive inheritance";
    public const string CA1502 = "CA1502:Avoid excessive complexity";
    public const string CA1505 = "CA1505:Avoid unmaintainable code";
    public const string CA1506 = "CA1506:Avoid excessive class coupling";
    public const string CA1507 = "CA1507:Use nameof in place of string";
    public const string CA1508 = "CA1508:Avoid dead conditional code";
    public const string CA1509 = "CA1509:Invalid entry in code metrics configuration file";
    public const string CA1700 = "CA1700:Do not name enum values 'Reserved'";
    public const string CA1707 = "CA1707:Identifiers should not contain underscores";
    public const string CA1708 = "CA1708:Identifiers should differ by more than case";
    public const string CA1710 = "CA1710:Identifiers should have correct suffix";
    public const string CA1711 = "CA1711:Identifiers should not have incorrect suffix";
    public const string CA1712 = "CA1712:Do not prefix enum values with type name";
    public const string CA1713 = "CA1713:Events should not have before or after prefix";
    public const string CA1714 = "CA1714:Flags enums should have plural names";
    public const string CA1715 = "CA1715:Identifiers should have correct prefix";
    public const string CA1716 = "CA1716:Identifiers should not match keywords";
    public const string CA1717 = "CA1717:Only FlagsAttribute enums should have plural names";
    public const string CA1720 = "CA1720:Identifiers should not contain type names";
    public const string CA1721 = "CA1721:Property names should not match get methods";
    public const string CA1724 = "CA1724:Type Names Should Not Match Namespaces";
    public const string CA1725 = "CA1725:Parameter names should match base declaration";
    public const string CA1727 = "CA1727:Use PascalCase for named placeholders";
    public const string CA1801 = "CA1801:Review unused parameters";
    public const string CA1802 = "CA1802:Use Literals Where Appropriate";
    public const string CA1805 = "CA1805:Do not initialize unnecessarily";
    public const string CA1806 = "CA1806:Do not ignore method results";
    public const string CA1810 = "CA1810:Initialize reference type static fields inline";
    public const string CA1812 = "CA1812:Avoid uninstantiated internal classes";
    public const string CA1813 = "CA1813:Avoid unsealed attributes";
    public const string CA1814 = "CA1814:Prefer jagged arrays over multidimensional";
    public const string CA1815 = "CA1815:Override equals and operator equals on value types";
    public const string CA1816 = "CA1816:Call GC.SuppressFinalize correctly";
    public const string CA1819 = "CA1819:Properties should not return arrays";
    public const string CA1820 = "CA1820:Test for empty strings using string length";
    public const string CA1821 = "CA1821:Remove empty finalizers";
    public const string CA1822 = "CA1822:Mark members as static";
    public const string CA1823 = "CA1823:Avoid unused private fields";
    public const string CA1824 = "CA1824:Mark assemblies with NeutralResourcesLanguageAttribute";
    public const string CA1825 = "CA1825:Avoid zero-length array allocations";
    public const string CA1826 = "CA1826:Use property instead of Linq Enumerable method";
    public const string CA1827 = "CA1827:Do not use Count/LongCount when Any can be used";
    public const string CA1828 = "CA1828:Do not use CountAsync/LongCountAsync when AnyAsync can be used";
    public const string CA1829 = "CA1829:Use Length/Count property instead of Enumerable.Count method";
    public const string CA1830 = "CA1830:Prefer strongly-typed Append and Insert method overloads on StringBuilder";
    public const string CA1831 = "CA1831:Use AsSpan instead of Range-based indexers for string when appropriate";

    public const string CA1832 =
        "CA1832:Use AsSpan or AsMemory instead of Range-based indexers for getting ReadOnlySpan or ReadOnlyMemory " +
        "portion of an array";

    public const string CA1833 =
        "CA1833:Use AsSpan or AsMemory instead of Range-based indexers for getting Span or Memory portion of an array";

    public const string CA1834 = "CA1834:Use StringBuilder.Append(char) for single character strings";
    public const string CA1835 = "CA1835:Prefer the 'Memory'-based overloads for 'ReadAsync' and 'WriteAsync'";
    public const string CA1836 = "CA1836:Prefer IsEmpty over Count when available";
    public const string CA1837 = "CA1837:Use Environment.ProcessId instead of Process.GetCurrentProcess().Id";
    public const string CA1838 = "CA1838:Avoid StringBuilder parameters for P/Invokes";

    public const string CA1839 =
        "CA1839:Use Environment.ProcessPath instead of Process.GetCurrentProcess().MainModule.FileName";

    public const string CA1840 =
        "CA1840:Use Environment.CurrentManagedThreadId instead of Thread.CurrentThread.ManagedThreadId";

    public const string CA1841 = "CA1841:Prefer Dictionary Contains methods";
    public const string CA1842 = "CA1842:Do not use 'WhenAll' with a single task";
    public const string CA1843 = "CA1843:Do not use 'WaitAll' with a single task";
    public const string CA1844 = "CA1844:Provide memory-based overrides of async methods when subclassing 'Stream'";
    public const string CA1845 = "CA1845:Use span-based 'string.Concat'";
    public const string CA1846 = "CA1846:Prefer AsSpan over Substring";
    public const string CA1847 = "CA1847:Use char literal for a single character lookup";
    public const string CA1848 = "CA1848:Use the LoggerMessage delegates";
    public const string CA1849 = "CA1849:Call async methods when in an async method";
    public const string CA1850 = "CA1850:Prefer static HashData method over ComputeHash";
    public const string CA2000 = "CA2000:Dispose objects before losing scope";
    public const string CA2002 = "CA2002:Do not lock on objects with weak identity";
    public const string CA2007 = "CA2007:Do not directly await a Task";
    public const string CA2008 = "CA2008:Do not create tasks without passing a TaskScheduler";
    public const string CA2009 = "CA2009:Do not call ToImmutableCollection on an ImmutableCollection value";
    public const string CA2011 = "CA2011:Do not assign property within its setter";
    public const string CA2012 = "CA2012:Use ValueTasks correctly";
    public const string CA2013 = "CA2013:Do not use ReferenceEquals with value types";
    public const string CA2014 = "CA2014:Do not use stackalloc in loops.";
    public const string CA2015 = "CA2015:Do not define finalizers for types derived from MemoryManager<T>";
    public const string CA2016 = "CA2016:Forward the CancellationToken parameter to methods that take one";
    public const string CA2017 = "CA2017:Parameter count mismatch";

    public const string CA2018 =
        "CA2018:The count argument to Buffer.BlockCopy should specify the number of bytes to copy";

    public const string CA2100 = "CA2100:Review SQL queries for security vulnerabilities";
    public const string CA2101 = "CA2101:Specify marshalling for P/Invoke string arguments";
    public const string CA2109 = "CA2109:Review visible event handlers";
    public const string CA2119 = "CA2119:Seal methods that satisfy private interfaces";
    public const string CA2153 = "CA2153:Avoid handling Corrupted State Exceptions";
    public const string CA2200 = "CA2200:Rethrow to preserve stack details";
    public const string CA2201 = "CA2201:Do not raise reserved exception types";
    public const string CA2207 = "CA2207:Initialize value type static fields inline";
    public const string CA2208 = "CA2208:Instantiate argument exceptions correctly";
    public const string CA2211 = "CA2211:Non-constant fields should not be visible";
    public const string CA2213 = "CA2213:Disposable fields should be disposed";
    public const string CA2214 = "CA2214:Do not call overridable methods in constructors";
    public const string CA2215 = "CA2215:Dispose methods should call base class dispose";
    public const string CA2216 = "CA2216:Disposable types should declare finalizer";
    public const string CA2217 = "CA2217:Do not mark enums with FlagsAttribute";
    public const string CA2218 = "CA2218:Override GetHashCode on overriding Equals";
    public const string CA2219 = "CA2219:Do not raise exceptions in exception clauses";
    public const string CA2224 = "CA2224:Override equals on overloading operator equals";
    public const string CA2225 = "CA2225:Operator overloads have named alternates";
    public const string CA2226 = "CA2226:Operators should have symmetrical overloads";
    public const string CA2227 = "CA2227:Collection properties should be read only";
    public const string CA2229 = "CA2229:Implement serialization constructors";
    public const string CA2231 = "CA2231:Overload operator equals on overriding ValueType.Equals";
    public const string CA2234 = "CA2234:Pass System.Uri objects instead of strings";
    public const string CA2235 = "CA2235:Mark all non-serializable fields";
    public const string CA2237 = "CA2237:Mark ISerializable types with SerializableAttribute";
    public const string CA2241 = "CA2241:Provide correct arguments to formatting methods";
    public const string CA2242 = "CA2242:Test for NaN correctly";
    public const string CA2243 = "CA2243:Attribute string literals should parse correctly";
    public const string CA2244 = "CA2244:Do not duplicate indexed element initializations";
    public const string CA2245 = "CA2245:Do not assign a property to itself";
    public const string CA2246 = "CA2246:Do not assign a symbol and its member in the same statement";

    public const string CA2247 =
        "CA2247:Argument passed to TaskCompletionSource constructor should be TaskCreationOptions enum instead of " +
        "TaskContinuationOptions enum.";

    public const string CA2248 = "CA2248:Provide correct enum argument to Enum.HasFlag";
    public const string CA2249 = "CA2249:Consider using String.Contains instead of String.IndexOf";
    public const string CA2250 = "CA2250:Use ThrowIfCancellationRequested";
    public const string CA2251 = "CA2251:Use String.Equals over String.Compare";
    public const string CA2252 = "CA2252:Opt in to preview features";
    public const string CA2253 = "CA2253:Named placeholders should not be numeric values";
    public const string CA2254 = "CA2254:Template should be a static expression";
    public const string CA2255 = "CA2255:The ModuleInitializer attribute should not be used in libraries";

    public const string CA2256 =
        "CA2256:All members declared in parent interfaces must have an implementation in a " +
        "DynamicInterfaceCastableImplementation-attributed interface";

    public const string CA2257 =
        "CA2257:Members defined on an interface with 'DynamicInterfaceCastableImplementationAttribute' should be " +
        "'static'";

    public const string CA2258 =
        "CA2258:Providing a 'DynamicInterfaceCastableImplementation' interface in Visual Basic is unsupported";

    public const string CA2300 = "CA2300:Do not use insecure deserializer BinaryFormatter";

    public const string CA2301 =
        "CA2301:Do not call BinaryFormatter.Deserialize without first setting BinaryFormatter.Binder";

    public const string CA2302 =
        "CA2302:Ensure BinaryFormatter.Binder is set before calling BinaryFormatter.Deserialize";

    public const string CA2305 = "CA2305:Do not use insecure deserializer LosFormatter";
    public const string CA2310 = "CA2310:Do not use insecure deserializer NetDataContractSerializer";
    public const string CA2311 = "CA2311:Do not deserialize without first setting NetDataContractSerializer.Binder";
    public const string CA2312 = "CA2312:Ensure NetDataContractSerializer.Binder is set before deserializing";
    public const string CA2315 = "CA2315:Do not use insecure deserializer ObjectStateFormatter";
    public const string CA2321 = "CA2321:Do not deserialize with JavaScriptSerializer using a SimpleTypeResolver";

    public const string CA2322 =
        "CA2322:Ensure JavaScriptSerializer is not initialized with SimpleTypeResolver before deserializing";

    public const string CA2326 = "CA2326:Do not use TypeNameHandling values other than None";
    public const string CA2327 = "CA2327:Do not use insecure JsonSerializerSettings";
    public const string CA2328 = "CA2328:Ensure that JsonSerializerSettings are secure";
    public const string CA2329 = "CA2329:Do not deserialize with JsonSerializer using an insecure configuration";
    public const string CA2330 = "CA2330:Ensure that JsonSerializer has a secure configuration when deserializing";
    public const string CA2350 = "CA2350:Ensure DataTable.ReadXml()'s input is trusted";
    public const string CA2351 = "CA2351:Ensure DataSet.ReadXml()'s input is trusted";

    public const string CA2352 =
        "CA2352:Unsafe DataSet or DataTable in serializable type can be vulnerable to remote code execution attacks";

    public const string CA2353 = "CA2353:Unsafe DataSet or DataTable in serializable type";

    public const string CA2354 =
        "CA2354:Unsafe DataSet or DataTable in deserialized object graph can be vulnerable to remote code execution " +
        "attack";

    public const string CA2355 = "CA2355:Unsafe DataSet or DataTable in deserialized object graph";
    public const string CA2356 = "CA2356:Unsafe DataSet or DataTable in web deserialized object graph";

    public const string CA2361 =
        "CA2361:Ensure autogenerated class containing DataSet.ReadXml() is not used with untrusted data";

    public const string CA2362 =
        "CA2362:Unsafe DataSet or DataTable in autogenerated serializable type can be vulnerable to remote code " +
        "execution attacks";

    public const string CA3001 = "CA3001:Review code for SQL injection vulnerabilities";
    public const string CA3002 = "CA3002:Review code for XSS vulnerabilities";
    public const string CA3003 = "CA3003:Review code for file path injection vulnerabilities";
    public const string CA3004 = "CA3004:Review code for information disclosure vulnerabilities";
    public const string CA3006 = "CA3006:Review code for process command injection vulnerabilities";
    public const string CA3007 = "CA3007:Review code for open redirect vulnerabilities";
    public const string CA3008 = "CA3008:Review code for XPath injection vulnerabilities";
    public const string CA3009 = "CA3009:Review code for XML injection vulnerabilities";
    public const string CA3010 = "CA3010:Review code for XAML injection vulnerabilities";
    public const string CA3011 = "CA3011:Review code for DLL injection vulnerabilities";
    public const string CA3012 = "CA3012:Review code for regex injection vulnerabilities";
    public const string CA3061 = "CA3061:Do not add schema by URL";
    public const string CA3075 = "CA3075:Insecure DTD Processing";
    public const string CA3076 = "CA3076:Insecure XSLT Script Execution";
    public const string CA3077 = "CA3077:Insecure Processing in API Design, XML Document and XML Text Reader";
    public const string CA3147 = "CA3147:Mark verb handlers with ValidateAntiForgeryToken";
    public const string CA5350 = "CA5350:Do Not Use Weak Cryptographic Algorithms";
    public const string CA5358 = "CA5358:Do Not Use Unsafe Cipher Modes";
    public const string CA5361 = "CA5361:Do not disable Schannel use of strong crypto";
    public const string CA5363 = "CA5363:Do not disable request validation";
    public const string CA5364 = "CA5364:Do not use deprecated security protocols";
    public const string CA5369 = "CA5369:Use XmlReader for Deserialize";
    public const string CA5370 = "CA5370:Use XmlReader for validating reader";
    public const string CA5371 = "CA5371:Use XmlReader for schema read";
    public const string CA5372 = "CA5372:Use XmlReader for XPathDocument";
    public const string CA5373 = "CA5373:Do not use obsolete key derivation function";
    public const string CA5378 = "CA5378:Do not disable ServicePointManagerSecurityProtocols";
    public const string CA5380 = "CA5380:Do not add certificates to root store";
    public const string CA5381 = "CA5381:Ensure certificates are not added to root store";
    public const string CA5386 = "CA5386:Avoid hardcoding SecurityProtocolType value";
    public const string CA5389 = "CA5389:Do not add archive item's path to the target file system path";
    public const string CA5397 = "CA5397:Do not use deprecated SslProtocols values";
    public const string CA5398 = "CA5398:Avoid hardcoded SslProtocols values";
    public const string CA5403 = "CA5403:Do not hard-code certificate";
    public const string CA5404 = "CA5404:Do not disable token validation checks";
    public const string CA5405 = "CA5405:Do not always skip token validation in delegates";
}
