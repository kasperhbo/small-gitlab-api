using System.Reflection.Metadata;

namespace GitlabAPI.Models;

public record Project
{
    public required long id { get; init; }
    public required bool isPublic { get; init; }   
    public required string name {get; init;}
    public required string _namespace {get; init;}
    public required string nameWithNamespace {get; init;}
    public required string owner {get; init;}
    public required string path {get; init;}
    public required long creatorId {get; init;}
    public required string httpUrlToRepo {get; init;}
    public required string pathWithNamespace {get; init;}
    public required bool emptyRepo {get; init;}                   
    public required int approvalsBeforeMerge {get; init;}
    public required bool archived {get; init;}
    public required string avatarUrl {get; init;}
    public required bool containerRegistryEnabled {get; init;}
    public required string defaultBranch {get; init;}
    public required string description {get; init;}
    public required int forksCount {get; init;}
    public required Project forkedFromProject {get; init;}  
    public required bool issuesEnabled {init; get;}
    public required bool jobsEnabled {init; get;}
    public required DateTime lastActivityAt {init; get;}
    public required bool lfsEnabled {init; get;}
    public required string mergeMethod {init; get;}
    public required bool mergeRequestsEnabled {init; get;}
    public required bool onlyAllowMergeIfPipelineSucceeds {init; get;}
    public required bool allowMergeOnSkippedPipeline {init; get;}
    public required bool onlyAllowMergeIfAllDiscussionsAreResolved {init; get;}
    public required int openIssuesCount {init; get;}
    public required string webUrl {init; get;}
    public required string sshUrlToRepo {init; get;}

    private string permissions;
    
    private bool publicJobs;
    private string repositoryStorage;
    private bool requestAccessEnabled;
    private string runnersToken;
    private bool sharedRunnersEnabled;
    private List<string> sharedWithGroups;
    private bool snippetsEnabled;
    private int starCount;
    private List<string> tagList;
    private List<string> topics;
    private int visibilityLevel;
    private string visibility;
    private bool wallEnabled;
    private bool wikiEnabled;
    private bool printingMergeRequestLinkEnabled;
    private bool resolveOutdatedDiffDiscussions;
    private string statistics;
    private bool initializeWithReadme;
    private bool packagesEnabled;
    private string licenseUrl;
    private string license;
    private List<CustomAttribute> customAttributes;
    private string buildCoverageRegex;
    private string buildGitStrategy;
    private string readmeUrl;
    private bool canCreateMergeRequestIn;
    private string importStatus;
    private int ciDefaultGitDepth;
    private bool ciForwardDeploymentEnabled;
    private string ciConfigPath;
    private bool removeSourceBranchAfterMerge;
    private bool autoDevopsEnabled;
    private string autoDevopsDeployStrategy;
    private bool autocloseReferencedIssues;
    private bool emailsDisabled;
    private string suggestionCommitMessage;
    private string squashOption;
    private string mergeCommitTemplate;
    private string squashCommitTemplate;
    private string issueBranchTemplate;
    private string mergeRequestsTemplate;
    private string issuesTemplate;
    private Dictionary<string, string> links;
    private DateTime markedForDeletionOn;
}