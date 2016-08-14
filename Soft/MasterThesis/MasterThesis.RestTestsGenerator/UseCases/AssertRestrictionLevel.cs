namespace MasterThesis.RestTestsGenerator.UseCases
{
    public enum AssertRestrictionLevel
    {
        /// <summary>
        /// HTTP response came
        /// </summary>
        AnyResponse = 0,

        /// <summary>
        /// Status code is the same
        /// </summary>
        StatusCode = 1,

        /// <summary>
        /// Headers matches pattern or exists if no pattern defined
        /// </summary>
        Headers = 2,

        /// <summary>
        /// Format of document is correct (json/xml/...)
        /// </summary>
        ResultFormat = 3,

        /// <summary>
        /// Structure of document is equal to schema (values meet requirements)
        /// </summary>
        Structure = 4,

        /// <summary>
        /// All values are the same as in use case.
        /// </summary>
        Values = 5
    }
}