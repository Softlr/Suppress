namespace Softlr;

[SuppressMessage(SONARQUBE, S2339)]
public static partial class Suppress
{
    public const string CA1004 = "CA1004:Generic methods should provide type parameter";
    public const string CA1006 = "CA1006:Do not nest generic types in member signatures";
    public const string CA1007 = "CA1007:Use generics where appropriate";
    public const string CA1009 = "CA1009:Declare event handlers correctly";
    public const string CA1011 = "CA1011:Consider passing base types as parameters";
    public const string CA1013 = "CA1013:Overload operator equals on overloading add and subtract";
    public const string CA1020 = "CA1020:Avoid namespaces with few types";
    public const string CA1023 = "CA1023:Indexers should not be multidimensional";
    public const string CA1025 = "CA1025:Replace repetitive arguments with params array";
    public const string CA1026 = "CA1026:Default parameters should not be used";
    public const string CA1035 = "CA1035:ICollection implementations have strongly typed members";
    public const string CA1038 = "CA1038:Enumerators should be strongly typed";
    public const string CA1039 = "CA1039:Lists are strongly typed";
    public const string CA1048 = "CA1048:Do not declare virtual members in sealed types";
    public const string CA1049 = "CA1049:Types that own native resources should be disposable";
    public const string CA1053 = "CA1053:Static holder types should not have constructors";
    public const string CA1057 = "CA1057:String URI overloads call System.Uri overloads";
    public const string CA1059 = "CA1059:Members should not expose certain concrete types";
    public const string CA1300 = "CA1300:Specify MessageBoxOptions";
    public const string CA1301 = "CA1301:Avoid duplicate accelerators";
    public const string CA1302 = "CA1302:Do not hardcode locale specific strings";
    public const string CA1306 = "CA1306:Set locale for data types";
    public const string CA1400 = "CA1400:P/Invoke entry points should exist";
    public const string CA1402 = "CA1402:Avoid overloads in COM visible interfaces";
    public const string CA1403 = "CA1403:Auto layout types should not be COM visible";
    public const string CA1404 = "CA1404:Call GetLastError immediately after P/Invoke";
    public const string CA1405 = "CA1405:COM visible type base types should be COM visible";
    public const string CA1406 = "CA1406:Avoid Int64 arguments for Visual Basic 6 clients";
    public const string CA1407 = "CA1407:Avoid static members in COM visible types";
    public const string CA1408 = "CA1408:Do not use AutoDual ClassInterfaceType";
    public const string CA1409 = "CA1409:Com visible types should be creatable";
    public const string CA1410 = "CA1410:COM registration methods should be matched";
    public const string CA1411 = "CA1411:COM registration methods should not be visible";
    public const string CA1412 = "CA1412:Mark ComSource Interfaces as IDispatch";
    public const string CA1413 = "CA1413:Avoid non-public fields in COM visible value types";
    public const string CA1414 = "CA1414:Mark boolean P/Invoke arguments with MarshalAs";
    public const string CA1415 = "CA1415:Declare P/Invokes correctly";
    public const string CA1500 = "CA1500:Variable names should not match field names";
    public const string CA1504 = "CA1504:Review misleading field names";
    public const string CA1600 = "CA1600:Do not use idle process priority";
    public const string CA1601 = "CA1601:Do not use timers that prevent power state changes";
    public const string CA1701 = "CA1701:Resource string compound words should be cased correctly";
    public const string CA1702 = "CA1702:Compound words should be cased correctly";
    public const string CA1703 = "CA1703:Resource strings should be spelled correctly";
    public const string CA1704 = "CA1704:Identifiers should be spelled correctly";
    public const string CA1709 = "CA1709:Identifiers should be cased correctly";
    public const string CA1714 = "CA1714:Flags enums should have plural names";
    public const string CA1717 = "CA1717:Only FlagsAttribute enums should have plural names";
    public const string CA1719 = "CA1719:Parameter names should not match member names";
    public const string CA1722 = "CA1722:Identifiers should not have incorrect prefix";
    public const string CA1726 = "CA1726:Use preferred terms";
    public const string CA1800 = "CA1800:Do not cast unnecessarily";
    public const string CA1804 = "CA1804:Remove unused locals";
    public const string CA1809 = "CA1809:Avoid excessive locals";
    public const string CA1811 = "CA1811:Avoid uncalled private code";
    public const string CA1900 = "CA1900:Value type fields should be portable";
    public const string CA1901 = "CA1901:P/Invoke declarations should be portable";
    public const string CA1903 = "CA1903:Use only API from targeted framework";
    public const string CA2001 = "CA2001:Avoid calling problematic methods";
    public const string CA2003 = "CA2003:Do not treat fibers as threads";
    public const string CA2004 = "CA2004:Remove calls to GC.KeepAlive";
    public const string CA2006 = "CA2006:Use SafeHandle to encapsulate native resources";
    public const string CA2102 = "CA2102:Catch non-CLSCompliant exceptions in general handlers";
    public const string CA2103 = "CA2103:Review imperative security";
    public const string CA2104 = "CA2104:Do not declare read only mutable reference types";
    public const string CA2105 = "CA2105:Array fields should not be read only";
    public const string CA2106 = "CA2106:Secure asserts";
    public const string CA2107 = "CA2107:Review deny and permit only usage";
    public const string CA2108 = "CA2108:Review declarative security on value types";
    public const string CA2111 = "CA2111:Pointers should not be visible";
    public const string CA2112 = "CA2112:Secured types should not expose fields";
    public const string CA2114 = "CA2114:Method security should be a superset of type";
    public const string CA2115 = "CA2115:Call GC.KeepAlive when using native resources";
    public const string CA2116 = "CA2116:APTCA methods should only call APTCA methods";
    public const string CA2117 = "CA2117:APTCA types should only extend APTCA base types";
    public const string CA2118 = "CA2118:Review SuppressUnmanagedCodeSecurityAttribute usage";
    public const string CA2120 = "CA2120:Secure serialization constructors";
    public const string CA2121 = "CA2121:Static constructors should be private";
    public const string CA2122 = "CA2122:Do not indirectly expose methods with link demands";
    public const string CA2123 = "CA2123:Override link demands should be identical to base";
    public const string CA2124 = "CA2124:Wrap vulnerable finally clauses in outer try";
    public const string CA2126 = "CA2126:Type link demands require inheritance demands";
    public const string CA2130 = "CA2130:Security critical constants should be transparent";
    public const string CA2131 = "CA2131:Security critical types may not participate in type equivalence";

    public const string CA2132 =
        "CA2132:Default constructors must be at least as critical as base type default constructors";

    public const string CA2133 = "CA2133:Delegates must bind to methods with consistent transparency";
    public const string CA2134 = "CA2134:Methods must keep consistent transparency when overriding base methods";
    public const string CA2135 = "CA2135:Level 2 assemblies should not contain LinkDemands";
    public const string CA2136 = "CA2136:Members should not have conflicting transparency annotations";
    public const string CA2137 = "CA2137:Transparent methods must contain only verifiable IL";

    public const string CA2138 =
        "CA2138:Transparent methods must not call methods with the SuppressUnmanagedCodeSecurity attribute";

    public const string CA2139 =
        "CA2139:Transparent methods may not use the HandleProcessCorruptingExceptions attribute";

    public const string CA2140 = "CA2140:Transparent code must not reference security critical items";
    public const string CA2141 = "CA2141:Transparent methods must not satisfy LinkDemands";
    public const string CA2142 = "CA2142:Transparent code should not be protected with LinkDemands";
    public const string CA2143 = "CA2143:Transparent methods should not use security demands";
    public const string CA2144 = "CA2144:Transparent code should not load assemblies from byte arrays";

    public const string CA2145 =
        "CA2145:Transparent methods should not be decorated with the SuppressUnmanagedCodeSecurityAttribute";

    public const string CA2146 = "CA2146:Types must be at least as critical as their base types and interfaces";
    public const string CA2147 = "CA2147:Transparent methods may not use security asserts";
    public const string CA2149 = "CA2149:Transparent methods must not call into native code";
    public const string CA2151 = "CA2151:Fields with critical types should be security critical";
    public const string CA2202 = "CA2202:Do not dispose objects multiple times";
    public const string CA2204 = "CA2204:Literals should be spelled correctly";
    public const string CA2205 = "CA2205:Use managed equivalents of Win32 API";
    public const string CA2210 = "CA2210:Assemblies should have valid strong names";
    public const string CA2212 = "CA2212:Do not mark serviced components with WebMethod";
    public const string CA2218 = "CA2218:Override GetHashCode on overriding Equals";
    public const string CA2220 = "CA2220:Finalizers should call base class finalizer";
    public const string CA2221 = "CA2221:Finalizers should be protected";
    public const string CA2222 = "CA2222:Do not decrease inherited member visibility";
    public const string CA2223 = "CA2223:Members should differ by more than return type";
    public const string CA2224 = "CA2224:Override equals on overloading operator equals";
    public const string CA2228 = "CA2228:Do not ship unreleased resource formats";
    public const string CA2230 = "CA2230:Use params for variable arguments";
    public const string CA2232 = "CA2232:Mark Windows Forms entry points with STAThread";
    public const string CA2233 = "CA2233:Operations should not overflow";
    public const string CA2236 = "CA2236:Call base class methods on ISerializable types";
    public const string CA2238 = "CA2238:Implement serialization methods correctly";
    public const string CA2239 = "CA2239:Provide deserialization methods for optional fields";
    public const string CA2240 = "CA2240:Implement ISerializable correctly";
    public const string CA5122 = "CA5122:P/Invoke declarations should not be safe critical";
}
