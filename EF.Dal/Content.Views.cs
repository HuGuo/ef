//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySetsDEEA67CD6E7C5778750284624B2CFCF69E8C391368A6E29B83D81EACBA15D53B))]

namespace Edm_EntityMappingGeneratedViews
{
    
    
    /// <Summary>
    /// The type contains views for EntitySets and AssociationSets that were generated at design time.
    /// </Summary>
    public sealed class ViewsForBaseEntitySetsDEEA67CD6E7C5778750284624B2CFCF69E8C391368A6E29B83D81EACBA15D53B : System.Data.Mapping.EntityViewContainer
    {
        
        /// <Summary>
        /// The constructor stores the views for the extents and also the hash values generated based on the metadata and mapping closure and views.
        /// </Summary>
        public ViewsForBaseEntitySetsDEEA67CD6E7C5778750284624B2CFCF69E8C391368A6E29B83D81EACBA15D53B()
        {
            this.EdmEntityContainerName = "Content";
            this.StoreEntityContainerName = "CodeFirstDatabase";
            this.HashOverMappingClosure = "b97b2ccd8a23bf67d7b87add9a848ca63f37fb24deafc5c813691b1f8d50ebea";
            this.HashOverAllExtentViews = "03a2d4951e3353dc05d01d0fb5d518868c22e32e8c96b51917ce4ca13d45e761";
            this.ViewCount = 8;
        }
        
        /// <Summary>
        /// The method returns the view for the index given.
        /// </Summary>
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                return GetView0();
            }
            if ((index == 1))
            {
                return GetView1();
            }
            if ((index == 2))
            {
                return GetView2();
            }
            if ((index == 3))
            {
                return GetView3();
            }
            if ((index == 4))
            {
                return GetView4();
            }
            if ((index == 5))
            {
                return GetView5();
            }
            if ((index == 6))
            {
                return GetView6();
            }
            if ((index == 7))
            {
                return GetView7();
            }
            throw new System.IndexOutOfRangeException();
        }
        
        /// <Summary>
        /// return view for CodeFirstDatabase.Folder
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView0()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("CodeFirstDatabase.Folder", @"
    SELECT VALUE -- Constructing Folder
        [CodeFirstDatabaseSchema.Folder](T1.Folder_Id, T1.Folder_Name, T1.Folder_UserId, T1.Folder_ParentFolderId)
    FROM (
        SELECT 
            T.Id AS Folder_Id, 
            T.Name AS Folder_Name, 
            T.UserId AS Folder_UserId, 
            T.ParentFolderId AS Folder_ParentFolderId, 
            True AS _from0
        FROM Content.Folders AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for CodeFirstDatabase.File
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView1()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("CodeFirstDatabase.File", @"
    SELECT VALUE -- Constructing File
        [CodeFirstDatabaseSchema.File](T1.File_Id, T1.File_Name, T1.File_UserId, T1.File_FolderId)
    FROM (
        SELECT 
            T.Id AS File_Id, 
            T.Name AS File_Name, 
            T.UserId AS File_UserId, 
            T.FolderId AS File_FolderId, 
            True AS _from0
        FROM Content.Files AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for Content.Folders
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView2()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("Content.Folders", @"
    SELECT VALUE -- Constructing Folders
        [EF.Dal.Folder](T1.Folder_Id, T1.Folder_Name, T1.Folder_UserId, T1.Folder_ParentFolderId)
    FROM (
        SELECT 
            T.Id AS Folder_Id, 
            T.Name AS Folder_Name, 
            T.UserId AS Folder_UserId, 
            T.ParentFolderId AS Folder_ParentFolderId, 
            True AS _from0
        FROM CodeFirstDatabase.Folder AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for Content.Files
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView3()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("Content.Files", @"
    SELECT VALUE -- Constructing Files
        [EF.Dal.File](T1.File_Id, T1.File_Name, T1.File_UserId, T1.File_FolderId)
    FROM (
        SELECT 
            T.Id AS File_Id, 
            T.Name AS File_Name, 
            T.UserId AS File_UserId, 
            T.FolderId AS File_FolderId, 
            True AS _from0
        FROM CodeFirstDatabase.File AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for CodeFirstDatabase.User
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView4()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("CodeFirstDatabase.User", @"
    SELECT VALUE -- Constructing User
        [CodeFirstDatabaseSchema.User](T1.User_Id, T1.User_Name)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.Name AS User_Name, 
            True AS _from0
        FROM Content.Users AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for Content.Users
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView5()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("Content.Users", @"
    SELECT VALUE -- Constructing Users
        [EF.Dal.User](T1.User_Id, T1.User_Name)
    FROM (
        SELECT 
            T.Id AS User_Id, 
            T.Name AS User_Name, 
            True AS _from0
        FROM CodeFirstDatabase.User AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for CodeFirstDatabase.EdmMetadata
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView6()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("CodeFirstDatabase.EdmMetadata", @"
    SELECT VALUE -- Constructing EdmMetadata
        [CodeFirstDatabaseSchema.EdmMetadata](T1.EdmMetadata_Id, T1.EdmMetadata_ModelHash)
    FROM (
        SELECT 
            T.Id AS EdmMetadata_Id, 
            T.ModelHash AS EdmMetadata_ModelHash, 
            True AS _from0
        FROM Content.EdmMetadatas AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for Content.EdmMetadatas
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView7()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("Content.EdmMetadatas", @"
    SELECT VALUE -- Constructing EdmMetadatas
        [EF.Dal.EdmMetadata](T1.EdmMetadata_Id, T1.EdmMetadata_ModelHash)
    FROM (
        SELECT 
            T.Id AS EdmMetadata_Id, 
            T.ModelHash AS EdmMetadata_ModelHash, 
            True AS _from0
        FROM CodeFirstDatabase.EdmMetadata AS T
    ) AS T1");
        }
    }
}
