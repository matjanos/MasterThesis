namespace MasterThesis.RestTestsGenerator.UseCases
{
    public enum AssertRestrictionType
    {
        /// <summary>
        /// Status code is the same
        /// </summary>
        StatusCode = 1,

        /// <summary>
        /// Format of document is correct (json/xml/...)
        /// </summary>
        ResultFormat = 2,

        /// <summary>
        /// Structure of document is equal to schema (values meet requirements)
        /// </summary>
        Structure = 4,

        /// <summary>
        /// All values are the same as in use case.
        /// </summary>
        Values = 8
    }
}