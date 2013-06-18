﻿namespace System.Management
{
    using System;

    internal enum tag_WMIQ_RPNQ_FEATURE
    {
        WMIQ_RPNF_ARRAY_ACCESS = 0x80000,
        WMIQ_RPNF_COUNT_STAR = 0x40,
        WMIQ_RPNF_DATETIME_TESTS = 0x40000,
        WMIQ_RPNF_EQUALITY_TESTS_ONLY = 0x20,
        WMIQ_RPNF_FEATURE_SELECT_STAR = 0x10,
        WMIQ_RPNF_GROUP_BY_HAVING = 0x2000,
        WMIQ_RPNF_ISA_USED = 0x800,
        WMIQ_RPNF_ISNOTA_USED = 0x1000,
        WMIQ_RPNF_ORDER_BY = 0x400,
        WMIQ_RPNF_PROJECTION = 8,
        WMIQ_RPNF_PROP_TO_PROP_TESTS = 0x200,
        WMIQ_RPNF_QUALIFIED_NAMES_IN_SELECT = 0x80,
        WMIQ_RPNF_QUALIFIED_NAMES_IN_WHERE = 0x100,
        WMIQ_RPNF_QUALIFIER_FILTER = 0x100000,
        WMIQ_RPNF_QUERY_IS_CONJUNCTIVE = 2,
        WMIQ_RPNF_QUERY_IS_DISJUNCTIVE = 4,
        WMIQ_RPNF_REFERENCE_TESTS = 0x20000,
        WMIQ_RPNF_SELECTED_FROM_PATH = 0x200000,
        WMIQ_RPNF_SYSPROP_CLASS = 0x10000,
        WMIQ_RPNF_WHERE_CLAUSE_PRESENT = 1,
        WMIQ_RPNF_WITHIN_AGGREGATE = 0x8000,
        WMIQ_RPNF_WITHIN_INTERVAL = 0x4000
    }
}

