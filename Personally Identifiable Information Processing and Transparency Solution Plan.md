### PT-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has clear, written rules for how it handles people’s personal information, and how it explains those rules to others. It also ensures that everyone who needs to follow the rules knows what to do. Without this, different teams may handle personal information in different ways, miss legal responsibilities, or fail to respond properly when circumstances change—raising the risk of complaints, regulatory action, and harm to individuals.

The organisation must create and document a policy at organisation level or business-process level that covers: why personal information is processed, what it covers, who is responsible for what, leadership commitment, how different parts of the organisation work together, and how compliance will be achieved. This policy must also be aligned with all relevant laws and internal guidance.

A Privacy Officer must be formally appointed to develop, maintain, and share the policy and the supporting procedures with the Privacy Officer, the Chief Information Security Officer (CISO), information system owners, data stewards, and Legal and Compliance. The procedures must also be shared with Security Operations.

The policy must be reviewed and updated at least every year, and also after material audit findings, confirmed breaches, major system changes or changes to data flows, or changes to relevant requirements. The supporting procedures must be reviewed and updated on the same schedule and when the same triggers occur.

##### Governed PII processing & transparency policy pack with trigger reviews

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-level (or mission/business-process-level) **personal information (PII) processing and transparency policy** and **supporting procedures** that explain how the organisation follows the policy. The policy and procedures must have an identified owner, be shared with the relevant job roles, and be kept up to date through planned updates and updates triggered by specific events.

###### WHY (control requirement)
PT-1 requires that the organisation has **written policy and procedures** for PII processing and transparency (not just a restatement of other controls). The guidance also expects security and privacy teams to work together, with updates at least **annually** and after defined events (for example: audit findings, data breaches, changes to laws and regulations, and major changes to systems or data flows).

###### HOW (specific steps/approach)
1. **Appoint a Privacy Officer** as the named person responsible for managing the PII processing and transparency policy and procedures.
2. **Create an organisation-level policy pack** (a single source of truth) that includes: purpose, scope, roles and responsibilities, leadership commitment, coordination between security and privacy teams, the compliance approach, and alignment to relevant laws/standards/guidance.
3. **Create a set of procedures** that puts the policy into practice (how the organisation implements it day to day), including procedures for role-based execution (for example: Privacy Officer, Chief Information Security Officer (CISO), Information System Owners, Data Stewards, Security Operations, Legal/Compliance).
4. **Set dissemination lists**:
   - Share the **policy** with: Privacy Officer, CISO, Information System Owners, Data Stewards, Legal and Compliance.
   - Share the **procedures** with: Privacy Officer, CISO, Information System Owners, Data Stewards, Security Operations, Legal and Compliance.
5. **Set governance and change control** using a document management system with version control and an approval workflow involving the Privacy Officer, CISO, and Legal/Compliance (with input from Information System Owners/Data Stewards).
6. **Set review and update timing**:
   - Policy: review/update **annually** and after triggers including material assessment/audit findings, confirmed breaches, changes to applicable requirements (for example: ITAR/EAR/HIPAA/General Data Protection Regulation (GDPR)/Capability Maturity Model Integration (CMMC)/Network and Information Systems Directive 2 (NIS2)), and major system/data-flow changes.
   - Procedures: review/update **annually** and after triggers including material assessment/audit findings, confirmed breaches, changes to incident response or data handling processes, new or changed PII processing systems, and changes to applicable laws or guidance.
7. **Keep audit-ready evidence**: retain the latest approved versions, change logs, proof of sharing (for example: acknowledgements or distribution records), and the reason for each review/update trigger.

###### WHO (roles responsible)
- **Privacy Officer**: owner of the policy and procedures; manages development, updates, and sharing.
- **CISO**: supports collaboration with the security programme and provides approval input.
- **Legal and Compliance**: ensures legal and regulatory alignment and provides approval input.
- **Information System Owners and Data Stewards**: provide input about systems and data context and acknowledge that the documents have been shared.
- **Security Operations**: acknowledges that the procedures have been shared where operational execution is required.

###### Acceptance criteria
- An approved **organisation-level PII processing and transparency policy** exists and has been shared with the defined policy roles.
- Approved **PII processing and transparency procedures** exist and have been shared with the defined procedure roles (including Security Operations).
- A named **Privacy Officer** is documented as the official owner/manager of the policy and procedures.
- The policy is scheduled for **annual review** and includes documented triggers for updates outside the normal cycle; the procedures are similarly scheduled and triggered.
- Evidence exists for: version-controlled documents, the approval workflow, sharing/dissemination records, and a documented review/update process aligned to the specified triggers.

###### Actions Required for Compliance

- [ ] Appoint a Privacy Officer to be the official responsible for managing the processing of personal information and the transparency policy and procedures.
- [ ] Draft and get approval for an organisation-wide policy on how personal data is processed and how this is communicated, including the policy’s scope, responsibilities, coordination arrangements, compliance approach, and alignment with legal requirements.
- [ ] Create a set of procedures that puts the policy into practice and assigns specific execution steps to the Privacy Officer, Chief Information Security Officer (CISO), Information System Owners, Data Stewards, Security Operations, and Legal/Compliance.
- [ ] Publish the policy and procedures in a version-controlled repository and share them with the named policy and procedure roles, keeping records of when they were acknowledged or distributed for audit purposes.
- [ ] Set up a governance process for changes to policies and procedures. These changes must be reviewed by the Privacy Officer, the Chief Information Security Officer (CISO), and Legal/Compliance, with input from the system and data owners.
- [ ] Set a review timetable and define the conditions that allow out-of-cycle updates (audit findings, confirmed security breach, legal or regulatory changes, and major system or data-flow changes) for both policy and procedures.
- [ ] Keep audit-ready records showing approvals, how information was shared, and the results of the most recent annual review.


---

### PT-2 — Authority to Process Personally Identifiable Information (Control)

This requirement is about making sure the organisation only uses people’s personal information for clearly approved reasons, and can show evidence of those reasons. Without this, staff might use personal details for the wrong purpose, share them with the wrong organisations, or keep and dispose of them in ways that break privacy rules and contracts—creating legal risk and real harm to individuals.

To meet this expectation, for every system that handles personal information, the organisation must identify, document, and keep up to date:
- the approved privacy notice for that system, and
- the official record that authorises what the system is allowed to do with the information, including collecting, using, storing, maintaining, sharing, disclosing, and disposing of it for programme and compliance purposes.

The organisation must also limit day-to-day use of the information to only the specific purposes stated in these documents and any approved contracts or information-sharing agreements. Finally, it must ensure staff are trained, monitored, and checked so unauthorised use is detected and corrected.

##### PII authority register and purpose-restricted processing enforcement

- Category: Software
- Priority: Critical

###### WHAT must be done
For every information system that handles personal data that can identify an individual (personally identifiable information (PII)), the organisation must set up and keep **documented approval** for that processing (for example, an approved privacy notice and System of Records Notice (SORN), plus any approved contracts/information-sharing agreements). The organisation must also make sure that **PII is actually processed only for the approved reasons** throughout the PII life cycle.

###### WHY (control requirement)
Control PT-2 requires that the organisation has approval to process PII and that staff and systems process PII **only for approved reasons**. This means ensuring that processing activities (creating/collecting/using/storing/maintaining/sharing/disclosing/destroying, and also logging/analysing/transforming) match the approved approval records. It also means staff must be trained and monitoring/auditing must be in place to prevent processing that is not approved.

###### HOW (specific steps/approach)
1. **Create a system-to-approval register** (the “PII Processing Authority Register”) that links each system that processes PII (including key data stores and integration points) to:
   - the approved **privacy notice** and **SORN** approval, and
   - any approved **contracts / information-sharing agreements** that govern sharing/disclosure.
2. For each linked system, **document the approved processing boundaries** in a structured way:
   - which PII life cycle activities are allowed (for example, collection, use, storage, maintenance, dissemination, disclosure, disposal), and
   - the **approved reasons** (restricted to the reasons stated in the privacy notice/SORN and approved agreements).
3. **Standardise the reasons** using a controlled list, and require that every processing step (workflow/export/share event) is tagged with one of the approved reasons from the register.
4. **Apply the “approved reason only” rule in the application/data layer**:
   - use purpose-aware access controls (for example, attribute-based access control or mapping roles to approved reasons) so users can only access PII for approved reasons;
   - put export/disclosure controls in place so sharing endpoints require an approved reason to be selected and linked to the relevant approval record;
   - ensure logs record the approved reason, who requested it, the dataset, and the destination/recipient so it can be audited.
5. **Put training and monitoring into day-to-day operations**:
   - train application users and administrators on the approved reasons and what counts as unauthorised processing;
   - set up monitoring/auditing to detect processing events that do not have an approved reason tag or that fall outside the register (for example, exports to unapproved destinations, reports produced for non-approved reasons), and trigger review/response.
6. **Keep approvals up to date** by versioning the register and setting a change trigger so updates to privacy notices/SORNs/contracts flow through to the application enforcement settings and reason mappings.

###### WHO (role responsible)
- **Privacy Officer / Data Protection Lead**: owns the approval mapping (privacy notice/SORN) and the approved reasons.
- **Application Owner / Product Owner**: ensures the application enforces the “approved reason only” rule and that workflows are tagged with the approved reason.
- **Security Engineering / Identity and Access Management (IAM) Lead**: implements purpose-aware access control and audit logging.
- **Compliance / Governance**: checks that the register is complete and that there is evidence for audits.

###### Acceptance criteria
- For 100% of PII-processing systems in scope, there is a current entry in the PII Processing Authority Register linking the system to the approved privacy notice/SORN and any relevant contracts/information-sharing agreements.
- For each system, the approved reasons and permitted life cycle activities are documented and linked to the controlled list of reasons.
- The application/data layer blocks PII access/export/sharing unless the request is linked to an approved reason from the register.
- Audit logs include, at minimum: user/service identity, system, PII dataset, reason tag, operation type (for example, export/share/transform), and destination/recipient where applicable.
- Monitoring alerts are raised for processing events that are missing reason tags or that attempt processing outside the approved scope.
- Evidence is available that relevant staff have been trained on approved PII processing reasons and on escalation/response steps.

###### Actions Required for Compliance

- [ ] Create and keep up to date a register of personal information processing authorities that links each system that processes personal information to the approved privacy notice or system of records notice (SORN), and to any approved contracts or information-sharing agreements.
- [ ] Define a controlled list of authorised purposes and record, for each system, which personal information (PII) handling actions are allowed in the register.
- [ ] Add purpose tags to every processing event involving personal data (access, export, sharing, transformation, and report generation) in the application workflow.
- [ ] Use the register as the single source of truth to restrict who can access and share information in the application and data layers, based on the specific purpose for which it is authorised.
- [ ] Set up audit logs to record, for every personal data (PII) processing event, who was involved (identity), which system was used, which personal data set (PII dataset) was accessed, the purpose tag, the type of action (operation type), and where the data was sent (destination/recipient).
- [ ] Set up monitoring rules to alert when purpose tags are missing or invalid, or when processing happens outside the authorised scope, and send these alerts to the privacy and security review process.
- [ ] Set up a change-management trigger so that when privacy notices, service of notices (SORNs), or contracts are updated, the system automatically updates the purpose mappings and the enforcement settings.


---

#### PT-2.1 — Data Tagging (Enhancement)

This requirement is about making sure sensitive personal information has clear instructions on what it is allowed to be used for. Without this, staff or systems could accidentally collect, store, process, share, or delete people’s details in ways that were not approved. This increases the risk of privacy breaches, misuse, and regulatory problems.

To meet this expectation, the organisation must define and document tagging rules for specific types of personal data (name, contact details, government identifiers, biometric data, and protected health information). Each tag must state the only permitted actions: collection, storage, processing, sharing, and deletion. These actions must be limited to what has been authorised for Confidential and Secret data.

The organisation must also:
- assign named responsibilities
- provide practical ways to apply the tags
- monitor that tags are in place and being followed, keeping evidence such as extracts of tagged data
- maintain a privacy plan and related records
- link tagging to the organisation’s approval decisions
- investigate and correct any cases where tagged information is handled outside the permitted scope

##### Apply authorisation-bound data tags to required PII elements

- Category: Software
- Priority: Critical

###### WHAT
Set up data tagging so that every defined element of personally identifiable information (PII) is automatically labelled with data tags that show **authorised processing**. The tags must record the allowed actions (**collection, storage, processing, sharing, deletion**) and limit them to what is authorised for **Confidential and Secret** data.

###### WHY (control requirement)
NIST SP 800-53 PT-2(1) (Enhancement) requires: **“Attach data tags containing {{ param, pt-02.01_odp.01 }} to {{ param, pt-02.01_odp.02 }}.”**
- `pt-02.01_odp.01` = **authorised processing** (authorised processing of PII is defined; only as authorised for Confidential and Secret data)
- `pt-02.01_odp.02` = **elements of PII to be tagged** (name, contact details, government identifiers, biometric data, and PHI)

###### HOW (specific approach)
###### 1) Define the tag structure and authorisation rules (policy-as-code)
- Create a controlled set of tags where each tag includes:
  - **PII element type** (from: name, contact details, government identifiers, biometric data, PHI)
  - **authorised processing** values limited to: collection, storage, processing, sharing, deletion
  - **authorisation scope** explicitly limited to **Confidential and Secret**
- Keep tag definitions versioned and link them to the organisation’s approval decision for Confidential/Secret authorisations, so the tag content can be traced.

###### 2) Apply tags when data enters the system and when it is stored
- Add tagging to the application’s data entry and ingestion routes (user forms, application programming interfaces (APIs), batch imports, and extract, transform, load (ETL) jobs) so that:
  - the PII element type is identified for each field or attribute
  - the matching tag information is attached to the stored record, column, or object
- Ensure tags remain with the data during changes (ETL and streaming processing) by carrying the tag information alongside the data.

###### 3) Block or allow actions based on the tags
- Put in place enforcement so that each of the five actions is allowed only when the data has the correct tag scope:
  - **collection**: block or route unauthorised collection attempts (for example, reject or quarantine requests that try to collect PII without the required tag information)
  - **storage**: stop untagged or incorrectly scoped PII being saved in storage areas not authorised for Confidential/Secret
  - **processing**: limit processing jobs and services to those permitted for the tag scope
  - **sharing**: restrict where data can be sent and require approval/workflow when the tag scope allows sharing
  - **deletion**: apply tag-driven retention and deletion rules and confirm deletion is completed

###### 4) Produce audit evidence (data extracts showing the tags)
- Add scheduled checks that:
  - list stored items containing the defined PII elements
  - confirm the correct tag information is present and matches the authorised processing scope
  - produce **audit-ready extracts** showing PII elements alongside their tags

###### WHO
- **Data Protection Officer / Privacy Lead**: owns the tag set and the authorisation mapping for Confidential/Secret.
- **Application Owner / Engineering Lead**: implements tagging at data entry and storage, and ensures tags carry through the data pipelines.
- **Security Engineering / Platform Team**: implements the enforcement points (access, processing, sharing, deletion controls) and supports evidence generation.

###### Acceptance criteria
- For each required PII element (name, contact details, government identifiers, biometric data, PHI), the system attaches tags that record authorised processing limited to **collection, storage, processing, sharing, deletion** and scoped to **Confidential/Secret**.
- Enforcement is demonstrable: unauthorised attempts to collect, store, process, share, or delete PII without the correct tag scope are blocked, routed to an approval/quarantine workflow, or denied.
- Audit evidence exists: automated extracts show PII elements and their corresponding tags for a representative sample and for each environment (at least production and one non-production environment).
- Tag definitions are versioned and traceable to the organisation’s Confidential/Secret authorisation decisions.

###### Actions Required for Compliance

- [ ] Create a tagging system with versions for each type of personal information (name, contact details, government identifiers, biometric data, and protected health information). Limit authorised processing to collecting, storing, processing, sharing, and deleting this information for data classified as **Confidential** or **Secret**.
- [ ] Match each tag to the organisation’s approval decision for authorisations marked **Confidential** or **Secret**, and record the traceability reference.
- [ ] Set up instrumented ingestion for instrument applications (user interface, application programming interface, batch processing, and extract-transform-load (ETL)) to detect personal data (PII) fields and attach the correct tag information when writing the data.
- [ ] Ensure tag information is carried through any data transformations and is saved together with the data when it is stored at rest.
- [ ] Use tags to control enforcement for collecting, storing, processing, sharing, and deleting data. If the tag coverage is missing or incorrect, block the action or send it for approval or quarantine.
- [ ] Add automated checks to confirm that stored personal data (PII) has the required tags and that those tags are correct. Also generate audit-ready data extracts that list each PII element alongside its corresponding tag.


---

#### PT-2.2 — Automation (Enhancement)

This requirement is about using smart, automated checks to ensure people handle personal information only in approved ways, and to quickly identify any mistakes or misuse. Without these controls, staff could accidentally (or improperly) view, change, or share personal details they are not authorised to use. It could also lead the organisation to process personal information in ways that breach its own privacy commitments, which could cause legal, reputational, and financial harm.

To meet this expectation, the organisation must clearly define how authorised handling of personal information will be enforced using automated rules. This includes automatically recognising and labelling personal data, automatically allowing or blocking access based on approved permissions, and continuously monitoring activity to spot when actions do not match the approved rules. If non-approved behaviour is detected, the system must raise alerts. The organisation must also be able to demonstrate that these automated actions follow the documented authorisation decisions, including named responsible people, up-to-date privacy and processing documentation, and evidence that alerts are investigated and acted on.

##### Automated PII enforcement via policy-based access, tagging, and alerts

- Category: Software
- Priority: Critical

###### WHAT
Put in place automated controls to ensure personally identifiable information (PII) is only processed in ways that are authorised. This will use: (1) automated recognition and labelling of PII, (2) automated access checks based on agreed policies, and (3) ongoing monitoring with automated alerts when processing does not match authorisation.

###### WHY (control requirement)
PT-2(2) requires the organisation to “manage enforcement of the authorised processing of personally identifiable information using {{ insert: param, pt-02.02_odp }}.” The guidance says that “automated mechanisms strengthen assurance that only authorised processing is taking place.”

###### HOW (specific steps/approach)
1. **Set the authorised PII processing rules** in a form that computers can enforce (policy-as-code): link business purposes and roles to allowed PII actions (for example, view/search/export/update/delete) and clearly state what is not allowed (for example, bulk export, or access for an unauthorised purpose).
2. **Automatically identify and label PII** when data is received and/or when it is queried, using consistent patterns and/or approved classification tools. Make sure labels are saved where possible, or are available to the enforcement step (for example, as application metadata and/or database columns/labels).
3. **Automatically enforce authorisation at the moment of access**: connect the policy checks to the application/application programming interface (API) and the data access layer, so every request that involves labelled PII is checked against the authorised rules (including item-level or field-level decisions where supported). If authorisation cannot be confirmed, **deny by default**.
4. **Continuously monitor PII processing** by recording audit information for all actions involving PII (reading, searching, exporting, API calls, and administrative overrides), including: who made the request (user or service), the request context (purpose, tenant/workflow), the PII label/category, the type of operation, and the result (allowed/denied).
5. **Create alerts for deviations**: set up automated alerts for policy breaches (for example, exporting labelled PII without permission, accessing data for an unapproved purpose, repeated denied attempts, or attempts to access unlabelled/unknown PII fields that should be labelled). Send alerts to the responsible team and include the policy rule identifier and the information needed to investigate.
6. **Keep a clear, auditable link to authorisation**: record the policy rule identifier/version and the basis for the authorisation decision (for example, the approved role/purpose mapping reference) in the audit trail, so enforcement can be shown to match documented authorisation.
7. **Test and confirm the controls work**: run automated tests using both authorised and unauthorised identities to prove that enforcement blocks unauthorised PII processing and that alerts are raised with the correct details.

###### WHO (role responsible)
- **Application Security Architect / Security Engineering Lead**: owns the policy design, enforcement integration, and monitoring/alert logic.
- **Application Owner / Engineering Manager**: implements the required logging and enforcement points in the application/API and data access paths.
- **Identity and Access Management (IAM) Team**: ensures identity details and authorisation context needed by the policy checks are available and reliable.
- **Security Operations Centre (SOC) / Security Operations**: owns the alert review process and the collection of evidence for investigations.

###### Acceptance criteria
- The system automatically labels/classifies PII and makes the PII labels available to the enforcement decision process.
- For every PII-related operation, the application/API applies an allow/deny decision based on the authorised rules that can be enforced by machine; unauthorised processing is denied by default.
- Audit logs record, for each PII operation: the identity, operation type, PII label/category, policy rule identifier/version, and the enforcement outcome.
- Automated alerts are generated for the defined deviation scenarios and include enough information to investigate (identity, operation, PII label/category, and policy rule identifier).
- Evidence exists (test results and sample audit/alert records) showing that authorised processing is permitted, unauthorised processing is blocked, and alerts are triggered correctly.

###### Actions Required for Compliance

- [ ] Define machine-enforced rules for authorised processing of personal data (role and purpose → which actions are allowed), using a deny-by-default approach, as policy-as-code.
- [ ] Set up automated personal data (PII) tagging and classification when data is received and/or when it is searched, and carry those tags through to the enforcement layer so they can be applied there.
- [ ] Add a policy decision step into the application programming interface (API) and data access routes to enforce “allow” or “deny” decisions for each personal identifiable information (PII) tag and each operation.
- [ ] Set up and centrally store audit logs for all actions that involve personal information (PII), recording the user identity, the situation or context, the PII tag or category, the applicable policy rule ID and version, and the final decision or outcome.
- [ ] Set up continuous monitoring to detect defined deviations (for example, unauthorised data exports, using the data for the wrong purpose, or repeated denied access attempts) and automatically send alerts when they occur.
- [ ] Set up an alert triage process that collects the required supporting evidence, and send each alert to the responsible security operations centre (SOC) or application security queue.
- [ ] Run automated test cases using both authorised and unauthorised identities to confirm that access rules are enforced correctly and that alerts are accurate.


---

### PT-3 — Personally Identifiable Information Processing Purposes (Control)

This expectation is about making sure the organisation is clear about why it collects and uses people’s personal information, and that it uses that information only for those stated reasons. Without this, personal data could be used for the wrong purpose, shared or kept for longer than intended, or altered in ways that people do not expect—leading to legal, reputational, and financial harm.

The organisation must identify and record the specific reasons it processes personal information, including identity checks, decisions about eligibility, administering benefits, security monitoring, and responding to incidents. It must explain these reasons in its public privacy notices and in its internal policies.

The organisation must also ensure that every step of handling personal information—from collecting it, using it, storing it, sharing it, maintaining it, and finally disposing of it—matches the recorded reasons.

The organisation must keep track of any changes in how personal information is processed. If new or changed reasons are introduced, it must update its privacy assessments and records, get legal agreement, send the change through formal approval by the senior privacy lead, and only then update the public notices and related records.

##### PII purpose register with enforced purpose-scoped access and change approvals

- Category: Software
- Priority: Critical

###### WHAT
Create and keep up to date an authoritative, version-controlled **Personal Information (PII) Processing Purposes Register**. This register must list the organisation’s approved reasons for using personal information (including **identity verification, eligibility decisions, benefits administration, security monitoring, and incident response**) across the full life cycle: collecting/creating it, using it, storing it, maintaining it, sharing it, disclosing it, and finally deleting or disposing of it. Publish the same purpose descriptions in **privacy notices**, and make sure internal privacy documents use the same wording.

Put in place operational controls so personal information is processed **only for approved purposes**. This means using **purpose-specific access and data-flow controls**, so systems cannot use personal information for an unapproved purpose unless a change is formally approved. Monitor for changes in how personal information is being used, and require a documented **privacy compatibility review** with legal agreement and senior privacy approval before updating privacy notices and records.

###### WHY (control requirement)
PT-3 requires the organisation to **identify and document the purpose(s)** for processing personal information, covering the full life cycle, and to **describe those purposes in privacy notices and other privacy compliance documents**. It also requires steps to ensure personal information is processed **only for those identified purposes**, including **training** and **monitoring/auditing**. The organisation must also **monitor for changes** in processing purposes, carry out a compatibility review, and put in place mechanisms (for example, updated notices/records and consent where needed) when new purposes are introduced.

###### HOW (specific steps/approach)
1. **Create the PII Processing Purposes Register (single source of truth):**
   - Include the five required purposes, and for each one record: the personal information items involved, the systems/processes involved, and the life-cycle steps (collection/use/storage/maintenance/dissemination/disclosure/disposal).
   - Record the owner, the date of the last review, and a link to the evidence showing where this purpose appears in the privacy notice and internal privacy documentation.
2. **Publish purpose text consistently:**
   - Use a controlled content process so the **public privacy notice** sections are produced from the register (or are tightly checked against it).
   - Ensure internal privacy policies and assessments reference the same purpose wording and scope.
3. **Enforce purpose limits in day-to-day operations (IT-led, with operational adjustments where needed):**
   - Mark personal information records/fields and/or access requests with an approved **purpose identifier** (for example, using access attributes or purpose context within the application).
   - Set access rules so users and services can access personal information only when the request purpose matches the register (for example, eligibility decision roles cannot query personal information for security monitoring).
   - Limit exports and disclosures (application programming interface responses, reports, message publishing, and data platform ingestion) to destinations and purposes that match the register. Any exceptions must go through an approval process.
4. **Match retention and disposal to the purpose:**
   - Configure data retention and deletion rules so personal information is deleted, archived, or made unreadable once the purpose is fulfilled or the retention period ends. Ensure backups and copies follow the same intended life cycle.
5. **Monitor and audit for “purpose drift”:**
   - Use existing logging and **security information and event management (SIEM)** to detect and alert on: access to personal information outside approved purpose contexts, unusual query patterns, repeated exports, and retention-related anomalies.
   - Periodically compare audit evidence against the register (for example, quarterly checks of access logs that include purpose tags).
6. **Manage changes to processing purposes:**
   - When new purposes are proposed (or when monitoring shows drift), complete a documented **privacy compatibility review**.
   - Get **legal counsel concurrence** and route the change through formal change control for approval by the **senior privacy official**.
   - Update the register, privacy impact assessment/records, and public privacy notices before the new purpose is used.

###### WHO (roles responsible)
- **Privacy Officer / Senior Agency Official for Privacy (or equivalent):** owns the register, approves changes to purposes, and confirms the compatibility outcomes.
- **Legal Counsel:** provides agreement for new or changed purposes.
- **Application Owner / Data Protection Lead:** ensures purpose marking and enforcement are implemented at application level.
- **Identity and Access Management (IAM) / Platform Security Engineer:** implements purpose-specific access and logging connections.
- **SIEM/Monitoring Team:** sets up detection rules and periodic audit reporting.

###### Acceptance criteria
- A complete **PII Processing Purposes Register** exists and includes all five purposes, with coverage across the full life cycle and the relevant systems/processes.
- Public privacy notices and internal privacy documentation use the **same purpose wording and scope** as the register (versioned and traceable).
- The application enforces purpose limits so access, export, and disclosure of personal information is blocked or requires approval when the purpose context does not match the register.
- Retention and disposal behaviour for personal information matches the documented purposes (including backups and copies according to the intended life cycle).
- Monitoring and audit evidence shows that purpose drift is detected and that periodic reviews take place.
- For any new or changed purpose, there is documented privacy compatibility review evidence, legal agreement, senior privacy approval, and updated notices/records before implementation.

###### Actions Required for Compliance

- [ ] Create and keep up to date a version-controlled register of personal information processing purposes, covering all five purposes and the full life cycle of the personal information.
- [ ] Set up a controlled process to publish the “purpose” text consistently in public privacy notices and internal privacy documents.
- [ ] Add purpose identifiers (tags or attributes) to personal data (PII) access requests and data-flow requests, and enforce authorisation based on the stated purpose (deny the request or require approval if the purpose does not match).
- [ ] Set retention and disposal rules so that the way personal data is kept and deleted matches the documented reasons for using it, including the intended lifecycle for backups and replicas.
- [ ] Link application logs to security information and event management (SIEM) to detect and alert on any access, export, or disclosure of personal information (PII) outside the approved purposes.
- [ ] Set up a documented change process that (1) checks whether the change is compatible with privacy requirements, (2) gets agreement from the legal team, and (3) routes the update for approval from senior privacy staff before updating notices and records.


---

#### PT-3.1 — Data Tagging (Enhancement)

This requirement is about making sure that sensitive personal information has a clear label explaining why it is allowed to be used. Without these labels, the organisation could accidentally use people’s details for the wrong purpose, fail to meet legal and contractual obligations, or lose track of how information is handled as it moves between systems. This increases the risk of misuse, non-compliance, and privacy harm.

To meet this expectation, the organisation must:
- Identify which data fields are covered, including direct identifiers (name and Social Security Number (SSN)), contact details (email and phone), and protected health information.
- Define a standard set of allowed purpose labels.
- Document how the labels are used and keep a clear structure for them.
- Ensure the labels remain attached to the information as it moves through the system, so that anyone reviewing a change can confirm it matches the documented purposes.

The organisation must also include this approach in its privacy plan, assign named responsibilities for applying the labels and providing transparency, and keep evidence (for example, data extracts) showing the labelled fields together with their purpose labels.

##### Purpose-tagging for in-scope PII fields across data flows

- Category: Software
- Priority: Critical

###### WHAT
Add data tags to the organisation-defined **elements of personally identifiable information** so that each tagged element includes the organisation-defined **reasons for processing** (PT-03.01 ODP.01 and PT-03.01 ODP.02). Make sure the tags stay visible as the data moves through the system.

###### WHY (control requirement)
PT-3(1) requires that data tags include the specified reasons and are attached to the specified personally identifiable information (PII) elements: **“Attach data tags containing the following purposes to {{ param, pt-03.01_odp.02 }}: {{ param, pt-03.01_odp.01 }}.”** The goal is to track the reasons for processing by carrying the reason information with the relevant PII elements throughout the system.

###### HOW (specific approach)
Create a standard “purpose tag” metadata structure and enforce it in the application and data layers, so tags are added when data is first received and then kept through any changes and across internal system-to-system and application programming interface (API)/message flows.

1. **Define the allowed purpose values** as a fixed list that matches the organisation-defined PT-03.01 ODP.01 (for example: authorised processing for healthcare operations (HIPAA), security monitoring, and compliance with ITAR/EAR/CMMC/NIS2). Version the list (for example, `purposeTag.v1`) to support audit checks.
2. **Define the in-scope PII elements** that match PT-03.01 ODP.02 (for example: direct identifiers such as name/SSN, contact details such as email/phone, and protected health information fields). Create a field-by-field mapping showing which attributes must have tags.
3. **Create a purpose-tag schema** that links each in-scope PII element to one or more allowed purpose values (for example: per-field metadata stored with the record and included in events). Ensure the same structure is used in both storage and messaging.
4. **Attach tags at the source**: when records are created or received (API request handling, ETL/ELT ingestion, or user interface submission), the application/service must add purpose tags for every in-scope PII field. If tags are missing or contain values not on the allowed list, the request/pipeline must be rejected (fail closed) or sent to a controlled remediation process.
5. **Preserve tags during processing**: ensure data mapping and transformations copy/merge purpose-tag metadata in a consistent, predictable way when records are normalised, enriched, tokenised, or used to create downstream datasets. For event-driven flows, include the purpose-tag metadata in the event content or message headers so it travels with the data.
6. **Provide audit evidence**: produce audit-ready extracts from the standard (canonical) store showing (a) the tagged PII fields and (b) the associated purpose tags, and keep these extracts as evidence for compliance review.

###### WHO (roles responsible)
- **Data Protection Officer / Privacy Lead**: owns the purpose values and approves how purposes are mapped to processing contexts.
- **Application Owner / Engineering Lead**: implements the purpose-tag schema, enforces tagging during ingestion, and ensures tags are preserved in the application/data pipelines.
- **Data Governance / Data Steward**: maintains the field-level mapping for PT-03.01 ODP.02 and ensures schema version control.
- **Security/Compliance Assurance**: checks the evidence extracts and confirms fail-closed behaviour for missing or invalid tags.

###### Acceptance criteria
- For every in-scope PII element defined in PT-03.01 ODP.02, the system produces and/or retains purpose tags containing only values from PT-03.01 ODP.01.
- Purpose-tag metadata is present in at least one standard (canonical) storage form and is included with downstream events/application programming interface (API) responses, so it remains visible as data moves through the system.
- Ingestion/processing fails closed (or is handled through a controlled remediation process) when tags are missing or contain unauthorised purpose values.
- Evidence extracts can be produced showing tagged PII fields together with their purpose tags for a representative sample of records across environments (for example, production and test).

###### Actions Required for Compliance

- [ ] List and assign versions to the permitted “processing purpose” values from `pt-03.01_odp.01`.
- [ ] Create a field-by-field mapping for all in-scope personal data (PII) elements from `pt-03.01_odp.02`.
- [ ] Set up a purpose-tag system that links every in-scope personal data (PII) field to the permitted purpose values.
- [ ] Ensure that, when data is received, the system only allows purpose tags to be added for all in-scope personal data (PII) fields, and blocks the data if the purpose tags cannot be populated.
- [ ] Update all data transformations and all event, application programming interface (API), and messaging payloads so that the purpose-tag metadata is kept with the data.
- [ ] Create and keep audit-ready records that show which personal data (PII) fields are tagged, along with the purpose tags linked to each field.


---

#### PT-3.2 — Automation (Enhancement)

This requirement is about automatically keeping an accurate, up-to-date record of where personal information is stored in your internal systems, and why it is allowed to be used. Without this, the organisation could lose track of which datasets contain people’s details, record an incorrect reason for using them, or be unable to show regulators and customers that personal information is handled transparently and only for approved purposes.

To meet this expectation, the organisation must use automated tools to scan its internal data catalogue, automatically identify any items that contain personal information, and then automatically link each identified item to the authorised reason for processing it, using the organisation’s own rules for matching purposes to policies. The organisation must be able to produce evidence exports showing the personal-information identifications and the linked reasons, keep a privacy plan and supporting documents explaining how those reasons are handled, and ensure that the right people are responsible for oversight and enforcement based on these automated records.

##### Automate PII purpose tracking via catalogue discovery and mapping

- Category: Software
- Priority: Critical

###### WHAT
Set up automated mechanisms to: (1) find personal data (personally identifiable information (PII)) in the organisation’s on-premises data catalogue, (2) automatically label the found PII at the right level (dataset/table and, where possible, column/field), and (3) automatically record the reason (processing purpose) for using each labelled PII item, using the organisation’s rules that link purposes to policies.

###### WHY (control requirement)
PT-3(2) (Automation) requires tracking the processing purposes of PII using the organisation-defined parameter **pt-03.02_odp** (“automated mechanisms”). The guidance says automated mechanisms improve how processing purposes are tracked. So, the processing purpose information must be created and kept up to date by automated discovery and labelling, plus automated purpose mapping—not only by manual records.

###### HOW (specific steps/approach)
1. **Set up an authoritative on-prem data catalogue** as the single source of truth for data inventory and metadata (including dataset/table details and, where feasible, how data flows from source to destination).
2. **Define a set of processing purposes and the rules that map them to policies** (using “policy-as-code” style rules where possible). These rules should link PII signals (for example: PII type, data area/system, and/or schema attributes) to an authorised **processing purpose**.
3. **Configure automated discovery jobs** to scan catalogue-linked sources (on-premises databases, data warehouses, extract-transform-load (ETL) landing zones, and other on-premises repositories included in the catalogue) on a schedule and when changes occur.
4. **Turn on automated PII classification and metadata labelling** so that discovered PII is labelled in a consistent way (for example, based on column name patterns) and/or using statistical checks (profiling thresholds). Store the labels in the catalogue.
5. **Implement automated purpose mapping** so the catalogue fills in a **processing purpose** for every PII-labelled dataset/field based on the mapping rules, including the rule version and an “as-of” date/time.
6. **Add automated re-labelling and re-mapping triggers** when schemas, extract-transform-load (ETL) outputs, or data ownership changes, so purpose tracking stays aligned with the purpose-to-policy rules.
7. **Produce audit-ready evidence exports** from the catalogue that include: asset identifiers (dataset/table/field), PII labels, mapped processing purpose(s), mapping rule version, and an as-of/snapshot time.
8. **Add integration points for enforcement** so other controls can use the catalogue’s processing purpose information (for example, data loss prevention (DLP), access governance, or workflow approvals that require purpose alignment).

###### WHO
- **Data Governance Lead / Data Protection Officer (DPO)**: owns the processing purpose set and the purpose-to-policy mapping rules.
- **Data Platform Engineer / Catalogue Administrator**: sets up discovery, labelling, mapping configuration, and evidence export automation.
- **Security/Privacy Engineering**: checks the accuracy of classification, the logic of the rules, and whether the evidence is suitable for audits.

###### Acceptance criteria
- The on-premises data catalogue holds an automated, saved record of **PII labels** and the corresponding **processing purpose** for every discovered PII asset.
- Processing purpose mapping is produced by automated mechanisms using the organisation’s purpose-to-policy mapping rules (including rule version and as-of timestamp).
- Evidence exports can be generated when needed (or on a schedule) showing PII labels + mapped processing purposes + snapshot time.
- When a source schema/dataset changes, automated re-discovery, re-labelling, and re-mapping happens within the agreed operational window, and the catalogue shows the updated processing purposes.
- Downstream enforcement systems can retrieve the processing purpose attribute for policy enforcement (where applicable in the environment).

###### Actions Required for Compliance

- [ ] Choose and set up an approved on-premises data catalogue to act as the official source of record for whether personal data (PII) is present and what it is used for.
- [ ] Define the purpose taxonomy and set up rules that link each personal data (PII) tag to the authorised processing purposes in the policy.
- [ ] Set up automated discovery jobs that run on a schedule and also when changes are detected, for every on-premises source listed in the catalogue.
- [ ] Set up automated personal data (PII) identification and store the personal data (PII) labels as metadata in the data catalogue at the dataset and/or table level and, where needed, at the column and field level.
- [ ] Set up automated purpose mapping to assign a processing purpose to every asset that contains personal data (PII), including the rule version and the date/time the mapping was last updated (as-of timestamp).
- [ ] Create automated evidence export reports that include asset identifiers, personal data (PII) tags, the mapped purposes, the mapping rule version, and the snapshot time.
- [ ] Where needed, link the catalogue’s purpose information to the systems that enforce it downstream (for example, access governance, data loss prevention, and workflow approval tools).


---

### PT-4 — Consent (Control)

This requirement is about making sure people are clearly and personally asked for permission before their information is collected and used. Without a proper consent process, people may agree without realising it, or may not understand how their personal details will be handled. They may also find it difficult to change their mind later. This creates risks for both the organisation and the individual, including legal, reputational, and personal harm.

To meet this expectation, the organisation must provide an online consent portal that:

- shows the privacy notice before anyone can agree
- uses clear “opt-in” checkboxes that the person must actively tick
- explains in plain language what the person is agreeing to

Before consent is accepted, each person must be identified (for example using their Common Access Card (CAC), Personal Identity Verification (PIV), or an equivalent method). The organisation must also keep electronic records showing what was agreed and the date and time.

The portal must allow people to withdraw consent online, again after identity checks, and must record that withdrawal.

The organisation must document how it handles consent, keep the relevant records, and assign clear responsibilities for managing the process.

##### Identity-verified opt-in consent portal with revocation enforcement

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation-approved **tools or mechanisms** for PT-4 (parameter **pt-04_odp**): a **privacy notice consent portal** that collects **opt-in** consent before any collection or processing of an individual’s personally identifiable information (PII). Use **identity verification (Common Access Card (CAC)/Personal Identity Verification (PIV), or an equivalent method)**, and allow people to give, withdraw, and manage consent electronically, with **evidence that can be checked later**.

###### WHY (control requirement)
PT-4 requires implementing the specified **tools or mechanisms** so people can **consent before any collection** happens, supporting informed decision-making. The guidance also requires that the privacy notice is shown, an appropriate consent method is used (for example, **opt-in**), consent is captured electronically, identity is verified, there is a way to **withdraw consent**, and the privacy notice uses **plain language** so people understand the risks they are agreeing to.

###### HOW (specific steps/approach)
1. **Build or enable a consent portal** that shows the **privacy notice first** (plain language; no technical terms), and then provides **opt-in checkboxes** for each consent purpose or scope.
2. **Require identity verification before consent can be submitted** using **Common Access Card (CAC)/Personal Identity Verification (PIV) (or an equivalent method)** through the organisation’s identity provider. Do not allow consent submission unless authentication is successful.
3. **Record and store electronic proof of consent** at the time consent is given: user identifier, identity assurance level, consent purpose(s), time and date (timestamp), and the **version** of the privacy notice that was shown.
4. **Set up a consent withdrawal (revocation) process**: require identity verification, show what the person previously agreed to (including the privacy notice version and purpose), record the withdrawal time and date (timestamp) and evidence, and update the consent status.
5. **Ensure consent is checked before collection in the application and data process**: downstream services must confirm the consent status (for example, using an internal authorisation/claims token or a consent-status application programming interface (API)) before collecting or processing PII for the agreed purposes. If consent is missing or withdrawn, block collection for those purposes.
6. **Support auditability and retention**: keep an append-only audit trail of consent and withdrawal events, and keep records in line with the organisation’s evidence retention requirements.

###### WHO (role responsible)
- **Application Owner / Product Owner**: responsible for the portal user experience (UX), mapping consent purposes, and integrating enforcement.
- **Security Architect / Privacy Officer**: approves the privacy notice content (plain language and scope) and the consent approach.
- **Identity Engineer**: implements the Common Access Card (CAC)/Personal Identity Verification (PIV) (or equivalent) integration with the enterprise identity provider.
- **Backend/Data Engineering Lead**: implements consent-status checks and stores evidence.
- **Compliance/Assurance Lead**: checks that audit evidence and test results are valid.

###### Acceptance criteria
- A user cannot submit consent (or trigger PII collection for consented purposes) unless **identity verification succeeds**.
- The portal shows the **privacy notice before** any opt-in choice is recorded.
- Consent is **opt-in** (no pre-selected boxes), and consent evidence includes **purpose(s), timestamp, and privacy notice version**.
- Users can **withdraw consent electronically**; withdrawal is recorded with **timestamp and evidence**, and any later PII collection or processing for withdrawn purposes is blocked.
- Audit logs show clear traceability for consent and withdrawal events and are kept for assessment.

###### Actions Required for Compliance

- [ ] Design the consent portal so that it shows the privacy notice in plain language before any opt-in choice is recorded.
- [ ] Set up Common Access Card (CAC) / Personal Identity Verification (PIV) (or an equivalent) identity checks through the organisation’s identity provider (IdP), and stop consent submissions if the user cannot be authenticated successfully.
- [ ] Create a consent record store and an append-only audit log that records the consent purpose(s), the date and time, the user identifier, the identity assurance level, and the privacy notice version.
- [ ] Set up an electronic process to revoke access that first verifies the person’s identity, stores evidence showing the revocation was carried out, and updates the consent status.
- [ ] Add checks for consent status to every way personal data is collected and processed, so that data collection for approved purposes is blocked when consent is missing or has been withdrawn.
- [ ] Check and record how evidence is generated by running full end-to-end tests for: consent, enforcing “consent before data collection”, and revoking consent.


---

#### PT-4.1 — Tailored Consent (Enhancement)

This expectation is about giving people genuine, detailed control over how your organisation uses their personal information, rather than using a single approach for everyone. Without this, the organisation might use certain information in ways the person did not agree to, which increases privacy risk and could damage trust—leading people to stop using the service.

To meet this, the organisation must provide a clear, easy-to-use consent dashboard. Individuals must be able to turn permissions on or off for specific types of personal information, with plain explanations of what each option means. The organisation must then follow those choices consistently, including using different rules depending on staff roles. It must also use its internal decision rules to allow or block processing based on the person’s choices.

Whenever a person changes a setting, the organisation must record the change, including who made it, what was changed, what the new decision is, and the date and time. This makes the outcome transparent and traceable.

##### Granular consent dashboard with policy-engine enforcement and audit logs

- Category: Software
- Priority: Critical

###### WHAT
Set up consent options that let people choose what they allow the organisation to do with specific parts of their personal data. Then make sure those choices are followed in the organisation’s actual processing using a policy engine, with full audit records.

###### WHY (control requirement)
PT-4(1) enhancement requires: “Provide {{ insert: param, pt-04.01_odp }} to allow individuals to tailor processing permissions to selected elements of personally identifiable information.” The organisation-defined parameter **pt-04.01_odp (mechanisms)** specifies a **people-facing consent dashboard with detailed on/off controls for specific personal data elements**, **role-based enforcement using a policy engine**, and **audit logs showing changes to consent**.

###### HOW (specific steps/approach)
1. **Define personal data element toggles and mapping**: Create a controlled list of personal data elements used by the application (for example, email, phone, location, device identifiers). Link each element to the processing actions/purposes it enables.
2. **Build the consent model**: Store consent status for each user, for each personal data element (and, where relevant, for each purpose). Include versioning so that any changes to consent logic or policy can be traced.
3. **Deliver a user-facing consent dashboard**: Provide an authenticated privacy settings screen showing **detailed on/off toggles for each personal data element**, with clear, plain-language explanations of what on/off means for processing.
4. **Enforce via a policy engine (role-aware)**: Implement policy rules that check each processing request against the user’s consent status and the requester’s role (for example, employee/support versus marketing analyst). The rules must return an allow/deny decision to the application.
5. **Apply consent to processing**: Add enforcement points so that when a personal data element is set to OFF, the application **withholds/masks/substitutes** that element in outputs and stops any downstream processing that depends on it.
6. **Audit every consent change**: For each change, record an unchangeable audit event including: who made the change (user identity or authorised system), the time, the affected personal data element(s), and the consent state before and after. Send this to security information and event management (SIEM) and log retention systems for audit evidence.

###### WHO (role responsible)
- **Product/Privacy Owner**: approves the personal data element list, the wording on the toggles, and how consent maps to processing.
- **Application Owner / Engineering Lead**: builds the dashboard, the consent storage model, the enforcement integration, and updates processing behaviour.
- **Security/Compliance Lead**: checks that audit logging, retention, and evidence are sufficient.
- **Identity and Access Management (IAM) Team**: ensures the dashboard is linked to authenticated identities and that role information is available to the policy engine.

###### Acceptance criteria
- People can view and change consent using **detailed toggles for each personal data element** (not one single global consent switch).
- Consent changes affect application behaviour: OFF elements are **blocked/withheld/masked** in relevant processing and outputs.
- Enforcement is carried out by a **policy engine** that uses **role-based rules**.
- Every consent change creates an audit record showing **who changed what**, **when**, **which personal data elements changed**, and the **before/after** consent state. These logs are retained and available for audit.

###### Actions Required for Compliance

- [ ] Create a controlled list (catalogue) of application personal data (PII) elements, and link each element to the specific purposes and actions for processing it.
- [ ] Create a consent data model that records, for each user and each personal data (PII) element, whether consent is ON or OFF, and includes version history.
- [ ] Develop an authenticated consent dashboard with detailed on/off switches and clear, plain-language explanations for each personal information (PII) element.
- [ ] Set up policy rules that check each processing request using the current consent status and the requester’s role information.
- [ ] Set up enforcement controls so that any output or later processing does not show personal data (PII); instead, it is withheld, hidden (masked), or replaced.
- [ ] Set up tamper-resistant audit logs for every consent change, recording who made the change, when it happened, what was affected, and what the values were before and after. Then send these records to the security information and event management (SIEM) system.


---

#### PT-4.2 — Just-in-time Consent (Enhancement)

This requirement is about getting people’s permission at the exact moments their personal information is about to be used, and again when the reason for using it changes or when the use becomes more sensitive. Without this, an organisation could use people’s data in ways they did not expect, or increase privacy risk—for example by sharing it with partners, using automated profiling to make decisions, or accessing highly sensitive information—leaving people unable to make an informed choice.

To meet this expectation, the organisation must:
- show a clear consent prompt on its website;
- provide a privacy preference place where people can manage their choices; and
- give a timely on-screen notification that explains what is about to happen and lets people choose to opt in or opt out at the first relevant moment.

It must repeat these choices whenever the purpose changes or the privacy risk increases. This must be done specifically when:
- sharing with third parties,
- using profiling or automated decision-making, or
- accessing highly sensitive “Secret” information.

##### Event-driven consent gate with just-in-time prompts and enforcement

- Category: Software
- Priority: Critical

###### WHAT
Set up an event-driven “consent gate” that checks consent requirements at the moment personal data (personally identifiable information (PII)) first becomes relevant, and again whenever the reason for processing changes or the privacy risk level changes. The gate must show the right consent options (a web portal prompt and a just-in-time notification) and support a privacy preference centre, with opt-in/opt-out choices. It must enforce the individual’s choice so that processing only happens in line with what they decided.

###### WHY (control requirement)
PT-4(2) requires the organisation to **show the agreed consent options** to individuals **at the agreed times**, and **tied to the agreed types of PII processing**. The guidance also expects just-in-time consent to be given when it is most useful, because consent assumptions can be wrong if too much time has passed or if the processing creates a high privacy risk.

Specifically, the implementation must support:
- **consent mechanisms**: web portal consent prompt, privacy preference centre, and just-in-time notification with opt-in/opt-out (pt-04.02_odp.01)
- **frequency**: at first relevant processing, and whenever the purpose or risk level changes (pt-04.02_odp.02)
- **PII processing types**: sharing with third parties, profiling/automated decision-making, or access to Secret data (pt-04.02_odp.03)

###### HOW (specific steps/approach)
1. **Define a list of processing events** in the application’s domain model that the services starting PII processing can send. Include event types for:
   - first relevant processing
   - purpose change
   - privacy risk level change
   - third-party sharing
   - profiling/automated decision-making
   - Secret data access
2. **Create a consent policy mapping (policy-as-code)** that links each event type to the consent option(s) that must be shown and the required action (for example, block until opt-in is given, or allow only if opt-out has not been selected). This mapping must explicitly cover the three processing types in pt-04.02_odp.03.
3. **Build the consent gate as the main enforcement point** (for example, an application programming interface (API) gateway plug-in, service middleware, or an orchestration service) that stops processing requests before data is released to downstream systems (or before third-party calls, profiling engines, or Secret-data retrieval are carried out). The gate must:
   - check the individual’s current consent entitlements
   - decide whether a just-in-time consent prompt is needed based on pt-04.02_odp.02 frequency
   - require a fresh choice when purpose/risk changes or when the processing type matches pt-04.02_odp.03
4. **Add user interface (UI) and user experience (UX) for just-in-time consent**:
   - Show a **web portal consent prompt** with **opt-in/opt-out** when the gate requires a choice.
   - Display a **just-in-time notification** that explains the exact processing being triggered, and include a direct link to the **privacy preference centre**.
   - Ensure the privacy preference centre updates the same consent entitlements used by the consent gate.
5. **Record and evidence consent decisions**:
   - Store consent decisions with timestamps, the triggering event type, the purpose/risk context, and the individual identifier.
   - Produce audit logs for: (a) when the gate required consent, (b) what was shown, (c) the individual’s choice, and (d) whether processing continued or was blocked.
6. **Control what happens downstream**:
   - Downstream services that perform third-party sharing, profiling/automated decision-making, or Secret data access must call the consent gate (or check a consent token/entitlement issued by it) before they carry out the processing.

###### WHO (role responsible)
- **Application security architect / privacy engineering lead**: owns the event list, policy mapping, and enforcement design.
- **Software engineers (backend/API gateway/service middleware)**: implement the consent gate and the downstream enforcement checks.
- **Product/UX and privacy operations**: implement the web portal prompt, just-in-time notification content, and the privacy preference centre.
- **Security/compliance analyst**: checks audit evidence and test results against PT-4(2) expectations.

###### Acceptance criteria
- For each defined processing event type, the system presents the required consent options **at first relevant processing** and **whenever purpose or risk level changes**.
- For the processing types in pt-04.02_odp.03 (third-party sharing, profiling/automated decision-making, Secret data access), the system requires an opt-in/opt-out choice before processing proceeds (or follows the defined enforcement mapping).
- Updates made in the privacy preference centre are reflected immediately (or within an agreed, documented propagation window) in the consent gate decisions.
- Audit evidence exists showing: the event trigger, the consent prompt/notification shown, the recorded choice, and the processing outcome (allowed/blocked) for test scenarios.
- Penetration/abuse testing confirms that processing cannot bypass the consent gate for the covered event types.

###### Actions Required for Compliance

- [ ] Define and implement a clear set of categories for processing events, covering: first processing, changes in purpose, changes in risk, sharing with third parties, profiling and automated decision-making, and access to Secret data.
- [ ] Set up a “policy as code” consent mapping that decides when consent is needed and what enforcement action to take for each type of event.
- [ ] Set up an authoritative consent check (for example, an application programming interface (API) gateway, middleware, or orchestration layer) that stops processing requests before they reach the systems that carry out the work.
- [ ] Integrate web portal prompts that let people choose whether to receive messages (opt in or opt out), send notifications only when they are needed (just in time), and provide a privacy preference centre—using the same consent permissions for all three.
- [ ] Store consent decisions with the date and time and the related event details, and record audit logs showing how prompts and notifications were shown and handled, including the results of allow or block decisions.
- [ ] Update downstream services that share data with third parties, perform profiling or automated decision-making, or access Secret data so they must first validate consent before any action is carried out.


---

#### PT-4.3 — Revocation (Enhancement)

This requirement is about making it easy for people to withdraw permission for how their personal information is used. If withdrawing consent is difficult to find, confusing, or not properly checked, people may not be able to change their decision when their circumstances change. In that case, the organisation could keep using their information even though it no longer has valid permission.

To meet this expectation, the organisation must provide:
- a self-service consent withdrawal portal, and  
- an authenticated request process (a process that verifies the person making the request).

This must allow individuals to submit a withdrawal request, confirm they are the correct person before the request is accepted, and then track the request’s progress and result.

The organisation must treat these requests as consent withdrawals under its own consent withdrawal policies and procedures, follow the agreed design and user experience approach, and ensure the process matches its privacy plan and its transparency and information-handling procedures.

The organisation must also clearly assign named responsibilities for the portal, the user experience, and the privacy and information-handling parts of the process, and keep records showing how the withdrawal approach, policies, and user experience are implemented.

##### Authenticated self-service consent revocation portal with ticket workflow

- Category: Software
- Priority: Critical

###### WHAT
Set up the organisation’s defined **tools or processes** (pt-04.03_odp) so individuals can **withdraw consent** for the organisation’s **use of their personal information**. This should be done through an **easy-to-use self-service portal** and an **authenticated, auditable ticket (case) process** that supports **submitting a request and tracking progress**.

###### WHY (control requirement)
PT-4(3) enhancement requires implementing **pt-04.03_odp** so individuals can **withdraw consent** for the organisation’s processing of their personal information. Guidance says withdrawal should be **easy to use**, and that it allows individuals to change their decision when circumstances change.

###### HOW (specific steps/approach)
1. **Provide a self-service withdrawal portal** (web/mobile) that clearly explains what withdrawal means (i.e., stopping consent-based processing for specific purposes) and provides a guided, user-friendly process.
2. **Check identity before accepting a withdrawal request** using the organisation’s enterprise identity service (for example, single sign-on with extra verification where appropriate). Ensure the portal records the result of the identity check.
3. **Create an authenticated ticket/case** in the organisation’s case-management system when a withdrawal is submitted. The ticket must record: the requester’s identity, the consent record(s) and processing purpose(s) affected, the time of submission, and the requested scope (full or partial withdrawal if supported).
4. **Run a workflow that matches the request to the correct consent records and processing purposes**, then applies the withdrawal in the consent management function (or triggers the relevant downstream systems) in line with the organisation’s consent withdrawal policies and procedures.
5. **Allow the individual to track progress** through a secure status view linked to the ticket reference (for example, submitted/in progress/completed), including clear next steps and expected timeframes.
6. **Keep records suitable for audit**: portal access events, identity-check results, ticket lifecycle events, consent records affected, actions taken in the workflow, and the final outcome—retained in line with the organisation’s privacy, transparency, and information-handling procedures.
7. **Assign named operational responsibilities** for portal ownership, day-to-day workflow operation, and decisions related to privacy and information handling (shown through ticket assignment/approvals and documented procedures).

###### WHO
- **Product/Service Owner (Privacy/Customer Trust)**: owns the portal user experience and ensures the withdrawal scope matches the organisation’s consent and purpose definitions.
- **Identity and Access Management (IAM) Lead**: ensures identity checks (including any extra verification) are implemented correctly.
- **Privacy Operations / Data Protection Officer (DPO) delegate**: defines how withdrawal policy and procedure are mapped and approves exceptions.
- **Service Desk / Case Management Owner**: runs the ticketing workflow and ensures requests are handled promptly.
- **Security Engineering**: ensures appropriate logging, auditability, and secure design are in place.

###### Acceptance criteria
- An individual can use the portal, complete identity verification, submit a withdrawal request, and receive a ticket reference.
- The workflow correctly identifies and updates the relevant consent record(s) and processing purpose(s) for the authenticated individual.
- The individual can track the request status through the defined stages until it is completed.
- All portal and workflow actions produce audit evidence showing identity verification, which consent records were affected, and the final outcome.
- Named roles are assigned in the workflow (ticket assignment/approvals) and carry out their responsibilities in line with the documented withdrawal procedures.

###### Actions Required for Compliance

- [ ] Design and build the self-service consent withdrawal portal flow, following the agreed user experience (UX) and user interface (UI) approach
- [ ] Integrate the portal with the organisation’s identity system so users must be authenticated (and complete extra verification when needed) before the system accepts any certificate revocation requests.
- [ ] Set up ticket or case creation in the organisation’s case-management system, with the form fields linked to the relevant consent record(s) and processing purpose(s).
- [ ] Set up workflow steps to: verify the person’s identity, find the correct consent records, cancel consent according to the consent cancellation policies and procedures, and record the results.
- [ ] Add secure tracking of each individual linked to the ticket reference, covering the ticket’s workflow stages from start to finish.
- [ ] Enable audit logs for portal access, authentication results, ticket lifecycle events, consent records that are affected, and the final processing outcome.
- [ ] Document and assign named responsibilities for operating the portal, managing workflow processing, and making decisions about privacy and information handling


---

### PT-5 — Privacy Notice (Control)

This requirement is about making sure people are clearly told, from the very first time they deal with your organisation, how their personal information will be used. Without this, people may be surprised by how their details are handled, shared, or used for purposes they did not expect. This can lead to loss of trust, complaints, and legal or regulatory problems.

To meet this expectation, your organisation must provide an easy-to-understand privacy notice the first time someone interacts with you. You must also make sure the same notice is available at least once every year and whenever the notice changes.

The privacy notice must be written in plain language. It must explain what personal information is processed, name the authority that authorises it, and set out the purposes for using the information. It must also explain what choices individuals have (if any) about how their information is used, and whether it is shared with other parties.

##### Central privacy notice service with versioned publishing and choice capture

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-wide privacy notice delivery process in plain language that shows the correct privacy notice the first time personal information (personally identifiable information (PII)) is collected. Keep the notice available for at least one year, and also whenever the wording of the notice changes. The notice must include who is responsible for the processing, why the information is used, and the choices individuals have (including whether information is shared with other parties).

###### WHY (control requirement)
PT-5 requires that individuals are told about how their PII is processed, including (at minimum) who is responsible and the purposes. It also requires that individuals are told what choices they have about how their information is processed and whether it is shared. The guidance also requires that privacy notices are given at the first interaction, written in plain language, and made available at least annually and whenever the notice changes.

###### HOW (specific steps/approach)
1. **Create an authoritative, version-controlled privacy notice content library** owned by Privacy/Legal. Include details such as version, effective date, last reviewed date, and an approval reference. Store the notice parts, including: who is responsible (authority/legal basis), purposes, who information is shared with (sharing parties/recipients), individual choices, and contact details.
2. **Use standard plain-language templates** for each notice part, and check that they are easy to read and accessible (for example, use controlled wording and avoid technical jargon) before approval.
3. **Set up a privacy notice display service** (web, mobile, and/or application programming interface (API) integration) that pulls the approved notice version and shows it **before or at the moment** the application first collects PII (for example, before a sign-up form is submitted, before the first data entry, or during onboarding when PII is first provided).
4. **Add a way to capture consent or choices** (for example, a preference centre or consent/choice engine) so the notice’s “choices” section matches the organisation’s actual processing setup. Where choices exist, record which notice version was shown and the individual’s selections.
5. **Control publishing and manage changes**: only approved notice versions can be published to live systems. Any changes must be approved by Privacy/Legal, and the display service must automatically use the updated approved version.
6. **Automate annual review and updates when changes happen**: run a review process at least once a year. If the notice is due for review or has changed, ensure the display service shows the updated approved version.

###### WHO
- **Privacy Officer / Legal Counsel**: owns the privacy notice content, the statements about authority and purpose, and the required choices; approves versions.
- **Product Owner / Application Owner**: ensures the notice is shown at the first PII collection points in the relevant user journeys.
- **Security/Compliance Engineer**: ensures the process can be audited (keeps evidence logs), integrates with existing consent/identity tools, and supports producing control evidence.
- **Engineering Team**: builds the integration for the notice display service, the publishing process, and the choice capture.

###### Acceptance criteria
- For every user journey where PII is first collected, the system shows the approved privacy notice **before or at the moment** the PII is collected.
- The notice shown matches an **approved, versioned** notice stored in the authoritative repository.
- The notice is available **at least annually** and is updated **whenever the notice changes** (with evidence of review and publish dates).
- The notice includes: **who is responsible**, **purposes**, and **individual choices** about processing and whether information is shared with other parties (or clearly states that no choices are available).
- Evidence exists to show: which notice version was shown for each interaction, and (where applicable) the individual’s recorded choices.

###### Actions Required for Compliance

- [ ] Set up an official, version-controlled library of privacy notices, owned by the Privacy and Legal teams, with an approval workflow.
- [ ] Create plain-language notice templates that clearly state who has authority, the purpose of the notice, which organisations the information may be shared with, and the individual’s options (or an explicit statement that there is no choice).
- [ ] Add a privacy notice display service to every user journey where personal data is first collected, so the notice is shown before the first data is entered or at the moment the first data is entered.
- [ ] Set up a way to record users’ consent and choices, and make sure the options shown in the notice match what you actually do with their data and how you share it.
- [ ] Use controlled publishing so only approved versions of notices can be delivered in the live (production) environment, and make sure any changes automatically update the effective version.
- [ ] Automate the scheduling of annual reviews, and block or flag any notice that is past its review due date.


---

#### PT-5.1 — Just-in-time Notice (Enhancement)

This requirement is about telling people, at the exact moment they share their personal information, what will happen to that information next. It matters because if organisations wait too long or provide unclear, general information, people may not understand how their data is being used, shared, or handled in ways that could affect their privacy—especially when the next step is higher risk.

To meet this expectation, the organisation must show a clear privacy notice either when the person provides their personal information, or at the same time as the organisation takes an action using that information. For higher-risk actions, the notice must be shown no later than immediately before the higher-risk step starts, and in any case within 5 minutes.

The notice must:
- relate to the specific information being collected and the specific action being taken
- be shown where the person can see it during the process
- explain how the organisation will use the information, including what it is used for and who it is shared with, where relevant

The organisation must also:
- document how it will do this
- assign named staff to make sure it happens
- use reliable ways to display the notice
- keep evidence showing when the notice was shown to the person

##### Event-driven just-in-time privacy notices with 5-minute gating

- Category: Software
- Priority: Critical

###### WHAT
Set up an event-based process that shows a just-in-time notice about how personally identifiable information (PII) will be processed. The notice must be shown to the individual at the moment they provide PII, or alongside the relevant data action. For actions considered higher-risk, the notice must be shown no later than immediately before the higher-risk processing starts, and in any case within **5 minutes**.

###### WHY (control requirement)
PT-5(1) requires the organisation to **give notice of PII processing** to individuals **at the time and place** where the individual provides PII, or **alongside a data action**. It also requires (based on an organisation-defined setting) that for higher-risk data actions the notice is shown **within 5 minutes** (parameter: **pt-05.01_odp frequency**: “At the time of collection or immediately before a higher-risk data action (within 5 minutes)”).

###### HOW (specific steps/approach)
1. **Create a higher-risk data action catalogue** for this application: list each data action (for example, creating an account, enabling tracking, uploading a document, sharing/exporting, enriching a profile), the PII categories involved, and label which actions are “higher-risk” for PT-5(1).
2. **Link each data action to the correct notice content/template** (and the specific PII items/data fields collected or used). Save these links in a version-controlled configuration so the notice content stays consistent with what the system actually does.
3. **Show the notice based on application events** when PII is provided (time of collection) and/or immediately before the linked data action begins. The notice must appear **within the user’s normal workflow** in a place they can reasonably see (for example, next to the relevant form fields or directly beside the action button).
4. **Apply the 5-minute rule for higher-risk actions** by blocking the higher-risk action until a “notice shown/acknowledged” token is present, including timestamps. The backend should refuse or delay the higher-risk request unless a valid token shows the notice was displayed within the allowed window (within 5 minutes before the action starts, or at collection).
5. **Keep evidence that can be audited for each notice**: notice template identifier and version, first display time, user/session identifier, acknowledgement status (if used), and the time the higher-risk action started (or the time of collection event). Keep this evidence according to the organisation’s privacy governance retention schedule.

###### WHO (role responsible)
- **Application Owner / Product Owner**: owns the data action catalogue and the notice-to-action mappings.
- **Software Engineering Lead**: builds the event triggers, ensures the notice is placed correctly in the user interface, and implements the backend blocking.
- **Privacy Officer / Data Protection Lead**: approves the notice content and ensures it accurately explains the purposes of processing and any sharing.
- **Security/Compliance Engineer**: checks that audit logging is complete and that the timing rules are enforced.

###### Acceptance criteria
- For every higher-risk data action defined, the system **stops** the action from proceeding unless a notice was displayed **within 5 minutes** immediately before the action begins (or at the time of collection, where applicable).
- For non-higher-risk actions, the notice is shown **at the time of collection** and/or **alongside** the data action, and is correctly linked to the specific PII and action.
- Notices are shown in the user’s workflow in a location the user can reasonably see (not hidden or off-screen).
- For each notice, the system produces audit evidence including the template identifier/version, display time, and action start time (or collection time), enough for an assessor to confirm timing and linkage.
- Changes to notice mappings and higher-risk data action definitions are version-controlled and traceable.

###### Actions Required for Compliance

- [ ] Define and keep up to date, using version control, a list of the data actions this application can perform, and identify which of those actions are higher risk for this application.
- [ ] For each data action, link it to the approved just-in-time notice template (or section) and identify the specific personal data (PII) fields involved.
- [ ] Set up event triggers so the notice is shown when the data is collected and again immediately before the mapped data action starts.
- [ ] Add backend checks for higher-risk actions. These actions should only be allowed when there is a valid “notice displayed” token, and the token’s timestamps fall within a 5-minute window.
- [ ] Show the notice in the user’s workflow at a place where the person can reasonably see it before continuing
- [ ] Keep auditable records for each notice shown, including the template ID and version, the time it was displayed, the user or session, the acknowledgement status, and the time the related action started.


---

#### PT-5.2 — Privacy Act Statements (Enhancement)

This requirement is about making sure people are clearly told, at the point they are asked for information, why the information is being collected and how it will be used. If this is not done, individuals may give details without realising they will be stored and used in ways they did not expect. This can result in poor decisions, loss of trust, and legal or reputational harm to the organisation.

To meet this requirement, the organisation must identify every way information is collected—such as paper forms, online pages, mobile applications, and telephone scripts—where the information is intended to be kept in a formal Privacy Act record system. For each of these, the organisation must provide a Privacy Act notice either:
- on the same form or within the same request process, or
- on a separate sheet or form the person can keep.

The notice must explain:
- the legal basis for asking for the information
- whether providing the information is required or optional
- the main purposes for using the information and any published routine uses
- what will happen if the person does not provide the information
- the relevant system of records citation and a link

The organisation must also document the process and name who is responsible, and ensure privacy and legal advisers have been consulted on the wording.

##### Privacy Act notice templates embedded in all data-collection flows

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-controlled set of Privacy Act statements and make sure they are shown **at the point where information is collected** (on the same form/page/request process) or through a **separate form the person can keep**, whenever the application collects information that will be stored in a Privacy Act system of records.

###### WHY (control requirement)
Privacy requirement PT-5(2) says that when people are asked to provide information that will become part of a Privacy Act system of records, the organisation must provide a **Privacy Act (PRIVACT) statement** on the form used to collect the information **or** on a separate form that the person can keep. This must be provided **no matter how the information is collected** (paper, electronic, website, mobile app, telephone, or other method). The statement must include: the legal authority; whether providing the information is required or optional; the main reasons the information will be used; the published “routine uses”; what happens if the information is not provided; and an appropriate system-of-records reference (citation/link).

###### HOW (specific steps/approach)
1. **Create a system-of-records map** for the application: for each place where data is collected (web form, mobile screen, API intake page, downloadable form, etc.), match the collected fields to the relevant **Privacy Act system of records**. Record the required citation/link and the routine uses.
2. **Create a controlled library of PRIVACT statement templates**, organised by each mapped system of records. Each template must include every required notice element (legal authority; required/optional; main purposes; published routine uses; what happens if the information is not provided; and the system-of-records citation/link).
3. **Put the notice into the collection screen or process** so it is shown to the person **before or at the start of entering data** (not after they submit). For web and mobile, show it on the same page/step as the request. For any option that uses a “separate form the person can keep”, generate a printable/downloadable notice the person can retain.
4. **Check notice completeness before release**: add a validation step in the application release process (for example, checks in CI/CD) that stops any deployment of a collection form/screen/API intake unless there is a valid system-of-records mapping and a template that includes all required notice fields.
5. **Make sure the message is consistent across all collection methods** used by the application (web, mobile, and any in-app or portal journeys). If telephone or agent-led collection is supported using scripts, use the same template content in the script process so the notice is delivered regardless of method.
6. **Set up governance and keep audit proof**: record which template version was used for each collection journey, who approved it, and when it was added. Ensure privacy/legal advisers review and approve the wording.

###### WHO
- **Privacy Officer / Data Protection Lead**: owns the system-of-records mapping and the template content requirements.
- **Legal Counsel (Privacy)**: reviews and approves the PRIVACT statement wording and the routine uses/citations.
- **Application Owner / Product Owner**: ensures every data-collection journey is mapped and uses the correct template.
- **Software Engineering Lead**: implements the notice in the user interface and the release validation checks.
- **Release Manager / DevOps**: ensures deployment controls and evidence capture are in place.

###### Acceptance criteria
- For every user-facing data-collection journey that results in data being stored in a Privacy Act system of records, the person receives a PRIVACT statement **either on the same form/process or via a separate form they can keep**.
- Each PRIVACT statement includes all required elements: legal authority; required/optional; main purposes; published routine uses; what happens if the information is not provided; and the system-of-records citation/link.
- The notice is shown **regardless of the collection method** supported by the application (at least web and mobile), and it is visible **at the point of collection**.
- CI/CD (or an equivalent release control) prevents deployment of any collection journey that does not have a valid system-of-records mapping and a complete notice template.
- Audit evidence is available showing template approval (privacy/legal), the template version, and where the notice is shown for each journey.

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date record of where each application’s data-collection endpoint is mapped, including the related citation or link.
- [ ] Develop Privacy Act statement templates for each mapped system of records, including all required notice elements.
- [ ] Add the correct PRIVACT notice to each web and mobile data-collection flow at the start of data entry (or create a separate notice that can be kept for later).
- [ ] Set up a release check at the time of deployment that stops the release if the data collection process does not have a valid “system of record” mapping or is missing required notice fields.
- [ ] Get approval from privacy and legal counsel for the wording in the templates and for routine uses, and keep a record of the approval evidence.
- [ ] Provide audit evidence showing which deployed data collection flow used which specific template version.


---

### PT-6 — System of Records Notice (Control)

This requirement is about making sure the public is clearly informed, in advance and through the correct official channels, when the organisation holds personal information about people and how it uses that information. Without this, people may not know what information is collected, why it is kept, who it might be shared with, or the legal basis for doing so. This increases the risk of unfair or improper use of personal data and loss of trust.

To meet this expectation, the organisation must first identify which of its information systems are covered by the Privacy Act. It must then produce the required public notice using the government’s guidance. For any new notice or any notice that is significantly changed, the organisation must submit it for advance review to the relevant oversight bodies and the appropriate congressional committees before publishing it in the Federal Register. The organisation must also ensure each notice remains accurate, up to date, and correctly reflects what the system actually does.

##### SORN workflow with OMB A-108 template, review gates, and change triggers

- Category: Manual
- Priority: Critical

###### WHAT
Set up a controlled process to make sure every system that handles information covered by a Privacy Act system of records has an accurate System of Records Notice (SORN) that meets Office of Management and Budget (OMB) A-108 requirements. The SORN must be: (1) written with all required information, (2) sent for the required advance review when the SORN is new or has been significantly changed, (3) published in the Federal Register, and (4) kept up to date as the system changes.

###### WHY (control requirement)
Privacy and security control PT-6 requires that, for systems that handle Privacy Act information within a Privacy Act system of records, the organisation publishes a SORN in the Federal Register when the system is first set up and/or when it is modified. The notice must explain the system’s purpose and nature, and include required elements: purpose(s), legal authority, categories of records and people, routine uses, and any additional required details under OMB A-108.

###### HOW (specific steps/approach)
1. **Identify systems covered by the Privacy Act** by linking the application/system inventory to the Privacy Act determination record (for example, “records retrieved by name/identifier” and “maintained as a system of records”).
2. **Use an OMB A-108-aligned SORN template** that includes mandatory fields for: system name/identifier; purpose and nature; purpose(s); legal authority for maintaining the system; categories of records; categories of people; routine uses; and additional required details.
3. **Run completeness and consistency checks** before a draft can be marked “ready for publication” (for example, all required sections are included; system boundary references match the organisation’s authoritative system description; routine uses and sharing statements match how the system’s data is actually used and shared).
4. **Define and document what counts as “new” versus “significantly modified”** based on specific system change events (for example, new or changed purposes, new categories of records/people, new routine uses/sharing, new retrieval identifiers, or a new legal authority basis). Require the system owner to select the correct outcome during the change intake process.
5. **Set advance review checkpoints**: for new or significantly modified SORNs, require completion of the organisation’s documented advance review steps (including submission to the relevant oversight bodies and appropriate parliamentary committees) before the workflow allows Federal Register publication.
6. **Keep the SORN accurate over time** by scheduling periodic SORN reviews and re-running the completeness checks whenever system changes could affect SORN content. Keep an evidence trail that can be audited (draft versions, checklist results, approvals, submission dates, and publication references).

###### WHO (role responsible)
- **Privacy Officer / Privacy Counsel**: owns the SORN template, maps required content to OMB A-108, and confirms legal adequacy.
- **System Owner / Application Owner**: provides the authoritative system boundaries and change-trigger information.
- **Governance Workflow Owner (for example, Governance, Risk and Compliance (GRC) / Compliance Lead)**: sets up the workflow, review checkpoints, evidence capture, and review schedule.
- **Records Management / Publishing Coordinator**: manages Federal Register publication arrangements and ensures the published notice matches the approved draft.

###### Acceptance criteria
- For the in-scope application/system, there is an approved SORN that includes all required elements in the PT-6 guidance (purpose and nature, purpose(s), legal authority, categories of records and people, routine uses, and additional details per OMB A-108).
- The workflow evidence shows that, for any new or significantly modified SORN, the advance review steps were completed before Federal Register publication.
- The SORN content is clearly consistent with the organisation’s authoritative system boundary and data-flow description.
- The organisation keeps audit-ready evidence: template version, completeness checklist outputs, reviewer approvals, advance review submission records, and the publication reference(s).
- When system changes occur that meet the documented “significantly modified” triggers, the workflow requires an updated SORN and blocks “ready for publication” status until the required review steps are completed.

###### Actions Required for Compliance

- [ ] Create a Privacy Act assessment for the application or system, and record whether it is a Privacy Act system of records (meaning records can be retrieved using a name or identifier).
- [ ] Use an Office of Management and Budget (OMB) A-108–aligned system of records notice (SORN) template, with mandatory fields for every required notice element.
- [ ] Define and publish the difference between “new” and “significantly modified” SORN triggers based on system change events, and require system owners to choose the correct trigger outcome when they submit a change request.
- [ ] Set up a governance approval step that prevents a document being marked “ready for publication” unless every required section of the statement of record (SORN) is complete and matches the official description of the system boundary.
- [ ] For any new or significantly changed SORN, complete and provide evidence for an advance review to the relevant oversight bodies and the appropriate United States congressional committees before the Federal Register publication.
- [ ] Publish the approved System of Records Notice (SORN) in the Federal Register and keep evidence showing how the published notice matches the approved draft and the template version.
- [ ] Arrange regular reviews to check that the SORN information is accurate, and repeat the checks for completeness and consistency whenever the system is changed in a way that could affect the SORN content.


---

#### PT-6.1 — Routine Uses (Enhancement)

This requirement is about making sure the organisation’s published descriptions of when personal information may be shared are still correct and still make sense. Every 90 days, the organisation must review every “routine use” listed in its Privacy Act system of records notice to confirm that the wording matches what it actually does, and that each sharing purpose still fits with the original reason the information was collected. Without this, outdated or overly broad sharing permissions could remain in place, which could allow personal data to be used or shared in ways people did not expect. This can cause legal, reputational, and financial harm.

To meet this expectation, the organisation should keep a complete list of all routine uses in the notice, check each one for accuracy and compatibility, record the result for every routine use, and make sure no published routine use is missed. If any routine use is found to be inaccurate or incompatible, the organisation must take follow-up action, such as updating the notice or recording a clear, approved justification for not changing it.

##### 90-day routine-use review register with notice compatibility checks

- Category: Manual
- Priority: High

###### WHAT
Create and run an official internal **Routine-Use Review Register** for each **Privacy Act system of records notice**, and review **every published routine use at least every 90 days** to confirm: (1) it is still accurate, and (2) it is still appropriate for the purpose for which the information was collected.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **PT-6(1) Routine Uses (Enhancement)** requires the organisation to **review all routine uses published in the system of records notice** identified by **{{ param, pt-06.01_odp }}** to ensure they remain **accurate** and **appropriate** for the original purpose of collection. It also requires that routine uses are only valid when they are **clearly published** in the system of records notice, so the review must cover the published entries.

###### HOW (specific steps/approach)
1. **Create the Routine-Use Review Register** by taking each routine use entry from the current system of records notice(s) and recording, for each routine use: the published wording, the stated purpose, the categories of users, and a **stable internal identifier** (for example, `SOR-<system>-RU-###`).
2. **Set the review frequency** to **every 90 days** (as set out in `pt-06.01_odp`) and ensure the process includes review tasks covering **100% of routine uses** (no sampling).
3. For each routine use, require reviewers to record two clear decisions:
   - **Accuracy**: the published routine use still matches current real-world practice.
   - **Appropriateness**: the routine use still fits the purpose for which the information was originally collected.
   Each decision must include a short explanation and links to supporting information (for example, disclosure logs, data-sharing agreements, operating procedures, contract clauses, or system documentation).
4. If any routine use is marked **“needs change”** for accuracy and/or appropriateness, the process must require one of the following before the review can be closed:
   - a linked **notice update** action (with approval and publication evidence), or
   - an **approved documented justification** explaining why the published routine use is still acceptable (signed off by the responsible privacy/legal authority).
5. **Produce audit evidence** for each 90-day cycle: a completion report listing every routine use, the recorded decisions, explanations, evidence links, and any corrective actions or justifications.

###### WHO (role responsible)
- **Privacy Officer / Data Protection Lead**: owns the register, approves decisions and justifications, and authorises notice updates.
- **System/Programme Owner (or delegated Privacy Liaison)**: provides evidence of current practice and supports the accuracy/appropriateness assessment.
- **Legal/Compliance (where applicable)**: approves justifications and notice update decisions.

###### Acceptance criteria
- A Routine-Use Review Register exists and includes **every routine use** from the relevant system of records notice(s), each with a stable internal identifier.
- Reviews are completed **at least every 90 days** and cover **100% of routine uses**.
- For each routine use, reviewers record **accuracy** and **appropriateness** decisions, including explanations and evidence links.
- Any routine use assessed as **inaccurate or inappropriate** results in either a **notice update with evidence** or an **approved documented justification** before the review cycle is closed.
- An audit-ready report is produced for each 90-day cycle showing outcomes and corrective actions/justifications.

###### Actions Required for Compliance

- [ ] Create a routine-use review register and fill it with the routine-use entries from the current system of records notice.
- [ ] Give each routine use a stable internal reference number, and record the published wording, its purpose, and the categories of users it applies to.
- [ ] Set up a repeating process to open review tasks for all routine uses every 90 days.
- [ ] Create reviewer prompts that require clear decisions on whether the information is accurate and whether it matches the evidence linked in the document.
- [ ] Apply closure rules so that any “needs change” finding can only be closed if either (1) the related notice is updated, or (2) there is an approved, documented justification.
- [ ] Produce and securely store a report covering the last 90 days that is ready for audit. It must list every routine use, the results, the reasons for each use, and any corrective actions taken.


---

#### PT-6.2 — Exemption Rules (Enhancement)

This requirement is about making sure any legal exemptions the organisation uses to handle personal data are still the correct ones, have been properly authorised, and are described accurately.

Without regular checks, the organisation could end up relying on outdated or incorrect exemption rules, or claiming an exemption that was never formally issued. This could mean people’s rights are not properly protected, and could expose the organisation to legal action and reputational damage.

To meet this expectation, the organisation must, at least every 90 days, review every Privacy Act exemption it currently relies on for the relevant set of records. For each exemption, it must confirm that:

- it is still appropriate and necessary under the law  
- it has been formally issued through official regulations  
- it is described accurately and consistently in the organisation’s published notice for those records, including the system names, the specific legal provisions covered, and the documented reasons and explanation for why the exemption is necessary and appropriate  

The organisation must record the outcome of these checks each time.

##### Automated 90-day review workflow for Privacy Act exemption rules

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable “Privacy Act Exemption Register” and an automated review process that checks every Privacy Act exemption claimed for the relevant system of records again after 90 days.

###### WHY (control requirement)
PT-6(2) requires organisations to **review all Privacy Act exemptions claimed for the system of records** to make sure they are still **appropriate and necessary under the law**, are **published as regulations**, and are **described correctly in the system of records notice**. This review must happen at the organisation’s required frequency for this control (every **90 days**).

###### HOW (specific steps/approach)
1. **Create an authoritative register** (system of record) that lists, for each claimed exemption:
   - the **system of records name(s)**
   - the **Privacy Act provision(s) being exempted**
   - the **regulation citation(s)** (with a link or PDF to the published regulation)
   - the **recorded reasons**, including an explanation of **why the exemption is necessary and appropriate**.
2. **Bring in the right evidence sources** so the workflow can compare:
   - (a) the register entries against the **published system of records notice** content (notice repository)
   - (b) the register entries against the **published regulations** (regulatory repository).
3. **Run a scheduled 90-day workflow** that creates a review task for **every** exemption entry. Before a reviewer can close a task, the workflow must require three checks:
   - **Appropriateness/necessity check**: confirm the exemption is still appropriate and necessary under the applicable law.
   - **Published-as-regulations check**: confirm the exemption is published as regulations (the regulation citation must be verifiable).
   - **Notice accuracy check**: confirm the system name(s), exempted provisions, and the scope of the exemption match what is stated in the system of records notice.
4. **Ensure nothing is missed using workflow validation** (policy-as-code style): do not allow task closure unless the evidence fields are completed (for example, regulation citation reference, notice excerpt reference, and the reviewer’s confirmation). If the regulation citation cannot be verified, automatically mark the exemption as **Unverified** and escalate to Privacy/Legal.
5. **Record the outcome** of each review cycle (pass/fail/needs change/unverified), including the time of review, the reviewer’s identity, and links to the evidence used.

###### WHO (role responsible)
- **Privacy Officer / Data Protection Officer (DPO)**: owns the register and ensures the legal review happens.
- **Privacy/Legal Counsel**: confirms appropriateness/necessity and publication as regulations when escalated.
- **System of Records Notice Owner** (for example, programme owner): confirms the notice text matches.
- **Compliance/Assurance**: periodically samples completed reviews to check quality.

###### Acceptance criteria
- A complete register exists for all claimed Privacy Act exemptions for the specified system of records.
- A review is carried out **at least every 90 days** for every exemption entry.
- For each completed review, the workflow records evidence that:
  - the exemption remains **appropriate and necessary**
  - the exemption is **published as regulations** (with a verifiable regulation citation)
  - the exemption is **described accurately** in the system of records notice (system name(s) and exempted provisions match).
- All review outcomes are logged with the reviewer’s identity, timestamp, and evidence references.
- Any unverified regulation citation triggers escalation and cannot be closed as a “pass”.

###### Actions Required for Compliance

- [ ] Define the data model for the Privacy Act Exemption Register, including: the system name(s), which Privacy Act provisions are exempted, the relevant regulation citation, the reasons for each exemption, an explanation of why each exemption is necessary and appropriate, and how each exemption maps to the relevant notice section.
- [ ] Update the register using the system of records notice repository and the published regulations repository, ensuring each system name matches exactly one exempted provision.
- [ ] Set up a scheduled 90-day process that creates review tasks for every exemption entry and prevents the exemption from being closed until the required evidence fields are completed.
- [ ] Set up automated checks that compare register entries with the relevant notice text (system name(s) and the provisions that are exempt) and with the regulation references (to confirm the references can be verified).
- [ ] Set up the escalation process so that any regulation citation that has not been verified is labelled **Unverified** and sent to **Privacy/Legal** to be resolved.
- [ ] Turn on audit logging for every review result, recording the date and time, who carried out the review, the outcome (pass, fail, needs changes, or unverified), and the supporting evidence references. Keep these records for audit purposes.


---

### PT-7 — Specific Categories of Personally Identifiable Information (Control)

This requirement is about ensuring personal information is only used for the specific purposes the organisation is allowed to use it for, and that the most sensitive types of personal data are handled with extra care. Without this, staff could use personal details for the wrong purpose, share them more widely than they should, or expose them if they are intercepted while being sent or accessed by people who do not genuinely need them. This could lead to privacy breaches, legal issues, and loss of trust.

To meet this expectation, the organisation must clearly define and document the authorised purposes for each category of personal information, and make sure day-to-day handling matches those purposes. For categories that are treated as Secret, International Traffic in Arms Regulations (ITAR), or otherwise regulated, the organisation must protect the data by encrypting it both while it is being transferred and while it is stored, restrict access to the smallest number of people who need it, and require approval based on job role before anyone can access or use it.

##### Enforce PII processing conditions by category with regulated protections

- Category: Software
- Priority: Critical

###### WHAT
Define and apply **processing rules** for each **specific type of personal data (PII)** (per organisation parameter **pt-07_odp: processing conditions**). For any categories identified as **Secret/International Traffic in Arms Regulations (ITAR)/regulated**, the application must enforce **encryption while data is moving and when it is stored**, **access only on a need-to-know basis (least privilege)**, and **approval by role** before anyone can access or use the data.

###### WHY (control requirement)
PT-7 requires: **“Apply {{ insert: param, pt-07_odp }} for specific categories of personally identifiable information.”** The parameter ensures processing is limited to authorised purposes and that **encryption while data is moving and when it is stored**, **least-privilege access**, and **role-based approvals** are applied to Secret/ITAR/regulated data.

###### HOW (specific steps/approach)
1. **Create a PII category list and mapping** in the application’s data governance area (for example: human resources, customer contact, medical, biometric). Clearly label which categories are **Secret/ITAR/regulated** using the organisation’s classification rules.
2. **Link authorised purposes to each PII category** by building a policy the application can check during use (for example, “policy-as-code” or an equivalent central policy service). The policy must limit processing actions (such as collect/store/share/export/retain) to the authorised purposes defined for that category.
3. **Add and carry forward data labels** so the PII category stays attached as data moves through the application (for example: in application programming interface (API) messages, database rows/fields, message topics, and exports). Use the label to make authorisation decisions and to stop “purpose drift” (processing outside the authorised purpose).
4. **Apply stronger protections for Secret/ITAR/regulated categories**:
   - **Encryption while data is moving**: require Transport Layer Security (TLS) for all client/application programming interface (API) traffic and service-to-service calls; use mutual Transport Layer Security (mTLS) where feasible for internal APIs.
   - **Encryption when data is stored**: ensure regulated PII fields/records are stored only in encrypted storage (database encryption and encrypted backups).
   - **Least privilege**: use role-based authorisation so only the minimum necessary roles/permissions can read or use regulated PII.
   - **Role-based approvals**: require an approval process before regulated PII can be accessed or used (for example, a ticket plus an approver role). Only after approval should time-limited access be granted (time-bounded access tokens/entitlements).
5. **Audit and keep evidence**: record (a) the PII category label, (b) the requested processing purpose, (c) the authorisation decision, (d) the approval reference for regulated access, and (e) proof that encryption is enforced (for example, TLS/mTLS session details and encrypted storage access). Send logs to security information and event management (SIEM) for audit support.
6. **Run the governance in day-to-day operations**: review the category-to-purpose mapping and the Secret/ITAR/regulated classification at least on a defined schedule (for example, when privacy risk assessment outcomes or legal requirements change) and ensure updates are applied through the policy enforcement mechanism.

###### WHO (role responsible)
- **Data Protection Officer (DPO) / Privacy Lead**: owns the authorised purposes for each PII category and coordinates consultation with legal/privacy advisers.
- **Application Owner / Engineering Lead**: implements runtime policy checks, label carry-forward, encryption enforcement, and approval gating.
- **Identity and Access Management (IAM) / Identity Architect**: implements role-based access, least-privilege entitlements, and integration with the approval workflow.
- **Security Operations / SIEM Administrator**: ensures audit logging, retention, and monitoring are in place.

###### Acceptance criteria
- The application can show that **each PII category** is processed only for the **authorised purposes** defined in pt-07_odp.
- For **Secret/ITAR/regulated** PII categories, evidence exists that:
  - **All access/use is controlled by role** and requires **documented role-based approval** (including approver identity and time-limited access).
  - **Encryption while data is moving** is enforced (no unencrypted/plain-text paths for regulated PII).
  - **Encryption when data is stored** is enforced for regulated PII storage and backups.
  - **Least privilege** is implemented (based on the minimum roles/permissions needed for each function).
- Audit logs show the category label, purpose, authorisation result, and approval reference for regulated access, and are available for review.

###### Actions Required for Compliance

- [ ] Create a clear set of categories for personal data (PII) and explicitly state which of those categories are treated as Secret, subject to the International Traffic in Arms Regulations (ITAR), or otherwise regulated.
- [ ] Convert “pt-07_odp authorised purposes” into enforceable policy rules for each personal information (PII) category.
- [ ] Set up persistent personal data (PII) labelling in the application so that the category labels are carried through application programming interfaces (APIs), storage, and exports.
- [ ] Require encryption while data is being sent and while it is stored for Secret, International Traffic in Arms Regulations (ITAR), and regulated personally identifiable information (PII) records, and for backups.
- [ ] Set up role-based access control (RBAC) with the least privileges needed for anyone who can access and process regulated personal information (PII).
- [ ] Add role-based approval checks (role-based access control) for access to and use of regulated personal data (PII), and only grant time-limited permissions after approval.
- [ ] Set up audit logs to record the category, purpose, authorisation decision, and approval reference, and send them to security information and event management (SIEM).


---

#### PT-7.1 — Social Security Numbers (Enhancement)

This expectation is about using Social Security numbers only when you genuinely need them, and being clear with people about why you are asking for the number. Without this, organisations may collect and keep these very sensitive numbers for longer than necessary, use them for purposes that are not essential, or unintentionally treat someone differently simply because they do not want to share their number—potentially preventing them from accessing lawful rights, benefits, or services.

To meet this expectation, the organisation must actively reduce unnecessary collection, storage, and use of Social Security numbers, and look for other ways to identify people that do not rely on them. It must also make sure that if someone refuses to provide their Social Security number, the organisation does not deny any legal right, benefit, or privilege for that reason.

Finally, whenever the organisation asks for a Social Security number, it must clearly explain whether providing it is required or optional, the legal or other authority for requesting it, and exactly how the number will be used.

##### Minimise SSN processing via purpose gating and identifier substitution

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-wide and application-level programme to **remove unnecessary collection, storage, and use of Social Security numbers (SSNs)**, and **replace SSN as a personal identifier** with an internal, purpose-specific identifier wherever possible. Where SSNs are still needed, use **approved-purpose-only capture**, and make sure SSNs are not used as the main identifier in any new or changed services.

###### WHY (control requirement)
PT-7(1) (Enhancement) requires that when a system processes SSNs, the organisation must **remove unnecessary uses** and **look for alternatives** to using SSNs as identifiers. This approach meets that requirement by redesigning processes and data structures to reduce reliance on SSNs.

###### HOW (specific steps/approach)
1. **List all SSN touchpoints** across the application and any integrations (user screens, application programming interfaces (APIs), batch jobs, reports, data stores, message channels, ETL/ELT pipelines, and third-party data transfers) to identify every place SSNs are collected, stored, sent, or used.
2. Create an **SSN justification register** for each system/data flow, recording: business purpose, why it is needed, the legal/authority basis (as provided by the organisation), expected retention period, and the approval owner (system owner plus privacy/compliance lead). Do not introduce or keep any SSN field without approval.
3. **Change identity matching and data linking** to use a stable internal subject identifier (for example, customer/employee/contractor ID) instead of SSN as the linking key in application data models, analytics datasets, and reporting views.
4. Add **purpose-based capture controls** in the application: make SSN fields optional by default, and only allow SSN capture when an **approved-purpose flag** is set for that specific workflow/API endpoint. Stop SSN capture in any non-approved flows, including free-text entry routes.
5. Add **automated enforcement** through continuous integration/continuous delivery (CI/CD) and runtime checks: stop new data structures from using SSN as the main identifier; add checks to detect SSN field use in code/configuration; and apply masking or tokenisation for any SSN that must still be stored.
6. Where SSNs are still stored, apply **data minimisation controls**: tokenise/store SSNs securely (for example, in a vault), limit access to a small set of authorised roles, and ensure downstream systems receive masked/tokenised values rather than raw SSNs.

###### WHO
- **Application Owner / Product Owner**: responsible for changing workflows and data models.
- **Privacy/Compliance Lead**: owns the SSN justification register and the approval requirements.
- **Security Architect / Data Protection Officer (if applicable)**: sets the tokenisation/vault approach and access restrictions.
- **Engineering Leads**: implement purpose gating, identifier replacement, and CI/CD enforcement.

###### Acceptance criteria
- A complete SSN touchpoint inventory exists for the application and its integrations.
- For every SSN field/data flow, there is an approved entry in the SSN justification register (including purpose and necessity).
- SSN is not used as the main identifier/linking key in the application’s core data model and reporting datasets (for both new and changed services).
- SSN capture is blocked unless the workflow/API is marked with an approved purpose (confirmed through automated tests and runtime checks).
- Any remaining SSN storage is tokenised/vaulted (or otherwise protected), and downstream users receive masked/tokenised values.
- Audit evidence is available (inventory report, justification register, code/config enforcement evidence, and test results).

###### Actions Required for Compliance

- [ ] Carry out an inventory of every place where the Social Security Number (SSN) is used across the application, databases, application programming interfaces (APIs), batch jobs, reports, and integrations.
- [ ] Set up and keep a record of every Social Security Number (SSN) use, with privacy and compliance review and approval from the system owner for each SSN data flow.
- [ ] Update the identity and data model links to use an internal subject identifier instead of a Social Security number (SSN).
- [ ] Set up purpose-based capture controls so that Social Security Number (SSN) fields are optional and can only be entered for approved workflows and approved endpoints.
- [ ] Add continuous integration and continuous delivery (CI/CD) and checks on new code and configuration to prevent social security numbers (SSNs) being used as the main identifier in new services.
- [ ] Replace any remaining storage of United States Social Security numbers (SSNs) with tokenisation or a secure vault, and make sure downstream systems receive masked or tokenised values.


---

#### PT-7.2 — First Amendment Information (Enhancement)

This requirement is about stopping the organisation from collecting or using information that could show how people exercise protected rights—for example, what they say, whether they protest, or what they believe—unless there is a very clear legal reason to do so. Without this protection, the organisation could mistakenly monitor or analyse people’s lawful expression. That creates a serious risk of unfair treatment, discouraging people from speaking freely, and causing legal or reputational harm.

To meet this expectation, the organisation must put in place and follow privacy and legal procedures that, by default, prevent this type of information from being processed. Staff must only proceed when Parliament has expressly allowed it, when the individual has given clear, specific permission, or when it is directly relevant to, and carried out within the scope of, an officially authorised law-enforcement activity.

For any approved use, the organisation must record which permission basis applies and consult senior privacy and legal advisers to confirm the decision is correct.

##### Block First Amendment rights-behaviour processing without legal basis

- Category: Software
- Priority: Critical

###### WHAT
Put in place a system-wide “rights-behaviour” processing gate that **stops processing** (including storing, indexing, analytics, enrichment, and sharing) information that describes how individuals exercise **First Amendment rights**, unless one of the allowed conditions is met.

###### WHY (control requirement)
PT-7(2) requires the organisation to **stop processing** information that describes how any individual exercises **First Amendment rights**, unless it is:
1) **Explicitly authorised by law (statute)**, or
2) **Explicitly authorised by the individual**, or
3) **Relevant to, and within the scope of, an authorised law enforcement activity**.

###### HOW (specific steps/approach)
1. **Create a rights-behaviour category** in the application/data intake layer (for example, a taxonomy covering speech/protest/assembly/demonstration/belief/political activity, including free-text notes and attachments) and label candidate records as “First Amendment rights-behaviour”.
2. **Block by default at the point of intake**: any process that brings in data (user interface uploads, application programming interface ingestion, case management ingestion, batch loads into a data lake/data warehouse, message ingestion, and export jobs) must first check whether the content is “rights-behaviour”. If it is, the process must stop unless an approval token is provided.
3. **Require one of the three allowed legal bases** as structured, machine-checkable fields in the approval request:
   - Law (statute) reference (for “explicitly authorised by law (statute)”), OR
   - Individual explicit authorisation evidence/ID (for “explicitly authorised by the individual”), OR
   - Law enforcement authorisation reference plus stated scope (for “relevant to, and within the scope of, an authorised law enforcement activity”).
4. **Add mandatory privacy/legal escalation**: for any rights-behaviour request, the workflow must pause until senior privacy and legal counsel approve (or a documented delegated authority route is used, if your organisation’s governance allows it).
5. **Link approval to data history and downstream actions**: store the approved legal basis and (where relevant) the law enforcement scope in an unchangeable audit record, and attach it to dataset lineage metadata so that downstream analytics, indexing, sharing, and exports use the same basis.
6. **Enforce “no processing before basis”**: make sure the system cannot store, index, transform, or export rights-behaviour data until the approval token is validated and recorded.

###### WHO (role responsible)
- **Application Owner / Engineering Lead**: implement intake gating, workflow enforcement, and lineage linking.
- **Privacy Officer / Senior Privacy Counsel**: define the classification approach and approve permitted uses.
- **Legal Counsel**: confirm the legal basis (statute) or the individual authorisation evidence; confirm law enforcement authorisation and scope.
- **Security/Compliance Lead**: ensure the process is auditable, evidence is retained, and it aligns with enterprise governance.

###### Acceptance criteria
- Rights-behaviour data is **blocked by default** on all ingestion and export routes unless an approval token is present.
- For each permitted processing instance, the approval record includes **exactly one** of the three allowed conditions and the required evidence fields (law (statute) reference / individual authorisation evidence ID / law enforcement authorisation reference plus scope).
- Privacy and legal counsel approval is mandatory for rights-behaviour requests (no bypass in live production).
- The approved legal basis and scope are recorded in unchangeable audit logs and carried forward to downstream processing (analytics/indexing/export) through lineage metadata.
- Automated tests show that attempts to store/index/export rights-behaviour data without approval fail in a consistent, predictable way.

###### Actions Required for Compliance

- [ ] Define a “First Amendment rights behaviour” data category and link it to all ways data is received (user interface, application programming interface, uploads, attachments, and batch loads).
- [ ] Set up a “block by default” intake gate that stops storage, indexing, analytics, and exporting when the system detects rights-related behaviour without an approval token.
- [ ] Set up an approval workflow that requires the approver to select exactly one allowed option—either a specific law (statute), permission given directly by the individual, or authorised law enforcement activity within the permitted scope—and to provide the required supporting evidence for that choice.
- [ ] Set up mandatory escalation so that senior privacy and legal counsel must approve any request to process rights-related behaviour before processing can begin.
- [ ] Attach the approved legal basis—and, where relevant, the law-enforcement scope—to the dataset’s lineage information, and make sure any later processing jobs automatically use the same settings.
- [ ] Add automated tests and monitoring to confirm that data is not processed before the legal basis is in place, across every way data is brought in and sent out.


---

### PT-8 — Computer Matching Requirements (Control)

This requirement is about making sure that when the organisation compares information from different records to decide whether someone is eligible for benefits or owes money, the process is properly authorised, clearly agreed, and fair to the person affected. Without these safeguards, the organisation could rely on incorrect matches, wrongly accuse someone, or take action without giving them a chance to understand and challenge the result, which could cause real financial and personal harm.

To meet this expectation, before starting any matching programme the organisation must get written approval from the Data Integrity Board, create and sign a formal matching agreement that explains what will be compared and how, and publish a matching notice in the Federal Register. If the organisation plans to take adverse action based on the results, it must independently check the matching information first. Then, before any adverse action is taken, it must tell the individual what the findings are and give them a fair opportunity to contest them.

##### Matching programme lifecycle gates with independent verification

- Category: Software
- Priority: Critical

###### WHAT
Set up an end-to-end “computer matching programme lifecycle” that ensures: formal authorisation, a signed matching agreement, clear disclosure, independent checking of match results, and individual notice and a chance to challenge before any adverse action.

###### WHY (control requirement)
PT-8 requires that when the organisation uses information in a matching programme, the programme is properly governed and controlled. This includes the matching activity itself, any follow-up investigation, and the final decision or action. The guidance says matching programmes need: (1) an established approval process, (2) a matching agreement, (3) clear notice/disclosure, and (4) independent checking and a fair opportunity to challenge if adverse action is being considered.

###### HOW (specific steps/approach)
1. **Create a governed matching programme record** in the organisation’s governance, risk and compliance (GRC) or workflow system. Include mandatory details for purpose, data sources/records, matching rules/logic, output fields, how long data is kept, investigative follow-up, and what triggers adverse action.
2. **Apply policy-controlled workflow checks** so the system cannot schedule matching jobs, share match results through application programming interfaces (APIs), or start adverse-action cases until supporting evidence is attached for: (a) written approval, (b) a signed matching agreement, and (c) the required public notice/disclosure document.
3. **Set up an independent verification process** that re-checks and validates match outputs using a separate execution setup (for example, a different service account and a separate code/configuration repository, or reviewer sign-off). Record verification results against agreed criteria (for example, reconciliation rules, error-rate limits, and how exceptions are handled).
4. **Only allow adverse action after verification is complete**: the adverse-action workflow must confirm that independent verification has passed and that the verification evidence is linked to the specific match batch/case.
5. **Create an individual notice and challenge process** using approved templates and link it to the case record. Do not allow adverse action to proceed until the notice has been issued and the challenge period/steps are completed, or the process is formally waived.
6. **Keep audit-ready evidence** by storing tamper-resistant logs for data lineage (for example, dataset identifiers/hashes), job settings, the matching logic version, verification results, and workflow approvals/signatures.

###### WHO (role responsible)
- **Data Integrity Board (or delegated governance authority):** provides written approval.
- **Privacy/Legal owner:** confirms the matching agreement content and disclosure documents are correct.
- **Programme/Business owner:** sets the purpose, scope, and triggers for adverse action.
- **Application security/engineering lead:** implements the workflow checks, independent verification process, and audit logging.
- **Case management owner (for example, compliance/operations):** ensures individual notice and challenge steps are carried out and recorded.

###### Acceptance criteria
- Matching jobs and release of match results are blocked until the workflow has attached evidence of written approval, a signed matching agreement, and the required disclosure document.
- For any case that could lead to adverse action, independent verification must be completed and its evidence linked to the case before adverse action can proceed.
- Individual notice is produced from approved templates, and the system prevents adverse action until notice/challenge steps are completed or formally waived.
- Audit logs provide traceability from data sources and job settings through match outputs, independent verification results, workflow approvals, and the final case outcome.

###### Actions Required for Compliance

- [ ] Set up the matching programme lifecycle workflow in the governance, risk and compliance (GRC) tool, including required evidence fields: approval, a signed agreement, and a disclosure document.
- [ ] Set up “policy-as-code” workflow gates that stop job scheduling, prevent releasing match results through the application programming interface (API), and block creating adverse-action cases until the required evidence is available.
- [ ] Set up an independent verification process that runs in a separate environment, and record the verification results for each match batch or case.
- [ ] Set a rule at the application level so that any “adverse action” workflow can only proceed after a successful verification and with supporting evidence linked to it.
- [ ] Set up the process for generating each notice and running the contest, and do not take any negative action until the notice and contest steps are completed or the steps are formally waived.
- [ ] Set up tamper-evident audit logs that record the full dataset history (lineage), the job settings used, the matching logic and its version, the results of verification checks, and the governance approvals.

