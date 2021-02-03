namespace Softlr
{
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage(SONARQUBE, S2339)]
    public static partial class Suppress
    {
        public const string SA0001 = "SA0001:XML comment analysis disabled";
        public const string SA0002 = "SA0002:Invalid settings file";
        public const string SA1000 = "SA1000:Keywords should be spaced correctly";
        public const string SA1001 = "SA1001:Commas should be spaced correctly";
        public const string SA1002 = "SA1002:Semicolons should be spaced correctly";
        public const string SA1003 = "SA1003:Symbols should be spaced correctly";
        public const string SA1004 = "SA1004:Documentation lines should begin with single space";
        public const string SA1005 = "SA1005:Single line comments should begin with single space";
        public const string SA1006 = "SA1006:Preprocessor keywords should not be preceded by space";
        public const string SA1007 = "SA1007:Operator keyword should be followed by space";
        public const string SA1008 = "SA1008:Opening parenthesis should be spaced correctly";
        public const string SA1009 = "SA1009:Closing parenthesis should be spaced correctly";
        public const string SA1010 = "SA1010:Opening square brackets should be spaced correctly";
        public const string SA1011 = "SA1011:Closing square brackets should be spaced correctly";
        public const string SA1012 = "SA1012:Opening braces should be spaced correctly";
        public const string SA1013 = "SA1013:Closing braces should be spaced correctly";
        public const string SA1014 = "SA1014:Opening generic brackets should be spaced correctly";
        public const string SA1015 = "SA1015:Closing generic brackets should be spaced correctly";
        public const string SA1016 = "SA1016:Opening attribute brackets should be spaced correctly";
        public const string SA1017 = "SA1017:Closing attribute brackets should be spaced correctly";
        public const string SA1018 = "SA1018:Nullable type symbols should be spaced correctly";
        public const string SA1019 = "SA1019:Member access symbols should be spaced correctly";
        public const string SA1020 = "SA1020:Increment decrement symbols should be spaced correctly";
        public const string SA1021 = "SA1021:Negative signs should be spaced correctly";
        public const string SA1022 = "SA1022:Positive signs should be spaced correctly";
        public const string SA1023 = "SA1023:Dereference and access of symbols should be spaced correctly";
        public const string SA1024 = "SA1024:Colons Should Be Spaced Correctly";
        public const string SA1025 = "SA1025:Code should not contain multiple whitespace in a row";

        public const string SA1026 =
            "SA1026:Code should not contain space after new or stackalloc keyword in implicitly typed array " +
            "allocation";

        public const string SA1027 = "SA1027:Use tabs correctly";
        public const string SA1028 = "SA1028:Code should not contain trailing whitespace";
        public const string SA1100 = "SA1100:Do not prefix calls with base unless local implementation exists";
        public const string SA1101 = "SA1101:Prefix local calls with this";
        public const string SA1102 = "SA1102:Query clause should follow previous clause";
        public const string SA1103 = "SA1103:Query clauses should be on separate lines or all on one line";

        public const string SA1104 =
            "SA1104:Query clause should begin on new line when previous clause spans multiple lines";

        public const string SA1105 = "SA1105:Query clauses spanning multiple lines should begin on own line";
        public const string SA1106 = "SA1106:Code should not contain empty statements";
        public const string SA1107 = "SA1107:Code should not contain multiple statements on one line";
        public const string SA1108 = "SA1108:Block statements should not contain embedded comments";
        public const string SA1110 = "SA1110:Opening parenthesis or bracket should be on declaration line";
        public const string SA1111 = "SA1111:Closing parenthesis should be on line of last parameter";
        public const string SA1112 = "SA1112:Closing parenthesis should be on line of opening parenthesis";
        public const string SA1113 = "SA1113:Comma should be on the same line as previous parameter";
        public const string SA1114 = "SA1114:Parameter list should follow declaration";
        public const string SA1115 = "SA1115:Parameter should follow comma";
        public const string SA1116 = "SA1116:Split parameters should start on line after declaration";
        public const string SA1117 = "SA1117:Parameters should be on same line or separate lines";
        public const string SA1118 = "SA1118:Parameter should not span multiple lines";
        public const string SA1119 = "SA1119:Statement should not use unnecessary parenthesis";
        public const string SA1120 = "SA1120:Comments should contain text";
        public const string SA1121 = "SA1121:Use built-in type alias";
        public const string SA1122 = "SA1122:Use string.Empty for empty strings";
        public const string SA1123 = "SA1123:Do not place regions within elements";
        public const string SA1124 = "SA1124:Do not use regions";
        public const string SA1125 = "SA1125:Use shorthand for nullable types";
        public const string SA1127 = "SA1127:Generic type constraints should be on their own line";
        public const string SA1128 = "SA1128:Put constructor initializers on their own line";
        public const string SA1129 = "SA1129:Do not use default value type constructor";
        public const string SA1130 = "SA1130:Use lambda syntax";
        public const string SA1131 = "SA1131:Use readable conditions";
        public const string SA1132 = "SA1132:Do not combine fields";
        public const string SA1133 = "SA1133:Do not combine attributes";
        public const string SA1134 = "SA1134:Attributes should not share line";
        public const string SA1135 = "SA1135:Using directives should be qualified";
        public const string SA1136 = "SA1136:Enum values should be on separate lines";
        public const string SA1137 = "SA1137:Elements should have the same indentation";
        public const string SA1139 = "SA1139:Use literal suffix notation instead of casting";
        public const string SA1141 = "SA1141:Use tuple syntax";
        public const string SA1142 = "SA1142:Refer to tuple fields by name";
        public const string SA1200 = "SA1200:Using directives should be placed correctly";
        public const string SA1201 = "SA1201:Elements should appear in the correct order";
        public const string SA1202 = "SA1202:Elements should be ordered by access";
        public const string SA1203 = "SA1203:Constants should appear before fields";
        public const string SA1204 = "SA1204:Static elements should appear before instance elements";
        public const string SA1205 = "SA1205:Partial elements should declare access";
        public const string SA1206 = "SA1206:Declaration keywords should follow order";
        public const string SA1207 = "SA1207:Protected should come before internal";
        public const string SA1208 = "SA1208:System using directives should be placed before other using directives";
        public const string SA1209 = "SA1209:Using alias directives should be placed after other using directives";
        public const string SA1210 = "SA1210:Using directives should be ordered alphabetically by namespace";
        public const string SA1211 = "SA1211:Using alias directives should be ordered alphabetically by alias name";
        public const string SA1212 = "SA1212:Property accessors should follow order";
        public const string SA1213 = "SA1213:Event accessors should follow order";
        public const string SA1214 = "SA1214:Readonly fields should appear before non-readonly fields";
        public const string SA1216 = "SA1216:Using static directives should be placed at the correct location";
        public const string SA1217 = "SA1217:Using static directives should be ordered alphabetically";
        public const string SA1300 = "SA1300:Element should begin with upper-case letter";
        public const string SA1302 = "SA1302:Interface names should begin with I";
        public const string SA1303 = "SA1303:Const field names should begin with upper-case letter";
        public const string SA1304 = "SA1304:Non-private readonly fields should begin with upper-case letter";
        public const string SA1305 = "SA1305:Field names should not use Hungarian notation";
        public const string SA1306 = "SA1306:Field names should begin with lower-case letter";
        public const string SA1307 = "SA1307:Accessible fields should begin with upper-case letter";
        public const string SA1308 = "SA1308:Variable names should not be prefixed";
        public const string SA1309 = "SA1309:Field names should not begin with underscore";
        public const string SA1310 = "SA1310:Field names should not contain underscore";
        public const string SA1311 = "SA1311:Static readonly fields should begin with upper-case letter";
        public const string SA1312 = "SA1312:Variable names should begin with lower-case letter";
        public const string SA1313 = "SA1313:Parameter names should begin with lower-case letter";
        public const string SA1314 = "SA1314:Type parameter names should begin with T";
        public const string SA1316 = "SA1316:Tuple element names should use correct casing";
        public const string SA1400 = "SA1400:Access modifier should be declared";
        public const string SA1401 = "SA1401:Fields should be private";
        public const string SA1402 = "SA1402:File may only contain a single type";
        public const string SA1403 = "SA1403:File may only contain a single namespace";
        public const string SA1404 = "SA1404:Code analysis suppression should have justification";
        public const string SA1405 = "SA1405:Debug.Assert should provide message text";
        public const string SA1406 = "SA1406:Debug.Fail should provide message text";
        public const string SA1407 = "SA1407:Arithmetic expressions should declare precedence";
        public const string SA1408 = "SA1408:Conditional expressions should declare precedence";
        public const string SA1410 = "SA1410:Remove delegate parenthesis when possible";
        public const string SA1411 = "SA1411:Attribute constructor should not use unnecessary parenthesis";
        public const string SA1412 = "SA1412:Store files as UTF-8 with byte order mark";
        public const string SA1413 = "SA1413:Use trailing comma in multi-line initializers";
        public const string SA1414 = "SA1414:Tuple types in signatures should have element names";
        public const string SA1500 = "SA1500:Braces for multi-line statements should not share line";
        public const string SA1501 = "SA1501:Statement should not be on a single line";
        public const string SA1502 = "SA1502:Element should not be on a single line";
        public const string SA1503 = "SA1503:Braces should not be omitted";
        public const string SA1504 = "SA1504:All accessors should be single-line or multi-line";
        public const string SA1505 = "SA1505:Opening braces should not be followed by blank line";
        public const string SA1506 = "SA1506:Element documentation headers should not be followed by blank line";
        public const string SA1507 = "SA1507:Code should not contain multiple blank lines in a row";
        public const string SA1508 = "SA1508:Closing braces should not be preceded by blank line";
        public const string SA1509 = "SA1509:Opening braces should not be preceded by blank line";
        public const string SA1510 = "SA1510:Chained statement blocks should not be preceded by blank line";
        public const string SA1511 = "SA1511:While-do footer should not be preceded by blank line";
        public const string SA1512 = "SA1512:Single-line comments should not be followed by blank line";
        public const string SA1513 = "SA1513:Closing brace should be followed by blank line";
        public const string SA1514 = "SA1514:Element documentation header should be preceded by blank line";
        public const string SA1515 = "SA1515:Single-line comment should be preceded by blank line";
        public const string SA1516 = "SA1516:Elements should be separated by blank line";
        public const string SA1517 = "SA1517:Code should not contain blank lines at start of file";
        public const string SA1518 = "SA1518:Use line endings correctly at end of file";
        public const string SA1519 = "SA1519:Braces should not be omitted from multi-line child statement";
        public const string SA1520 = "SA1520:Use braces consistently";
        public const string SA1600 = "SA1600:Elements should be documented";
        public const string SA1601 = "SA1601:Partial elements should be documented";
        public const string SA1602 = "SA1602:Enumeration items should be documented";
        public const string SA1604 = "SA1604:Element documentation should have summary";
        public const string SA1605 = "SA1605:Partial element documentation should have summary";
        public const string SA1606 = "SA1606:Element documentation should have summary text";
        public const string SA1607 = "SA1607:Partial element documentation should have summary text";
        public const string SA1608 = "SA1608:Element documentation should not have default summary";
        public const string SA1609 = "SA1609:Property documentation should have value";
        public const string SA1610 = "SA1610:Property documentation should have value text";
        public const string SA1611 = "SA1611:Element parameters should be documented";
        public const string SA1612 = "SA1612:Element parameter documentation should match element parameters";
        public const string SA1613 = "SA1613:Element parameter documentation should declare parameter name";
        public const string SA1614 = "SA1614:Element parameter documentation should have text";
        public const string SA1615 = "SA1615:Element return value should be documented";
        public const string SA1616 = "SA1616:Element return value documentation should have text";
        public const string SA1617 = "SA1617:Void return value should not be documented";
        public const string SA1618 = "SA1618:Generic type parameters should be documented";
        public const string SA1619 = "SA1619:Generic type parameters should be documented partial class";
        public const string SA1620 = "SA1620:Generic type parameter documentation should match type parameters";
        public const string SA1621 = "SA1621:Generic type parameter documentation should declare parameter name";
        public const string SA1622 = "SA1622:Generic type parameter documentation should have text";
        public const string SA1623 = "SA1623:Property summary documentation should match accessors";

        public const string SA1624 =
            "SA1624:Property summary documentation should omit accessor with restricted access";

        public const string SA1625 = "SA1625:Element documentation should not be copied and pasted";
        public const string SA1626 = "SA1626:Single-line comments should not use documentation style slashes";
        public const string SA1627 = "SA1627:Documentation text should not be empty";
        public const string SA1629 = "SA1629:Documentation text should end with a period";
        public const string SA1633 = "SA1633:File should have header";
        public const string SA1634 = "SA1634:File header should show copyright";
        public const string SA1635 = "SA1635:File header should have copyright text";
        public const string SA1636 = "SA1636:File header copyright text should match";
        public const string SA1637 = "SA1637:File header should contain file name";
        public const string SA1638 = "SA1638:File header file name documentation should match file name";
        public const string SA1639 = "SA1639:File header should have summary";
        public const string SA1640 = "SA1640:File header should have valid company text";
        public const string SA1641 = "SA1641:File header company name text should match";
        public const string SA1642 = "SA1642:Constructor summary documentation should begin with standard text";
        public const string SA1643 = "SA1643:Destructor summary documentation should begin with standard text";
        public const string SA1648 = "SA1648:inheritdoc should be used with inheriting class";
        public const string SA1649 = "SA1649:File name should match first type name";
        public const string SA1651 = "SA1651:Do not use placeholder elements";
        public const string SX1101 = "SX1101:Do not prefix local calls with 'this.'";
        public const string SX1309 = "SX1309:Field names should begin with underscore";

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public const string SX1309S = "SX1309S:Static field names should begin with underscore";
    }
}