### AU-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has a clear, written plan for how it will:

- check what people and systems are doing  
- show that these checks are carried out properly  
- stay responsible and answerable for the results  

Without an up-to-date policy and practical procedures, important evidence could be missed, responsibilities could be unclear, and the organisation may not meet legal and regulatory expectations after security incidents, failed audits, major changes, or new rules.

The organisation must create an organisation-wide audit and accountability policy that sets out its purpose, scope, roles, responsibilities, leadership commitment, how different parts of the business will work together, and how compliance will be ensured. This policy must align with relevant laws, directives, regulations, and internal standards.

The Chief Information Security Officer, working with the Audit and Accountability Policy Working Group, must manage producing, documenting, sharing, and keeping these documents up to date.

The policy must be reviewed at least every year, and also after security incidents, audit findings, major organisational changes, or changes to the laws and directives that apply. The procedures must be reviewed at least every quarter, and after the same triggers. Both the policy and procedures must be shared with the named leadership, the document owners, the compliance team, and the internal audit staff.

##### CISO-owned audit & accountability policy and quarterly procedures

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-level **audit and accountability policy** and supporting **audit and accountability procedures** that cover the AU family controls used in the organisation. This should include clear roles, responsibilities, coordination, and alignment with compliance requirements.

###### WHY (control requirement)
AU-1 requires that audit and accountability are governed by **documented policy and procedures** (not just repeating the AU controls). The guidance also requires that:
- the policy/procedures are **consistent with applicable laws, instructions from senior leadership, regulations, organisational policies, standards, and guidance**;
- the **security and privacy programmes** work together when developing them;
- the **Chief Information Security Officer (CISO)** is the named person responsible for managing the policy/procedures;
- the policy is reviewed and updated **at least once every year** and after defined events (for example: incidents, audit findings, major organisational changes, and changes to laws or instructions);
- the procedures are reviewed and updated **at least once every quarter** and after the same types of events;
- the documents are shared with the defined people and roles.

###### HOW (specific steps/approach)
1. **Create one official document set** (policy plus procedures) in a controlled repository, with version history, effective dates, and a clear mapping to the AU family controls used for the enterprise application environment.
2. **Set governance ownership and workflow**: appoint the **CISO** as the official owner and establish an **Audit and Accountability Policy Working Group** (including the compliance office, internal audit, security operations centre (SOC) lead, and a privacy representative). Use an approval workflow with recorded sign-off.
3. **Write the policy** to include: purpose, scope, roles and responsibilities, management commitment, coordination between the security and privacy programmes, and alignment to applicable laws/instructions/regulations/standards.
4. **Write role-based procedures** that explain how the policy is put into practice for: system owners, SOC analysts, and internal audit. Include specific outputs and evidence records (for example: review records, update triggers, and acknowledgements of receipt) so the procedures can be audited.
5. **Set review and update timing and event triggers** exactly as required: policy **annually** and after incidents/audit findings/major organisational changes/legal or instruction changes; procedures **quarterly** and after the same triggers. Record the trigger type and the reason for each update.
6. **Share the documents with evidence**: publish the policy to the defined leadership/system/compliance audience, and share the procedures with system owners, SOC analysts, and internal audit. Keep evidence of sharing (for example: publication records and acknowledgements where possible).

###### WHO
- **Chief Information Security Officer (CISO)**: owner/manager of the audit and accountability policy and procedures; chairs the governance workflow.
- **Audit and Accountability Policy Working Group**: drafts, reviews, and coordinates alignment between security and privacy.
- **Compliance office and internal audit**: check that the documents are auditable and that evidence expectations are clear.
- **Security operations centre (SOC) lead**: ensures the procedures reflect day-to-day operational monitoring and accountability processes.
- **Privacy representative**: ensures the privacy programme collaborates and remains aligned.

###### Acceptance criteria
- An organisation-level **audit and accountability policy** exists, is approved by the CISO/working group, and clearly aligns to applicable laws/instructions/regulations/standards.
- An organisation-level **audit and accountability procedures** document set exists, is role-based (system owners, SOC analysts, internal audit), and explains how the requirements are implemented and what evidence records are produced.
- The document repository includes **version history**, effective dates, and traceable approvals.
- A review schedule is in place: the policy has a documented **annual review** date, and the procedures have a documented **quarterly review** date.
- Event-driven update triggers are documented and linked to change-control records (incidents, audit findings, major organisational changes, and legal/instruction changes).
- Records of sharing exist showing the policy was provided to the **CISO, senior leadership, system owners, and the compliance office**, and the procedures were provided to **system owners, SOC analysts, and internal audit**.

###### Actions Required for Compliance

- [ ] Create an organisation-wide audit and accountability policy document set in a controlled repository, with version control and an approval workflow.
- [ ] Define the Chief Information Security Officer (CISO) as the named person responsible for managing the security policy and procedures, and for recording governance responsibilities in the working group charter.
- [ ] Draft the policy content to include its purpose, scope, roles and responsibilities, management commitment, coordination with security and privacy teams, and alignment with compliance requirements.
- [ ] Create role-based audit and accountability procedures for system owners, security operations centre (SOC) analysts, and internal audit, including the required evidence records.
- [ ] Set a review and update schedule: review the policy every year and review the procedures every quarter, and record specific events that trigger updates.
- [ ] Share the policy and procedures with the named people or job roles, and keep proof that it was shared (for example, a record of publication and any acknowledgements, where applicable).


---

### AU-2 — Event Logging (Control)

This expectation is about making sure your systems keep a clear, reliable record of important security events, so you can review them later and understand what happened. Without this, suspicious activity—such as repeated failed login attempts, someone trying to gain extra permissions, misuse of administrator accounts, use of smart card credentials, unauthorised changes to security settings, access to sensitive information, attempts to export data, or signs that someone is trying to interfere with the audit record—could go unnoticed or be impossible to piece together after an incident.

To meet this, the organisation must first identify which types of events the system can record. It must then agree with the relevant internal teams which event types are needed for investigations, including both successful and failed logins, privilege escalation, use of administrator accounts, use of smart card credentials, security-relevant configuration changes, access to classified or controlled data, data export or download, suspected tampering with audit logs, and use of authentication tokens.

Each selected event must be recorded every time it occurs. High-volume events must have extra logging during 24/7 incident response, and at least monthly at other times. The organisation must also document why these choices are sufficient for investigations after the fact, and review and update the selected event types at least quarterly.

##### Configure application audit event types and SIEM ingestion

- Category: Software
- Priority: Critical

###### WHAT
Define the exact set of security-relevant event types the application must record (and when/how often), then configure the application and its supporting components so those events are recorded when they happen and are reliably sent into the organisation’s security information and event management (SIEM) system and audit storage.

###### WHY (control requirement)
AU-2 requires security and privacy event logging. This includes:
- choosing a subset of event types “at a given point in time”
- recording each selected event type “on occurrence”
- reviewing and updating the selected event types periodically

The organisation’s AU-2 settings define which event types to use and the required logging frequency/situation.

###### HOW (specific steps/approach)
1. **Create or confirm the application event logging requirements** using the organisation-defined event types and subset:
   - Event types (subset): successful and failed logons; privilege escalation; use of administrative accounts; use of personal identity verification (PIV) credentials; security-relevant configuration changes; access to classified/controlled data; data export/download; audit log tampering; authentication token use.
2. **Implement logging in the application** so each selected event type is produced by the relevant parts of the system:
   - Authentication events: record on successful and failed login attempts (including identity provider outcomes).
   - Privilege/admin events: record on privilege escalation and administrative account use (including role changes and administrative actions).
   - Credential usage: record on PIV credential use (where applicable through identity integration) and on authentication token use (for example, token issuance, refresh, and validation events as supported).
   - Security-relevant configuration changes: record when security settings change (for example, changes to authentication policy, access control model changes, and audit setting changes).
   - Data events: record when classified/controlled data is accessed and when data is exported/downloaded.
   - Audit integrity: record events showing audit log tampering attempts (where the platform can detect this). If detection is not supported, record signals such as “audit pipeline disabled/unavailable” and “log integrity check failed”.
3. **Set the logging frequency/situation** to match the organisation-defined rule:
   - Record each selected event type every time it occurs.
   - For high-volume events, ensure the system can switch to “incident-response mode” to record every occurrence during 24/7 incident response, then return to the monthly baseline otherwise.
4. **Configure the log pipeline for completeness and usefulness**:
   - Ensure logs include the minimum investigation details: timestamp with time zone, user/actor identity, source internet protocol (IP) address and host, session identifier, event type, outcome, and relevant object/data classification tags.
   - Ensure SIEM ingestion is set up for the application’s event format (normalisation/parsing) and that events can be searched by event type.
5. **Set up quarterly review evidence**:
   - Keep a version-controlled record of the enabled event-type subset and the reason for any disabled or high-volume categories.
   - Provide evidence that the current production configuration matches the approved subset (for example, configuration exports/screenshots and SIEM ingestion validation results).

###### WHO (role responsible)
- **Application Security/Engineering Lead**: responsible for mapping event types to the application code paths and implementing the logging.
- **Platform/DevOps Engineer**: responsible for log pipeline configuration and incident-response mode switches.
- **Security Operations Centre (SOC)/SIEM Administrator**: checks that logs are parsed and ingested correctly and provides feedback on whether events are useful.
- **Information Security/Privacy Officer (where applicable)**: reviews the privacy impact of logged fields and approves the final event-type subset.

###### Acceptance criteria
- For every event type in the organisation-defined subset, the application produces an audit event “on occurrence” in production (or the relevant live environment), and the SIEM displays the event type with correct parsing.
- High-volume event handling follows the organisation-defined frequency/situation: every occurrence during 24/7 incident response and monthly otherwise (shown through configuration and test/validation evidence).
- Audit log tampering and audit pipeline integrity signals are present (either explicit tampering detection events or integrity/pipeline failure events) and are ingested into the SIEM.
- A quarterly review record exists showing the enabled event-type subset and evidence that the production configuration matches the approved list.

###### Actions Required for Compliance

- [ ] Confirm that the application’s enabled “AU-2” event-type subset matches **au-02_odp.02**, and record the reason for any items you exclude.
- [ ] Set up the application to record the required audit events in the correct places in the code, covering: logons, privilege escalation, use of administrative functions, personal identity verification (PIV) and credential use, security configuration changes, access to controlled data, exporting or downloading data, signals that audit logs are being protected, and use of tokens.
- [ ] Set the logging frequency so that each selected event type is recorded when it happens. For high-volume events, enable an incident-response mode that runs 24 hours a day, 7 days a week; for all other times, use the monthly baseline.
- [ ] Set up the logging pipeline (agent, appender, and collector) to standardise log events and send them to the security information and event management (SIEM) system, including the required fields: timestamp, actor, outcome, session, source, and object/classification tags.
- [ ] Test the security information and event management (SIEM) system’s ability to read and bring in data by generating test events for every required event type, then confirming that those events can be found using the SIEM search function.
- [ ] Create a quarterly review record that links the approved set of event types to current production evidence (configuration exports and confirmation that security information and event management (SIEM) is ingesting the data correctly).


---

### AU-3 — Content of Audit Records (Control)

This requirement is about making sure the organisation’s records of important system and user activity are complete enough to explain what happened, when it happened, where it happened, who was involved, and what the outcome was. Without these complete records, it is much harder to spot wrongdoing, investigate mistakes, or understand why something failed. This could leave sensitive information exposed, disrupt services, or harm privacy, without anyone being able to show what actually occurred.

To meet this expectation, the organisation must ensure that for every event it decides to record, each saved audit record clearly states:
- the type of event  
- the date and time it happened  
- the location involved (for example, the system or service)  
- what triggered it (for example, the user, device, or process)  
- the outcome (including whether it succeeded or failed, and any relevant details)  
- the identities of any people, systems, or other entities connected to the event, including any affected items such as files or target addresses where relevant.

##### Enforce AU-3 audit record fields via SIEM ingestion schema

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-approved format for audit records and make sure it is enforced when logs are collected, so that every saved audit record includes: (a) what happened, (b) reliable date and time, (c) the source and destination addresses/locations where relevant, (d) the user or system/process involved, (e) whether it succeeded or failed, and (f) any extra user/system/process details needed for that type of event. Also include the file name(s) and/or the affected resource identifier(s) when the event involves files or other resources.

###### WHY (control requirement)
AU-3 requires audit records to include enough information to describe the event, confirm the time it occurred, identify the source and destination, record the user/system/process involved, show whether it succeeded or failed, and include any filenames involved. This is needed to support auditing, investigation, and accountability.

###### HOW (specific steps/approach)
1. **Define a standard audit event format** for the application’s log sources (web/application programming interface (API), admin actions, authentication/authorisation, data access, and system/service events), mapping the required fields to the AU-3 requirements:
   - `event_description` (event type / what happened)
   - `event_time` (timestamp)
   - `event_location` (system/service/application context)
   - `source_address` and `destination_address` (where applicable)
   - `actor_user_id` / `actor_process_id` (user/system/process identifiers)
   - `outcome` + `success`/`failure` (success or fail indication)
   - `result_details` (event-specific outcome details)
   - `file_name` / `target_resource` (filenames/resources when applicable)
2. **Validate at the point of log collection** in the security information and event management (SIEM)/log pipeline (for example, collector/forwarder plus a normalisation service) to ensure required fields are present and in the correct format. For events that do not meet the requirements:
   - send them to a **quarantine index** (or dead-letter queue) and create a remediation ticket for the responsible team,
   - do not silently discard them or accept them when required AU-3 fields are missing.
3. **Standardise and enhance identity information** so the people and systems involved are recorded consistently:
   - map application session/user identifiers and service account identifiers to the organisation’s authoritative identity records (identity provider (IdP)/identity governance and administration (IGA)),
   - capture process identifiers when the application provides them (for example, job IDs, workflow IDs, API client identifiers).
4. **Ensure time accuracy** for audit purposes:
   - require network time protocol (NTP)-synchronised hosts/containers for the application and log collectors,
   - add checks during ingestion for clock differences, and flag/reject events outside an acceptable time-drift range.
5. **Handle audit information in a privacy-protecting way**:
   - identify fields that may contain personal data (for example, free-text parameters, usernames, and filenames that include personal information),
   - apply tokenisation/redaction rules that keep audit value for investigation (for example, stable hashes for linking related events) while avoiding unnecessary disclosure in the audit record.

###### WHO (role responsible)
- **Security Engineering / security operations centre (SOC) Engineering**: owns the standard audit record format, the ingestion validation rules, and the quarantine/remediation workflow.
- **Application Engineering Lead**: ensures the application produces the required event fields (or that adapters extract them) for web/API, admin, and data-access events.
- **Identity and Access Management (IAM) team**: provides authoritative identity mapping and enrichment.
- **Privacy Officer / Data Protection Lead** (with Security): approves the redaction/tokenisation rules for audit records.

###### Acceptance criteria
- For each configured audit event type retained by the application/SIEM pipeline, the stored audit record contains at least the AU-3 required elements (event description, timestamp, source/destination/locations where applicable, user/system/process identifiers, success/failure, and filenames/target resources where applicable).
- Ingestion validation clearly rejects or quarantines events missing required AU-3 fields, with measurable counts and remediation tickets.
- Timestamps are consistent within the defined drift window, and clock-difference issues are flagged.
- Privacy controls are applied to known fields that may contain personal information, with evidence that redaction/tokenisation is active and does not break event linking (for example, stable identifiers remain consistent).

###### Actions Required for Compliance

- [ ] Create a single, standard (canonical) audit event schema for AU-3 by mapping application and security information and event management (SIEM) fields to: the event description, date and time, location, source and destination, who was involved (identifiers), the result (outcome), and any file names or other target resources.
- [ ] Set up checks during data intake into the security information and event management (SIEM) and log pipeline to ensure each event includes the required AU-3 fields, and that each field follows the correct format and appears the correct number of times for its event type.
- [ ] Set up a quarantine location for audit events that do not meet requirements, and create a process that sends a remediation task to the owner of the application or log source.
- [ ] Enable identity enrichment so actor user and process identifiers are matched to the organisation’s official identities, and service accounts are represented consistently.
- [ ] Ensure system time is accurate by keeping clocks synchronised using the Network Time Protocol (NTP) or Precision Time Protocol (PTP), and add checks during data intake for clock drift (clock skew) with alerts if it is detected.
- [ ] Use privacy-protecting redaction and tokenisation for audit fields that contain personal information, while keeping the ability to link related records (for example, by using stable hashes), and document the rules.


---

#### AU-3.1 — Additional Audit Information (Enhancement)

This requirement is about ensuring the system’s event records do more than confirm that something happened. They must also include the key details needed to understand who did it and which decision rules were applied. Without this, investigations after an incident can be delayed or fail because you cannot reliably determine what the system allowed or blocked, how it handled the request, or which real person used a shared group account. This increases the risk that wrongdoing goes unnoticed and that innocent people are wrongly blamed.

To meet this expectation, the organisation must configure the system so that, for each relevant event, every audit record includes:
- the identifiers of the access decision rules used,
- the identifiers of the handling rules used, and
- the individual identity of the person acting through any group account.

The organisation must document these requirements in its audit and accountability policy and supporting procedures. It must ensure the system design and configuration are set up to produce these fields, maintain a list of which events are covered, and ensure authorised staff can review the records to confirm the required information is present. Privacy considerations must be addressed in the privacy plan.

##### Audit enrichment with access/flow rule IDs and group-user identity

- Category: Software
- Priority: Critical

###### WHAT must be done
Set up the application and its enforcement components so that generated audit records include the organisation-defined **additional information**: **(1) the access control rule identifiers used, (2) the flow control rule identifiers used, and (3) the individual identity of users acting via a group account**.

###### WHY (control requirement)
NIST AU-3(1) (Enhancement) requires that audit records be generated containing the additional information defined by **param: au-03.01_odp**. The guidance also requires that additional audit information is limited to only what is explicitly needed, to avoid misleading content, make relevant information harder to find, and reduce privacy risk.

###### HOW (specific steps/approach)
1. **Define a standard audit format (schema)** for the three required fields (for example, `access_rule_id`, `flow_rule_id`, `group_user_identity`) and make sure they are filled in for every relevant event.
2. **Record rule identifiers at the decision point**: update and standardise the access-control and flow-control enforcement layers (for example, application programming interface (API) gateway, web application firewall (WAF), reverse proxy, zero trust network access (ZTNA), application authorisation middleware, network policy controller) so that when a decision is made, the audit event includes the **exact rule identifier(s) that were used** (not just whether the action was allowed or denied).
3. **Ensure group-account actions are linked to an individual**: connect to the organisation’s identity provider so the audit event records the **individual principal** acting through any group account (for example, a session-linked identity, workload identity mapping, or step-up identity). Do not record only the group identifier.
4. **Apply a privacy and need-to-know filter**: only add the explicitly required fields, plus the minimum non-sensitive context needed for audit usefulness (for example, timestamp, event type, and target resource identifiers that are already present). Do not add free-text, sensitive content, or unnecessary attributes.
5. **Carry out end-to-end checks**: create automated tests (or scripted integration tests) that trigger representative allow/deny and flow-control decisions, including cases where group accounts are used, and confirm the resulting audit records contain the three required fields with the correct values.
6. **Make evidence operational**: ensure the logging configuration is managed with version control, and that security information and event management (SIEM) and collector mappings keep these fields intact (no renaming, truncation, or suppression).

###### WHO (role responsible)
- **Application Security Engineer / Platform Engineer**: implement audit record enrichment and decision logging in the enforcement layers.
- **Identity and Access Management (IAM) Engineer**: ensure group-account actions are tied to individual identities.
- **Security Operations / SIEM Engineer**: check that data is ingested correctly and that fields are preserved into the SIEM.
- **Privacy Officer (or delegated privacy lead)**: approve the privacy/need-to-know filter for audit enrichment.

###### Acceptance criteria
- For all relevant events, audit records include non-empty values for:
  - `access_rule_id` (identifier of the access control rule used)
  - `flow_rule_id` (identifier of the flow control rule used)
  - `group_user_identity` (individual identity of the person acting via a group account)
- Audit enrichment is limited to the explicitly required additional information (plus minimal existing audit context) and does not include sensitive free-text content.
- Automated tests show correct population of fields for both allow/deny and flow-control decision paths, including when group accounts are used.
- SIEM/collector pipelines preserve the fields end-to-end (no truncation or renaming that would reduce audit usefulness).

###### Actions Required for Compliance

- [ ] Create an audit event format (schema) that includes `access_rule_id`, `flow_rule_id`, and `group_user_identity`, and map it to **au-03.01_odp**.
- [ ] Update the access-control enforcement components so that, at the moment a decision is made, they record the identifier of the access rule that was used in the audit event.
- [ ] Update the flow-control enforcement components so that, at the moment a decision is made, they record the identifier of the flow rule that was used in the audit event.
- [ ] Integrate audit enrichment with enterprise identity and access management (IAM) so that actions involving groups and accounts are recorded under the individual person’s identity (not only the group).
- [ ] Set up a privacy and “need to know” filter so enrichment is limited to only the specific fields that are explicitly required, plus the minimum existing audit information.
- [ ] Set up automated integration tests that create “allow/deny” and “flow-control” events (including cases involving group accounts) and check that the three required fields are present and correct.
- [ ] Check that security information and event management (SIEM) and collector data ingestion keeps the three required fields unchanged from start to finish (no truncation, suppression, or renaming).


---

#### AU-3.3 — Limit Personally Identifiable Information Elements (Enhancement)

This requirement is about making sure audit logs do not accidentally store too much personal information about people. Audit records are used to show what happened in a system. However, if they include unnecessary personal details, that extra information could be misused, exposed, or cause privacy harm—even if the original purpose was only to record events.

To meet this expectation, the organisation must ensure that audit records contain only the specific items identified in its privacy risk assessment: a pseudonymised user identifier (so it cannot directly identify the person), the source Internet Protocol (IP) address, the event time and date, the system identifier, and the access result.

The organisation should base what goes into audit records on the results of the privacy risk assessment, put clear procedures in place for what is allowed, and be able to demonstrate that no other personal information is added to audit records.

##### Enforce audit log PII allowlist with pseudonymised user identifier

- Category: Software
- Priority: Critical

###### WHAT
Put in place an auditable enforcement process that limits personally identifiable information (PII) in audit records to only the elements agreed in the privacy risk assessment: **user identifier (pseudonymised), source Internet Protocol (IP) address, event date and time, system identifier, access outcome**.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **AU-3(3)** (enhancement) requires that audit records include only the PII elements identified in the privacy risk assessment (parameter **au-03.03_odp: elements**). Reducing unnecessary PII in audit records lowers privacy risk.

###### HOW (specific steps/approach)
1. **Create an “Audit Record PII Allowlist”** based directly on the privacy risk assessment, and link each allowed element to the exact log field names produced by each component (application, operating system, middleware, network/security devices, and any operational technology (OT) gateway/historian if applicable).
2. **Pseudonymise the user identifier** as part of the log creation process (for example, one-way tokenisation or hashing based on a hash-based message authentication code (HMAC), using a secret stored in a secrets manager). Make sure the pseudonymised value is consistent enough to link related events, but cannot be used to directly identify the person.
3. **Limit log content to the allowlist** at the source where possible (turn off or omit fields such as raw usernames, email addresses, free-text messages that may include personal data, and user-agent strings if they can include identifiers). If this is not possible at the source, use a **controlled transformation/normalisation step** that removes any fields not on the allowlist before events are written to the audit store/security information and event management (SIEM).
4. **Apply the configuration consistently using policy-as-code** (for example, infrastructure-as-code templates and logging policy modules) so that production, testing, and disaster recovery environments—and new deployments—cannot add extra PII fields without review.
5. **Add automated checks** to confirm that every audit event matches the allowlist (only the five permitted PII elements are present; no other fields containing PII). Stop builds/deployments if the checks find any disallowed fields.
6. **Produce audit-ready evidence** by regularly sampling audit records and generating a report that shows field-by-field compliance with the allowlist, including confirmation that the user identifier is pseudonymised.

###### WHO (role responsible)
- **Application Logging Owner / Engineering Lead**: updates the logging structure and implements pseudonymisation in the application/log creation process.
- **Security Engineering / Privacy Officer (or a delegated privacy role)**: approves the allowlist derived from the privacy risk assessment and signs off on changes.
- **Platform/Infrastructure Team**: implements policy-as-code enforcement and the transformation step where needed.
- **SIEM/Monitoring Administrator**: ensures the audit store ingestion process removes/normalises disallowed fields and supports the compliance reporting.

###### Acceptance criteria
- Audit records contain **only** the five permitted PII elements: **pseudonymised user identifier, source IP address, event date and time, system identifier, access outcome**.
- The user identifier in audit records is **pseudonymised** (not directly identifying) and generated using the approved method.
- Automated conformance checks show that **no additional PII elements** appear in sampled audit events across representative systems and environments.
- Evidence is available (reports and sample extracts) demonstrating allowlist compliance and that the enforcement is working effectively.

###### Actions Required for Compliance

- [ ] Identify and document the exact personal data (PII) elements that are allowed for audit purposes, based on the privacy risk assessment (AU-03.03 ODP: elements), and match each allowed element to the specific log field names used by each system.
- [ ] Set up pseudonymisation for the user identifier in the audit logging process by replacing it with a one-way token (hash) generated using a securely managed secret.
- [ ] Set up logging for the application, operating system, and middleware so it records only the approved (allowlisted) fields. Turn off or omit common fields that may contain personal information (PII), and remove free-text that could include personal data.
- [ ] Set up a controlled process for changing and standardising logs (or a security information and event management (SIEM) input rule) to remove any fields that are not on the approved allowlist before the events are saved.
- [ ] Set up automated policy enforcement to control which logging fields are allowed in each environment, and stop (block) any deployment that adds fields that are not permitted.
- [ ] Run automated checks on the audit records that are produced, and regularly review a sample of stored audit records to provide evidence of compliance.


---

### AU-4 — Audit Log Storage Capacity (Control)

This requirement is about making sure your organisation has enough storage space to keep a complete record of important system activity for long enough. If audit logs run out of storage, records may be deleted early, or logging may be reduced or stopped. This makes it harder to investigate incidents, prove what happened, and meet legal or contractual obligations—especially when some records are more sensitive.

The organisation must plan and document how audit log storage is managed, so that all audit records are kept for at least 365 days, including audit logs that contain Confidential and Secret information. It must also configure each relevant system so its audit records are stored for the full 365 days in practice, not just on paper, and keep clear evidence of the storage and retention settings used.

Finally, it must have practical procedures to monitor storage capacity and take timely action if capacity is at risk, so audit logging capability is never lost due to storage limits.

##### Provision audit log storage for 365 days (incl. Confidential/Secret)

- Category: Manual
- Priority: Critical

###### WHAT
Set aside and prepare enough storage for audit logs so they are kept for **at least 365 days** for **all types of audit logs**, including audit logs that contain **Confidential and Secret** information.

###### WHY (control requirement)
AU-4 requires the organisation to **set aside enough storage for audit logs** to meet the organisation’s defined **audit log retention requirements** (parameter **au-04_odp**). The guidance explains that having enough storage reduces the risk of reaching storage limits, which can otherwise cause **audit logging to be lost or reduced**.

###### HOW (specific approach)
1. **Set the storage target**: set the audit log storage/retention target to **365 days minimum** for all audit logs, explicitly including **Confidential and Secret** audit events (as per **au-04_odp: 365 days for all audit logs, including Confidential and Secret data**).
2. **Size storage using real intake volumes**: work out how much storage is needed based on recent audit event volume (events per day), average event size, indexing and other overheads, compression, any replication/retention overhead (if applicable), and expected growth. Add operational headroom (for example, a growth buffer) so storage is not exceeded.
3. **Apply retention rules in the logging process**: configure the security information and event management (SIEM) / logging platform and any log routing or forwarding components so logs cannot be removed or shortened before **365 days**. Make sure **Confidential and Secret** audit events are sent to the same or a longer-retention storage tier.
4. **Include every system that creates audit records**: check that each system/component that produces audit records (including applications, identity systems, network activity, admin actions, and any operational technology (OT) or edge gateways if present) forwards/stores audit logs for **365 days**—either centrally, or locally using buffering/retention where forwarding is not practical.
5. **Monitor storage and have clear response steps**: set alerts for storage capacity headroom and log intake backlogs, and prepare runbooks for timely actions (for example, increase storage, adjust rollover/archiving, increase log intake capacity, or temporarily increase buffering) to prevent loss or reduction of audit logging.
6. **Keep audit-ready proof**: retain evidence of (a) the configured retention settings, (b) the storage capacity sizing calculation and its inputs, and (c) the monitoring/alert configuration and recent alert history.

###### WHO
- **Security Engineering / SIEM Log Engineering Lead**: designs retention tiers, routing, and enforcement.
- **Infrastructure/Platform Engineering**: provides storage capacity and scaling mechanisms.
- **Application Owners / System Owners**: confirm their systems’ audit logs are captured and kept for **365 days**.
- **SOC / Security Operations**: manages monitoring alerts and runbooks.
- **Compliance / Governance, Risk and Compliance (GRC)**: checks the evidence and ensures alignment to AU-4 and the system documentation.

###### Acceptance criteria
- The organisation can show that **all audit logs** are kept for **at least 365 days**, including those classified as **Confidential and Secret**.
- The configured logging/SIEM retention settings and routing rules show **no removal or deletion before 365 days** for any audit log tier.
- A documented storage capacity sizing calculation exists, matches current/expected log intake rates, and shows the provisioned capacity meets the **365-day** requirement.
- Storage capacity monitoring is in place with alerts and runbooks, and evidence shows alerts are triggered before storage runs out.
- Evidence is available showing each audit log source/component is configured to meet the **365-day** retention requirement (either directly or through forwarding/buffering).

###### Actions Required for Compliance

- [ ] Confirm and record that audit logs must be kept for 365 days for all audit logs, including Confidential and Secret data (au-04_odp).
- [ ] Work out how much audit log storage is needed by using the measured rate at which logs are collected, the typical size of log events, any extra storage needed for indexing and other overheads, and the expected future growth—plus additional headroom.
- [ ] Set the central logging and security information and event management (SIEM) retention rules so that all audit log categories are kept for at least 365 days, and make sure that all Confidential and Secret events are sent to a storage tier that keeps them for at least 365 days.
- [ ] Check that every audit log source and component sends or stores audit records so that they are kept for at least 365 days, including any local temporary storage used when sending is not immediate.
- [ ] Set up monitoring of storage capacity with alerts when available space or queued items fall below agreed thresholds. Create step-by-step runbooks for increasing capacity or reconfiguring the system to prevent loss of audit logs.
- [ ] Collect and store evidence suitable for audit purposes, including: retention configuration exports, inputs and outputs from the capacity sizing model, and monitoring and alert settings along with recent alert history.


---

#### AU-4.1 — Transfer to Alternate Storage (Enhancement)

This requirement is about making sure your records of important system activity do not remain only on the same computer that created them. If audit logs are not moved promptly to a separate location, you risk losing evidence if storage becomes full, if a system fails, or if someone tries to tamper with the records. This can make investigations and compliance checks much harder.  

To meet this expectation, the organisation must move each set of audit logs to a different system, part of a system, or storage media within 24 hours of the logs being created, using a destination that is clearly separate from the source. The organisation must also be able to prove that the move took place by keeping records of the transfer, and must ensure the transferred logs are actually present in the alternate storage.

##### Off-load audit logs to alternate storage within 24 hours

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated process to move audit logs from the system or component that creates them to a different system, component, or storage location, **within 24 hours of the audit log being created**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **AU-4(1)** requires that **audit logs are transferred** to a **different system, system component, or storage location** than the one that generated them, at the **frequency defined by the organisation** (here: **within 24 hours of audit log generation**).

###### HOW (specific steps/approach)
1. **Define the transfer boundary and destination**: list every audit log source (application/service/host) and set up a **separate** transfer destination (for example, a dedicated log server, a separate security information and event management (SIEM) intake point, or a separate object storage area with different access controls). Make sure the destination is **not** the same system/component/storage location as the source.
2. **Use store-and-forward with measured transfer time**: send audit events to a transfer service that saves them to a **reliable queue/buffer** straight away, then sends them to the alternate destination in the background. Set up retry and delay behaviour, and size the queue so that, even when things run worse than normal, the **total time from creation to arrival** stays within **24 hours**.
3. **Create transfer records (evidence)**: for each batch/section that is moved, record transfer details (source identifier, destination identifier, batch ID, time of first and last event, transfer start and end time, status, and any error information). Keep these records in a way that supports audit checks.
4. **Confirm the logs arrived**: after writing to the alternate destination, run automated checks (for example, a confirmation that the write succeeded, plus periodic checks that batch IDs exist and can be retrieved from the alternate destination).
5. **Secure the transfer path**: require mutual Transport Layer Security (TLS), use least-privilege service identities, and restrict network access so that only the transfer service can write to the alternate destination.
6. **Alert if the 24-hour target is at risk**: add monitoring that calculates the “age of the oldest audit event not yet transferred” for each source, and raises alerts when it is nearing the **24-hour** limit or when transfers fail.

###### WHO
- **Application/Platform Engineering Lead**: responsible for building the transfer pipeline and connecting to the destination.
- **Security Engineering (SIEM/Logging)**: sets the destination, integrity and retention expectations, and defines monitoring and alerting.
- **Operations/DevOps**: ensures queue sizing, runbooks, and operational monitoring are in place.

###### Acceptance criteria
- For each audit log source, the organisation can show that **all audit events are transferred to the alternate destination within 24 hours of being created** (confirmed using transfer records and reconciliation).
- The alternate destination is clearly **different** from the logging source (separate system/component/storage location).
- Transfer records exist for transferred batches, including success/failure and timestamps.
- Automated checks confirm that transferred logs are present and can be retrieved from the alternate destination.
- Monitoring and alerts activate when transfer delays approach or exceed 24 hours, and transfer failures are visible for investigation.

###### Actions Required for Compliance

- [ ] Identify every audit log source and, for each one, set a single backup destination that is different from the original system, component, or storage media.
- [ ] Set up a store-and-forward off-load service that uses a reliable queue and automatic retry logic, so transfers can be completed at least every 24 hours.
- [ ] Set up audit log forwarding so that the time delay can be measured from when an event is created to when it is successfully written to the alternate storage location.
- [ ] For each batch or segment, create and save transfer records that include the source and destination identifiers, the date and time, the current status, and any errors.
- [ ] Add automated checks to confirm that transferred batches arrive at the alternate destination and can be retrieved there.
- [ ] Set up mutual Transport Layer Security (mutual TLS), use service identities with the minimum required permissions (least privilege), and restrict network access for the data transfer route.
- [ ] Set up monitoring and alerts when the “age of the oldest event that has not yet been transferred” is nearing or has passed 24 hours, and when event transfers fail.


---

### AU-5 — Response to Audit Logging Process Failures (Control)

This requirement ensures that if the system that records important activity stops working correctly, the right people are informed immediately and the organisation can still understand what happened. Without this, you could lose or overwrite the very records needed to investigate issues, confirm what occurred, and respond quickly to wrongdoing or mistakes—particularly if the log storage becomes full or the recording function fails.

Within 15 minutes of identifying an audit logging process failure, the organisation must alert the Security Operations Centre on-call lead, the system owner, and the incident response lead. It must then also notify the Security Operations Centre and the incident response lead, preserve relevant evidence so it cannot be lost, and assess what impact the failure may have had.

The organisation should only stop or slow down audit logging when it is necessary to prevent further loss of audit records.

##### AU-5 automated audit logging failure escalation with evidence capture

- Category: Software
- Priority: Critical

###### WHAT
Set up automated detection and coordinated response for **failures in the audit logging process** (for example, errors when capturing or sending audit logs, failures in the audit system’s health, and audit log storage reaching capacity limits). If a failure is detected, the system must **alert the designated roles within 15 minutes**, and then take **additional actions**. These include **preserving evidence**, **checking the likely impact**, and **stopping or slowing down audit logging only when necessary to prevent further loss of audit log records**.

###### WHY (control requirement)
AU-5 requires the organisation to respond to audit logging process failures by taking actions defined by the organisation, including:
- **Alerting the right people/roles** (as defined by the organisation) **within 15 minutes** of detecting the failure.
- Taking **additional actions** (as defined by the organisation), such as notifying the security operations centre (SOC) and incident response team, **preserving evidence**, and **checking the likely impact**.
- Taking **stop or throttle actions only when necessary to prevent further loss of audit log records**.

###### HOW (specific steps/approach)
###### 1) Define failure detection signals and map where they apply
- Create a mapping between each **audit log repository** (the separate component where audit logs are stored) and the monitoring information that shows:
  - audit log capture or forwarding failures (collector/agent errors, ingestion errors, pipeline error codes)
  - audit system health failures (audit service down or not healthy)
  - storage capacity risk (approaching, at, or over a defined threshold)
- Make sure the response system can apply actions at the correct level: **repository**, **system**, and/or the organisation’s **total storage capacity**, based on how your organisation defines scope.

###### 2) Build an automated detection-to-escalation process (time to first notification)
- Set up monitoring and alert rules so they trigger immediately for any AU-5 failure signal.
- Use an orchestration workflow (security operations automation) that:
  - creates an incident or ticket
  - sends the **first notifications** to the organisation-defined roles:
    - **SOC on-call lead**
    - **information system owner**
    - **incident response lead**
  - meets the **15-minute** requirement by escalating to an alternate contact method (for example, phone/text/voice escalation) if acknowledgement is not received quickly.

###### 3) Automatically preserve evidence (restricted, reviewable records)
- When triggered, automatically collect and store in a restricted evidence location:
  - failure indicators (error logs, error codes, health check results)
  - relevant pipeline performance information (ingestion delay, queue/backlog depth, drop counts)
  - configuration snapshots (audit logging configuration, collector/forwarder configuration, security information and event management (SIEM) or log storage routing configuration)
  - the system/audit service status at the time the failure was detected
- Ensure the evidence is time-stamped and linked to the incident record.

###### 4) Prompt for impact assessment and require completion before closing
- Require structured information in the incident workflow for:
  - affected audit log repository or system
  - start time and estimated duration
  - completeness risk (for example, gaps, delays, or drop rate)
  - affected event types (if it can be determined)
- Route the incident to the incident response lead to complete the assessment.

###### 5) Conditional stop or throttling with clear justification and safeguards
- Add policy safeguards so the workflow can **stop or slow down audit logging** only when storage-risk conditions are met (for example, the repository is at/over capacity or there is an imminent risk of losing audit log records).
- Require an explicit justification, including the decision rationale, scope, and time window.
- Default behaviour: notify, preserve evidence, and assess impact; do not stop or throttle unless the safeguards’ conditions are met.

###### WHO
- **SOC on-call lead**: receives the initial alert within 15 minutes and coordinates triage.
- **Information system owner**: receives the initial alert and confirms the relevant system/audit system context.
- **Incident response lead**: receives the initial alert and is responsible for the impact assessment and response decisions.
- **Platform or observability engineering (implementation owner)**: implements the detection rules, orchestration workflow, evidence capture, and stop/throttle safeguards.

###### Acceptance criteria
- For each detected audit logging process failure, the workflow sends the **first notification** to **SOC on-call lead, information system owner, and incident response lead** within **15 minutes**.
- Evidence records captured include failure indicators, relevant performance information, and configuration/system status, stored in a restricted location and linked to the incident.
- The incident workflow requires the incident response lead to complete an **impact assessment** before closure.
- The workflow performs **stop/throttle actions only** when the storage-risk safeguards are met, and records the justification, scope, and timestamps.
- For storage-related failures, the workflow applies actions at the correct **audit log repository/system/total capacity scope** as defined by the organisation.

###### Actions Required for Compliance

- [ ] Define what “audit logging failure” looks like, and match each failure signal to the correct audit log repository or system and to the relevant total capacity scope.
- [ ] Set up monitoring alerts that trigger immediately if audit records fail to be captured or forwarded, or if storage capacity reaches a defined threshold.
- [ ] Set up an automated workflow that sends the first alert to the security operations centre (SOC) on-call lead, the information system owner, and the incident response lead within 15 minutes.
- [ ] Automate the capture of restricted evidence (such as failure indicators, performance metrics, configuration snapshots, and audit and system status) and link it to the incident.
- [ ] Add an impact assessment form with required fields, and route completion to the incident response lead.
- [ ] Set policy safeguards so that any stop or slow-down actions are taken only when the storage-risk conditions are met, and record the reason, the scope, and the date and time.


---

#### AU-5.1 — Storage Capacity Warning (Enhancement)

This requirement ensures that the people responsible for storing audit logs are warned early when there is not much space left to keep them. If the storage fills up without warning, important records of system activity may stop being saved or may be lost. This makes it harder to investigate problems, identify misuse, or confirm what happened when something goes wrong.

To meet this expectation, the organisation must set up monitoring for every audit log storage location, even if they are managed in different parts of the business. An alert must be triggered when each location reaches 80% of its maximum allocated storage.

When a storage location reaches 80%, the organisation must send a warning within 1 hour to both:
- the audit log storage administrator, and
- the information system owner for that same storage location.

This must be done for the correct repository and to both named roles—not to only one person and not to the wrong contacts.

The organisation must also be able to demonstrate the warning process, the named recipients, and evidence that warnings were sent on time.

##### Per-repository 80% audit log capacity warnings to named owners

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated warning for each audit log storage repository. The warning must trigger when that repository’s used audit log storage reaches **80%** of its **maximum allowed capacity**, and it must be sent to **the audit log repository administrator** and **the information system owner**.

###### WHY (control requirement)
AU-5(1) enhancement requires: “Provide a warning to {{personnel/roles/locations}} within {{time period}} when allocated audit log storage volume reaches {{percentage}} of repository maximum audit log storage capacity.”

This solution directly satisfies:
- **Recipients**: audit log repository administrator and information system owner (AU-5(1) param au-05.01_odp.01)
- **Timing**: warning delivered **within 1 hour** (au-05.01_odp.02)
- **Threshold**: trigger at **80%** (au-05.01_odp.03)
- **Multiple repositories**: each repository is monitored separately (control guidance)

###### HOW (specific steps/approach)
1. **Create and keep an up-to-date repository inventory** that maps each audit log storage repository to:
   - repository identifier
   - maximum allocated capacity
   - the two recipients: audit log repository administrator and information system owner (from the organisation’s responsibility and ownership register, for example RACI)

2. **Make sure the audit log storage platform provides accurate capacity figures for each repository**, such as:
   - “allocated audit log storage used” (current usage)
   - “maximum allocated audit log storage capacity” (maximum)
   Ensure these figures are clearly labelled with the repository identifier, so alerts cannot be sent to the wrong repository.

3. **Set up alert rules for each repository** so they trigger when usage is **>= 80%** (au-05.01_odp.03). Use a “first breach” approach (deduplication) so people are not repeatedly notified, while still ensuring the first warning is sent.

4. **Create an automated notification process** that, when an alert triggers, sends the warning to **both** recipients (AU-5(1) param au-05.01_odp.01) **within 60 minutes** of the threshold being reached. The message must include:
   - repository identifier
   - usage percentage, maximum capacity, and the current date/time
   - threshold value (80%)
   - a link or reference to the repository monitoring view

5. **Demonstrate timing and traceability** by saving evidence for every warning, including:
   - alert trigger date/time
   - notification sent date/time
   - list of recipients (both parties)
   - repository identifier
   Store this evidence in an auditable system (for example a ticket/IT service management record, or an audit log history with tamper-resistant retention).

6. **Test using a controlled simulation** in a non-production environment (or a staging repository) to confirm:
   - the repository mapping is correct
   - the 80% threshold behaviour is correct
   - notifications are sent to both recipients
   - the worst-case end-to-end delay is **less than 60 minutes**

###### WHO
- **Security and compliance engineer**: defines the control mapping, what evidence must be kept, and what “acceptable” looks like.
- **Security information and event management (SIEM) / logging platform engineer (or site reliability engineering (SRE) / platform team)**: implements the capacity reporting, alert rules, and notification process.
- **IT service management (ITSM) / operations team**: ensures the notification method and evidence retention meet audit needs.

###### Acceptance criteria
- For every configured audit log storage repository, an alert triggers at **80%** allocated usage.
- When a repository reaches the threshold, warnings are sent to **both** the audit log repository administrator and the information system owner.
- For tested scenarios, the time from threshold breach to notification being sent is **<= 60 minutes**.
- For every warning event, auditable evidence exists showing the repository identifier, recipients, and timestamps.
- Alerts are repository-specific (no incorrect cross-repository notifications).

###### Actions Required for Compliance

- [ ] Create an official list of every audit log storage repository, including its maximum storage capacity, and name the two required recipients: the repository administrator and the information system owner.
- [ ] Set up the audit log storage system to report, for each repository, how much storage it has been allocated to use and the maximum storage capacity it is allowed to use.
- [ ] Set up alert rules for each repository so you are notified when used capacity reaches 80% or more of the maximum. Use duplicate-suppression to avoid repeated alerts that could overwhelm people.
- [ ] Set up an automated process that sends the warning to both recipients and includes the repository ID, the usage percentage, the threshold, and the relevant dates and times.
- [ ] Configure alert checking and message sending so that alerts are delivered end to end within 60 minutes of reaching an 80% breach level.
- [ ] For every warning event, record permanent (unchangeable) evidence—such as the alert time, when the message was sent, the recipients, and the repository ID—and keep it for audit purposes.
- [ ] Carry out a controlled test to confirm that the repository is mapped correctly, alerts trigger at the right threshold, messages are sent to two recipients, and delivery happens within 60 minutes.


---

#### AU-5.2 — Real-time Alerts (Enhancement)

This requirement is about making sure you are warned immediately if your system’s record-keeping stops working properly, so problems are identified and dealt with quickly. If alerts are delayed or not sent when audit records cannot be created, when the storage location for those records runs out of space, or when the records cannot be sent to the correct destination, you risk losing evidence of what happened. This can delay investigations and may also mean the organisation does not meet its legal or regulatory responsibilities.

To meet this requirement, the organisation must automatically send a real-time alert within 5 seconds of detecting any of these three types of audit logging failure to both the Security Operations Centre (SOC) on-call incident responder and the system owner. The alert must always reach the right people, clearly say which type of failure occurred, and still be sent promptly even if multiple failures happen close together.

##### Real-time alerts for audit logging failures (≤5s) to SOC + owner

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, event-triggered alert system that sends a real-time alert **within 5 seconds** to:
1. the **Security Operations Centre (SOC) on-call incident responder**, and  
2. the **system owner**,  

whenever any of these audit failure events happen:
- audit log generation failures
- audit log storage running out of space
- audit log transmission failures

###### WHY (control requirement)
The **National Institute of Standards and Technology (NIST) AU-5(2) enhancement** requires: “Provide an alert within {{ param, au-05.02_odp.01 }} to {{ param, au-05.02_odp.02 }} when the following audit failure events occur: {{ param, au-05.02_odp.03 }}.” It also requires real-time delivery (within seconds or less).

###### HOW (specific steps/approach)
###### 1) Identify and categorise the three failure types at the point of detection
Update the audit logging process and/or the audit agent/forwarder parts so they detect and report a clear “audit failure event” for each category:
- **Generation failure**: the system cannot create or write audit records (for example, audit service errors or audit record write failures).
- **Storage running out of space**: the audit buffer/queue/disk/retention storage is almost full, or cannot accept more audit records.
- **Transmission failure**: the system cannot send audit logs to the configured destination (for example, forwarder errors, the receiver is unreachable, or secure connection (TLS) or session failures).

Each reported event must include:
- failure type (generation/storage/transmission)
- the affected component/system identifier
- the event detection time (monotonic/UTC) and a correlation ID
- severity (mapped to the alerting process)

###### 2) Send alerts immediately, with a strict time limit (≤5 seconds)
Create an alert process that starts directly when the audit failure event is reported (no waiting to batch events) and guarantees **≤5 seconds** from detection to alert delivery.
- Configure the alerting integration in “immediate” mode for these specific failure types.
- Do not suppress these events. Use **idempotency based on the correlation ID** so that quick repeated failures still create separate alerts.

###### 3) Send the alert to both required recipients using reliable delivery
For each failure event, send the alert to:
- **Security Operations Centre (SOC) on-call incident responder** (for example, paging/incident escalation channel)
- **System owner** (for example, authenticated messaging, plus ticket/short message service (SMS)/phone call fallback if your organisation uses it)

The alert message must clearly state the failure type and include the correlation ID and detection time so responders can triage quickly.

###### 4) Keep evidence of timing and delivery
For each alert sent, record the following in an audit trail separate from the failing audit pipeline:
- correlation ID
- detection timestamp
- alert creation timestamp
- delivery timestamps for each recipient channel
- delivery result (success/failure) and any retry attempts

###### 5) Test using fault-injection in a staging environment
In a staging environment that matches the production setup, simulate each failure type and confirm:
- both recipients receive the alert
- the time from trigger to receipt is **≤5 seconds**
- multiple failures close together still produce separate alerts

###### WHO
- **Security Operations Centre (SOC) on-call incident responder**: receives and acknowledges alerts; helps validate the alert content.
- **System owner**: receives alerts and ensures responsibility for fixing the issue.
- **Application/Platform engineering (audit pipeline owners)**: implements detection, event reporting, and the alert workflow.
- **Security engineering / security information and event management (SIEM) and security orchestration, automation and response (SOAR) administrators**: sets up routing, delivery behaviour, and evidence logging.

###### Acceptance criteria
1. For each of the three failure types (generation, storage running out of space, transmission), an alert is delivered to **both** the Security Operations Centre (SOC) on-call incident responder and the system owner **within 5 seconds** of detection.
2. Alert content includes: failure type, affected system/component, correlation ID, and detection timestamp.
3. Quick repeated failures result in separate alerts (no suppression for these failure types), while idempotency prevents duplicate alerts for the same correlation ID.
4. Evidence is available showing detection-to-delivery timing for each recipient channel for every test case.
5. Fault-injection tests prove compliance in staging using production-like routing and recipient settings.

###### Actions Required for Compliance

- [ ] Set up the audit logging process to automatically detect and record structured events when there are failures in generating logs, running out of storage space, or sending data.
- [ ] Set up an immediate alert process (no batching) that triggers every time an audit failure is recorded, and ensure the alert is delivered end-to-end within 5 seconds.
- [ ] Set up alert routing so notifications are sent to both the security operations centre (SOC) on-call incident responder and the system owner, using reliable paging and messaging methods.
- [ ] Add “can be safely repeated” behaviour using the correlation identifier to prevent duplicate alerts, while still allowing separate alerts for rapid successive failures.
- [ ] Create an auditable record of alert evidence (including the time the alert was detected, when the alert was created, the delivery time for each recipient, and the final outcome) outside the failing audit process path.
- [ ] Run fault-injection tests in the staging environment for all three failure types, and confirm that both recipients receive the result within 5 seconds of the trigger.


---

#### AU-5.3 — Configurable Traffic Volume Thresholds (Enhancement)

This requirement is about preventing your system from being overwhelmed by too much network activity when that would cause your audit records to run out of storage. If the system keeps trying to save audit records while the log storage is full, you could lose the ability to prove what happened, investigate issues, or meet legal and internal responsibilities.

To meet this expectation, the organisation must first work out the maximum audit-record storage capacity it can safely handle. It must then set adjustable limits on how much network traffic the system will accept, based on that capacity, and clearly document how those limits were calculated.

During processing, the system must monitor network traffic volume. If it exceeds the configured limits, it must follow the agreed response behaviour. In this case, the organisation’s chosen option is **delay**, so processing must be delayed to prevent audit logging from exhausting storage.

The organisation must also:
- keep records of the threshold settings and the delay/reject choice
- ensure this approach is covered in its plans and design documents
- provide procedures for audit processing failures
- keep audit records that show when traffic exceeded limits and when the system delayed processing

##### Configurable network traffic thresholds with delay on audit-log pressure

- Category: Software
- Priority: Critical

###### WHAT
Set up a control that continuously measures network communication traffic volume and compares it with **configurable thresholds** based on the organisation’s **audit log storage capacity**. If the traffic volume goes above the configured threshold, the system must apply the organisation-defined response behaviour for this control: **delay**.

###### WHY (control requirement)
NIST AU-5(3) (enhancement) requires the organisation to **enforce configurable network communication traffic volume thresholds** that reflect limits on **audit log storage capacity**. It also requires the organisation to **reject or delay processing** of network communication traffic when audit logging information would exceed the storage capacity. The “exceed” action must be triggered by the established thresholds and must be adjustable when audit log storage capacity changes.

###### HOW (specific steps/approach)
1. **Convert audit log capacity into a traffic “audit-pressure” budget**: work out the maximum sustainable audit logging throughput (for example, bytes per second and/or events per second) based on audit log storage capacity, retention period, compression, and the largest expected audit event size.
2. **Convert the budget into traffic volume thresholds**: translate measurable network traffic indicators at the point of entry (for example, new connections per second, requests per second, bytes per second, or session rate from IPFIX/NetFlow) into the expected audit log generation rate using monitoring data and load testing. Create at least two thresholds: a main threshold that triggers the exceed response, and (optionally) a lower warning threshold for operational visibility.
3. **Enforce the thresholds at network entry using configurable settings**: configure an edge enforcement component (for example, an application programming interface (API) gateway, web application firewall (WAF)/next-generation firewall (NGFW), traffic manager, or service mesh entry point) to:
   - measure current traffic volume over a defined measurement window,
   - compare it to the **active** thresholds,
   - when exceeded, apply the configured **delay** action (for example, queue/hold with a bounded waiting time, or slow down acceptance of requests) instead of allowing unlimited processing.
4. **Allow threshold updates without weakening enforcement**: store the threshold values and the exceed action in a central configuration service (or a version-controlled policy). Ensure the enforcement layer can reload/update thresholds when changes are made.
5. **Keep records showing when thresholds were exceeded and what action was taken**: ensure the enforcement component produces security-relevant logs/events that include (a) the threshold value, (b) the measured traffic volume, (c) the time the threshold was exceeded, and (d) that **delay** was applied. Ensure these events are sent to the organisation’s audit logging pipeline.
6. **Update procedures for audit-processing problems**: update operational runbooks so that if audit logging is degraded or unavailable while delay is active, staff know how to respond (for example, fail-safe behaviour, escalation, and confirmation that audit evidence is still being captured as required).

###### WHO
- **Security Architect / Compliance Lead**: approves the method for converting capacity to thresholds and the acceptance criteria.
- **Network/Security Engineering (Edge Platform Owner)**: implements and runs the ingress enforcement configuration.
- **Application Owner / Site Reliability Engineering (SRE)**: validates the telemetry-to-threshold mapping, measurement windows, and runbook updates.
- **Security Operations Centre (SOC) / security information and event management (SIEM) Operations**: ensures exceedance events are correctly collected and retained.

###### Acceptance criteria
- The system enforces **configurable** network traffic volume thresholds derived from audit log storage capacity.
- When measured traffic exceeds the configured threshold, the system applies the organisation-defined response **delay** (not rejection) in a bounded, predictable way.
- Thresholds can be updated when audit log storage capacity changes, and enforcement uses the **currently active** configuration.
- Audit evidence exists showing when thresholds were exceeded and that **delay** was applied (including timestamps and measured values).
- Operational procedures/runbooks cover how to handle audit-processing failures related to this enforcement mechanism.

###### Actions Required for Compliance

- [ ] Calculate the maximum sustainable rate at which audit logs can be written, based on the audit log storage capacity, how long logs are kept, how much they are compressed, and the largest expected audit event size (in the worst case).
- [ ] Define clear, measurable measures of incoming (ingress) traffic and set traffic volume limits that match the audit log processing capacity budget.
- [ ] Set up the ingress enforcement component to compare the current traffic level against the active limits, and when the limit is exceeded, apply the configured action: **delay**.
- [ ] Set up dynamic configuration management so that, when audit log storage capacity changes, the threshold values and the action taken when thresholds are exceeded can be updated.
- [ ] Set up and check security logs for when traffic exceeds a set threshold, recording the measured traffic, the threshold value, and the time the delay was activated.
- [ ] Update the audit-processing failure procedures to explain how to operate and check that systems behave correctly when audit logging is degraded and a delay has been triggered.


---

#### AU-5.4 — Shutdown on Failure (Enhancement)

This requirement is about what the system should do if it cannot record and send important activity information for long enough to matter. If audit logs cannot be created or sent to the organisation’s central record for more than 15 minutes, it becomes harder to spot wrongdoing, investigate incidents, or confirm what happened. This increases the risk of fraud, misuse of data, and weak accountability.

To meet this expectation, the organisation must decide in advance what will happen in this situation. The system must either:
- automatically carry out a partial shutdown, or
- continue running in a reduced, degraded mode with limited mission or business functionality (where appropriate).

When the problem lasts for 15 minutes, the system must automatically apply the chosen response. It should only keep operating normally if an alternative way of logging is available and can be used.

The organisation must record the trigger and the response in its procedures, system design, security plan, and privacy plan where relevant. It must also keep evidence that the system detected the failure and took the required action.

##### Auto partial shutdown/degraded mode on audit log loss >15 mins

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated response that, when **audit log failures** occur—meaning **audit logs stop being created or stop reaching the central audit repository for more than 15 minutes**—the system **automatically starts** the organisation-chosen response: **partial system shutdown** or **degraded operating mode with reduced capability**, **unless** an **alternative audit logging capability** exists and can be used.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **AU-5(4)** enhancement requires the organisation to **use a defined response** when **audit log failures** occur (as defined by the organisation), and to **avoid** the shutdown/degraded action when an **alternative audit logging capability** is available.

###### HOW (specific steps/approach)
1. **Define the trigger and timing in the system**: implement a health check that continuously confirms whether audit events are (a) being created and (b) being successfully sent to the **central audit repository**. Start a timer when either condition fails, and only trigger if the failure continues for **more than 15 minutes**.
2. **Check whether an alternative audit logging capability can be used**: before applying shutdown/degraded actions, confirm that an alternative route is **usable** (for example, a secondary collector/repository can be reached, or local write-ahead buffering is in place with guaranteed later forwarding that is confirmed healthy). The system must not enter the response mode if the alternative capability is confirmed usable.
3. **Automate the response**: when the trigger activates and no alternative capability is usable, automatically carry out the pre-approved response:
   - **Partial system shutdown**: stop or restrict **non-essential** services/components while keeping the minimum needed to maintain safety/continuity.
   - **Degraded mode**: switch to a reduced feature set that limits functionality to **mission/business-essential** operations only.
4. **Keep evidence of detection and action**: create an internal, tamper-evident record (for example, a local event log with integrity protection) that shows: the trigger condition, start/end times, whether alternative logging was usable, and which response was used.
5. **Put it into day-to-day operation with runbooks and configuration**: document the trigger definition, how the response is mapped (what “partial shutdown” vs “degraded mode” means for this application), and the criteria for what counts as an alternative capability in the system’s operational procedures and security documentation.

###### WHO
- **Application Owner / System Owner**: chooses and approves the specific mapping of “partial shutdown” vs “degraded mode” to the application’s services.
- **Security Engineering (Security Information and Event Management (SIEM)/Logging) Team**: implements the audit pipeline health checks, verifies whether alternative logging can be used, and creates the evidence record.
- **Platform/Infrastructure Team**: implements the automated service changes (shutdown/degraded) in the hosting environment (for example, orchestration controls, feature flags, and service scaling/disablement).

###### Acceptance criteria
- If audit log creation or sending to the central repository is unavailable for **more than 15 minutes**, the system automatically enters the configured **partial shutdown** or **degraded mode**.
- If an **alternative audit logging capability** is present and verified as **usable**, the system **does not** enter shutdown/degraded mode.
- The system produces audit-ready evidence showing detection of the failure, the **more than 15 minutes** duration, the decision on alternative-capability usability, and the response taken.
- The response behaviour is consistent across production and disaster-recovery failover scenarios (where applicable) and is validated using controlled fault-injection testing.

###### Actions Required for Compliance

- [ ] Set up an audit pipeline health check that detects when audit logs stop being generated or fail to reach the central repository, and measures how long this takes.
- [ ] Set up a timer that waits for more than 15 minutes of continuous failure, and only triggers once the failure threshold has been exceeded.
- [ ] Add checks to confirm that the alternative audit logging option is usable before taking any action that would shut down or degrade service.
- [ ] Automate the selected response (partial shutdown or reduced service mode) by turning off or limiting non-essential services or features.
- [ ] Create tamper-evident records showing when the trigger started and ended, the decision on whether an alternate capability was used, and which response was carried out.
- [ ] Document, in operational procedures and security documentation, what triggers each response, how the response is chosen, and the criteria for using an alternative capability.


---

#### AU-5.5 — Alternate Audit Logging Capability (Enhancement)

This requirement ensures your organisation can still keep trustworthy records of important user activity even if its main logging system stops working. If the main system fails, key events—such as people logging in, changes to what they are allowed to do, or access to sensitive secret information—may not be recorded or may be lost. This can make it harder to investigate issues, prove what happened, or detect misuse.

To meet this expectation, the organisation must set up an alternative logging route that automatically takes over when the main logging failure is detected, without staff needing to start it manually. While the failure continues, the system must record the relevant events and store them for 24 hours in an on-premises, tamper-resistant, write-once location. This must enforce the full 24-hour retention even if the main logging system starts working again sooner.

The organisation must document: the trigger for switching to the backup logging route, the scope of events covered (which may be only the affected subset), the procedures to follow, the system design, how privacy is handled, and the configuration. It must also assign clear responsibilities so staff can show how the system behaves and provide evidence that it worked as intended.

##### Automatic alternate audit logging to on-prem immutable store (24h)

- Category: Software
- Priority: Critical

###### WHAT
Set up an additional (backup) audit logging capability that automatically starts if the main audit logging stops working. It will record a defined subset of security-relevant audit events (per **au-05.05_odp**) and store them in an **on-premises immutable** system for **24 hours**.

###### WHY (control requirement)
NIST AU-5(5) requires that, if the main audit logging capability fails, the organisation must provide an alternative audit logging capability that supports **au-05.05_odp**. The guidance allows the backup capability to record only a **subset** of the main capability that is affected by the failure.

###### HOW (specific approach)
1. **Define the takeover trigger (clear and testable):**
   - Treat the main audit logging as “failed” when one or more of the following happens, for example:
     - no main audit events are received for a defined time period from a given source (for example, per application, host, or identity provider), or
     - the main log destination/collector shows ongoing errors or timeouts, or
     - the main processing pipeline backlog exceeds a set limit and event loss is detected.
   - Implement this as an automated health-check/telemetry rule.

2. **Set up an alternate ingestion route (separate pipeline):**
   - Deploy a second collector/forwarder layer (using separate hosts, and where possible a separate network route) so it can keep receiving the same security events.
   - Configure this alternate route in **standby**, and make it automatically switch to active recording when the trigger occurs.

3. **Record only the required event subset (au-05.05_odp):**
   - During takeover, capture and keep security-relevant audit events including (at minimum):
     - **logins**,
     - **privilege changes**, and
     - **access to Secret data**.
   - If the application sends these as different event types or fields, convert them into a standard (common) format and filter to include only the documented subset.

4. **Store in an on-premises immutable system with 24-hour retention:**
   - Write events to an on-premises immutable/append-only mechanism (for example, WORM-like object storage, an append-only log service, or tamper-evident ledger-style storage).
   - Configure retention so events captured during the failure period are kept for **exactly 24 hours** (not less due to the main system recovering).

5. **Ensure automatic start and stop behaviour:**
   - When the trigger condition is met, automatically enable the alternate recording and keep it running until the trigger condition clears.
   - Apply retention based on when the events were captured, so the 24-hour requirement is not shortened by main-system recovery.

6. **Provide audit-ready evidence:**
   - Write an immutable marker event to the same immutable store showing when alternate logging was activated and deactivated (including timestamp and reason code).
   - Provide operational dashboards and alerts showing the trigger evaluation, activation time, and event counts for the in-scope subset.

###### WHO
- **Security Engineering / SOC Engineering Lead:** defines the event subset mapping, takeover trigger logic, and immutable storage design.
- **Platform/Infrastructure Engineer:** implements the alternate collectors, network routing, and immutable storage configuration.
- **Application Owner / Identity and Access Management (IAM) Integration Owner:** confirms that login, privilege, and Secret-access events are available for alternate capture and provides field mappings.
- **GRC/Compliance Owner:** checks that the documented subset matches **au-05.05_odp** and that the evidence is suitable for audit.

###### Acceptance criteria
- If main audit logging is intentionally disrupted (for example, the main collector is stopped or the main destination is unreachable), the alternate capability must:
  - start automatically without operator involvement,
  - capture the in-scope events (logins, privilege changes, Secret data access) for the disruption period,
  - write records to the on-premises immutable store,
  - keep captured events for **24 hours** regardless of when the main system recovers,
  - record an immutable activation marker including the trigger reason and timestamps.
- When main logging is restored and the trigger condition clears, alternate recording must stop according to the defined trigger logic, while previously captured events remain available for the full 24-hour retention period.

###### Actions Required for Compliance

- [ ] Define and document the specific conditions that will trigger an objective takeover when primary audit logging fails, including the failure thresholds and how often those conditions are checked.
- [ ] Set up an independent backup event intake pipeline, using separate collectors and hosts (and, where possible, separate routing), configured so it can be automatically activated.
- [ ] Identify and filter application and identity and access management (IAM) audit events so the alternate pipeline includes only the au-05.05_odp subset (logins, privilege changes, and access to secret data).
- [ ] Set up an on-premises audit log that cannot be changed (append-only) and keep it for 24 hours, based on when each event was recorded.
- [ ] Add permanent (unchangeable) activation and deactivation marker events to the same data store, including the time and a reason code.
- [ ] Run a controlled test that deliberately causes a failure to confirm that the system automatically switches over correctly, records the correct set of events, and keeps those records for 24 hours even after the main system has recovered.


---

### AU-6 — Audit Record Review, Analysis, and Reporting (Control)

This requirement is about regularly checking the organisation’s activity records to spot suspicious behaviour early, understand what it could mean, and respond appropriately. The organisation must review and analyse audit logs for signs of someone gaining extra privileges, unusual or suspicious logins, evidence that data may be leaving the organisation, and any actions that break security rules or change system settings. For high-risk systems, this must be done every day; for all other systems, it must be done every week. After each review, the organisation must judge the potential harm if the activity is real.

The organisation must report the findings to the incident response team and the information security office. The organisation must also be prepared to increase or reduce how often, how widely, and how deeply these checks are carried out when the organisation’s risk level changes, based on information from law enforcement, intelligence sources, or other credible information.

To make this work consistently, the organisation must document the process, assign responsibilities, include it in relevant plans and policies, and keep records of findings and actions taken.

##### SIEM/SOAR audit log review with daily/weekly cadence and impact reporting

- Category: Software
- Priority: Critical

###### WHAT
Set up a central capability to review and analyse audit records using a security information and event management (SIEM) and security orchestration, automation and response (SOAR) platform. This capability will:
1. Review and analyse audit logs on a schedule set by the organisation.
2. Detect attempts to increase privileges, unusual sign-in behaviour, signs that data may be leaving the organisation, and breaches of security policy or configuration rules.
3. Estimate the possible impact if the activity is real or unusual.
4. Send results to the incident response team and the information security office.
5. Increase or reduce the review frequency, coverage, and depth when credible new information suggests the risk level has changed.

###### WHY (control requirement)
Audit requirement AU-6 requires the organisation to review and analyse audit records for inappropriate or unusual activity, assess the possible impact, report findings to the relevant parts of the organisation (including incident response and security/privacy functions), and adjust how often and how deeply reviews are carried out based on new information. The organisation’s defined parameters are:
- **frequency**: daily for high-risk systems and weekly for all others (au-06_odp.01)
- **inappropriate or unusual activity**: privilege escalation, unusual sign-in behaviour, signs of data leaving the organisation, and breaches of policy or configuration rules (au-06_odp.02)
- **people/teams involved**: incident response team and information security office (au-06_odp.03)

###### HOW (specific steps/approach)
1. **Define “high-risk systems” and link them to the right log sources** using the organisation’s official asset inventory and data classification/risk ranking. Label each system/asset in the SIEM so the workflow can apply **daily vs weekly** review.
2. **Collect and standardise audit records** from the application and related components (for example: operating system and sign-in logs, logs of privileged actions, identity provider and single sign-on (SSO) logs, remote access/virtual private network (VPN) logs, configuration management change logs, and application administration/audit events). Make sure times match across sources and that log integrity is protected (for example, using write-once/immutable storage where possible).
3. **Create detection rules** (rules written in a consistent, repeatable way) based on the defined categories of inappropriate or unusual activity:
   - privilege escalation indicators (for example: changes to roles or groups, granting of administrative privileges, changes to credentials/tokens, changes to settings related to auditing)
   - unusual sign-in behaviour (for example: impossible travel, new devices, unusual geography/time, multi-factor authentication (MFA) being reduced or disabled)
   - signs of data leaving the organisation (for example: unusually large data transfers, new export actions, suspicious application programming interface (API) patterns, patterns showing data being staged for storage)
   - policy/configuration breaches (for example: disabling security controls, risky configuration changes, changes to firewall or auditing policies)
4. **Automate initial checking and impact assessment** in SOAR by adding context to alerts, such as how important the asset is, who the user is, and what changes have recently been made. Produce a consistent “potential impact” summary for each finding (for example: likely impact on confidentiality and integrity, which business process may be affected, and whether the activity matches known change periods).
5. **Send findings to the required recipients**: configure SOAR playbooks to send results to the **incident response team** and the **information security office** (au-06_odp.03), including links to evidence (log queries), the activity category, and the impact assessment.
6. **Apply the review schedule and adjust when risk changes**:
   - run automated review workflows: **daily** for assets marked high-risk and **weekly** for all others (au-06_odp.01)
   - when credible new risk-change information is received (for example, from law enforcement/intelligence or other credible sources), update the detection rules and broaden the review where appropriate (for example: enable additional checks, widen the time window reviewed, and increase how detailed analyst reviews are). Record why these changes were made.

###### WHO (roles responsible)
- **Security Operations Centre (SOC) / Security Operations (SecOps)**: responsible for configuring the SIEM/SOAR platform, detection rules, triage workflows, and running the scheduled reviews.
- **Incident Response Team**: receives findings, checks whether the activity is suspicious, and starts response actions.
- **Information Security Office**: receives findings, ensures they align with governance requirements, and oversees reporting and closure.
- **Application/Infrastructure owners (as needed)**: provide system context, known change periods, and information about how critical each asset is.

###### Acceptance criteria (audit-ready)
- The organisation can show that **high-risk systems are reviewed daily** and **other systems weekly** (evidence: SIEM/SOAR job schedules and review run logs) (au-06_odp.01).
- The detection checks cover the defined categories: **privilege escalation, unusual sign-in behaviour, signs of data leaving the organisation, and policy/configuration breaches** (au-06_odp.02).
- For each finding, the workflow produces an **impact assessment** describing the potential harm if the activity is real.
- Findings are **reported to the incident response team and the information security office** with consistent evidence and categorisation (au-06_odp.03).
- When credible risk-change information is received, the organisation updates the review **frequency/coverage/depth** and keeps the reasons and supporting change evidence (for example, a ticket/change record linked to updates to the rule set).
- Review outputs (findings, triage decisions, and routing actions) are kept for audit purposes.

###### Actions Required for Compliance

- [ ] Label each asset or system in the security information and event management (SIEM) platform as **high risk** or **other**, using the organisation’s risk tiering model.
- [ ] Collect and standardise audit records from the application and the integrated identity, configuration, and remote access components, and send them to the security information and event management (SIEM) system.
- [ ] Set up alerts to detect attempts to gain higher privileges, unusual sign-in activity, signs of data being taken out of the system, and breaches of security policies or configuration rules.
- [ ] Set up security orchestration, automation and response (SOAR) “triage” playbooks to add more information to alerts and produce a documented assessment of the likely impact.
- [ ] Set up automated routing of identified issues to the incident response team and the information security office, including links to the supporting evidence.
- [ ] Set up and keep records of daily review processes for high-risk systems, and weekly review processes for all other systems.
- [ ] Create a documented process to update rule packs and to widen the review scope and depth when credible information shows that the risk has changed.


---

#### AU-6.1 — Automated Process Integration (Enhancement)

This requirement is about making sure your organisation’s checks of system activity are not done only by hand, but are brought together automatically. This helps suspicious behaviour be spotted quickly and ensures the results are reported properly. Without this, important audit information could be missed, reviewed too late, or put together in different ways. That could mean real incidents are not investigated promptly, and oversight reporting (including Inspector General audits) could be incomplete or difficult to prove with evidence.

To meet this expectation, the organisation must set up documented, automated workflows that automatically collect and review audit records, analyse them using agreed rules, and group related events into clear results. These results must then be automatically passed into the incident response process, ongoing monitoring activities, and Inspector General audit reporting.

The organisation must configure and document how the automation works, ensure audit records are available for it to use, appoint named people responsible for oversight, and record the approach in key planning and design documents. This ensures the outputs can be traced back to the underlying audit evidence.

##### SIEM-SOAR automated audit review, correlation, and IG reporting

- Category: Software
- Priority: Critical

###### WHAT
Set up security information and event management (SIEM)-driven automated processes that combine reviewing audit records, analysing them, and producing reports, using the organisation’s approved automated mechanisms (au-06.01_odp). The automation must continuously review audit records, link related events and analyse them, and automatically send the results into incident response, continuous monitoring, and Inspector General (IG) audit reporting processes.

###### WHY (control requirement)
AU-6(1) enhancement requires that audit record review, analysis, and reporting are combined using the organisation’s approved automated mechanisms. This is to ensure suspicious activity is identified and analysed quickly, and that the reporting outputs are consistent and can be independently checked.

###### HOW (specific steps/approach)
1. **Define the integrated workflow scope and outputs**: document which audit sources are included (for example, application logs, administrator activity logs, identity and authentication events, database audit logs, and API gateway logs), the time periods used for linking related events, and the exact outputs the workflow will produce (incident case records, continuous monitoring findings, and IG reporting entries).
2. **Standardise an “audit evidence bundle” format**: create a structured, machine-readable evidence format that includes source record identifiers, timestamps, affected assets and users, event types, and linking identifiers. Require that SIEM detections and security orchestration, automation, and response (SOAR) playbooks fill in the required fields.
3. **Create SIEM linking rules and automated triage triggers**: implement detection and linking logic that groups related audit events (for example, suspicious authentication patterns followed by privileged actions) and produces structured evidence bundles rather than only unstructured alerts.
4. **Use SOAR to run review, analysis, and reporting**: implement SOAR playbooks that automatically carry out review steps (triage), perform the agreed analysis and enrichment (asset importance, user role, normal activity patterns during agreed hours), and produce outcomes. Configure playbooks to route outcomes to:
   - **incident response tooling** (create or update cases, notify on-call staff, and attach references to the evidence bundles),
   - **continuous monitoring outputs** (update dashboards and monitoring summaries), and
   - **IG reporting workflow** (create IG-ready report entries with traceable references to the underlying evidence bundles).
5. **Ensure audit records are available for automation**: configure SIEM and SOAR integration so the automation can retrieve the underlying audit records needed for the required linking time period (using SIEM search interfaces or evidence-bundle storage) and document the retention and access approach used.
6. **Assign named responsibilities and governance**: appoint named owners for the integrated workflow (SIEM detection owner, SOAR playbook owner, incident response liaison, and IG reporting owner) and set approval steps for changes to linking logic and reporting templates.
7. **Make the workflow auditable**: keep version control for detection rules, SOAR playbooks, and reporting templates; ensure every automated outcome includes permanent references (IDs or links) back to the source audit records and the version of the linking logic used.

###### WHO (role responsible)
- **Security Operations Lead**: owns the SIEM linking scope, triage outcomes, and routing to incident response.
- **SOAR/Automation Engineer**: builds the playbooks, evidence bundle format, and integrations.
- **Incident Response Manager**: checks that automated outcomes correctly feed incident response processes.
- **Compliance/IG Reporting Owner**: checks IG reporting outputs and evidence traceability.
- **Change Manager / Security Governance**: enforces approval steps and version control.

###### Acceptance criteria
- Automated mechanisms are implemented and documented so that audit record review, analysis, and reporting are integrated end-to-end (SIEM → SOAR → incident response / continuous monitoring / IG reporting).
- Linking logic produces structured evidence bundles with traceable references to the underlying audit records.
- SOAR playbooks automatically route outcomes to incident response cases and continuous monitoring outputs without requiring manual-only steps.
- IG reporting entries are generated automatically and include traceable evidence bundle references and identifiers for the linking logic version used.
- Retrieval of evidence for the configured linking time period is demonstrated (validated through test runs).
- Named responsibilities and change approval steps are in place for workflow logic and reporting templates.

###### Actions Required for Compliance

- [ ] Document the scope of the combined security information and event management (SIEM) and security orchestration, automation and response (SOAR) workflow, including the audit data sources that are in scope, the time window used to link related events, and the required workflow outputs (incident response, continuous monitoring, and information governance (IG) reporting).
- [ ] Define and implement a standard structure for collecting audit evidence, and ensure the required information is always included when security alerts are produced by the security information and event management (SIEM) system.
- [ ] Create security information and event management (SIEM) correlation rules that group related audit events and produce evidence bundles that include traceable source record identifiers.
- [ ] Implement security orchestration, automation and response (SOAR) playbooks to automatically sort alerts, investigate and add context, and send the results to: incident response, continuous monitoring dashboards and summaries, and incident reporting (IG) entries.
- [ ] Set up security information and event management (SIEM) and security orchestration, automation and response (SOAR) connections to pull the original audit records for the agreed look-back period, and record the assumptions about how long the data is kept and who can access it.
- [ ] Assign named owners for each workflow (security information and event management (SIEM) detections, security orchestration, automation and response (SOAR) playbooks, the incident response contact, and the information governance (IG) reporting owner). Put approval checkpoints in place before making changes to rules, playbooks, reporting templates, or reporting formats.
- [ ] Use test cases to confirm the end-to-end process works correctly, and make sure every automated result includes unchangeable references back to the original audit records and the version of the correlation logic.


---

#### AU-6.3 — Correlate Audit Record Repositories (Enhancement)

This requirement is about bringing together evidence from different sources so the organisation can see the full picture of what is happening, rather than relying on isolated snapshots. If audit records are not linked across multiple systems, important clues can be missed, patterns may not be noticed, and the organisation may not understand how issues affect overall risk, day-to-day business activities, or particular systems.

To meet this expectation, the organisation must clearly set out why and how it will link audit records, which systems (repositories) to include, how it will collect the relevant records so they can be compared, and how it will analyse them together to produce combined views—for example, a single linked timeline of events.

The organisation must use these results in its audit review, analysis and reporting. Named people must be responsible for carrying out the work, and relevant information security and privacy roles must be involved. The organisation must also ensure that systems are set up to produce consistent, usable records for matching and comparison, keep the records available, document the approach and methods used, and make sure the outputs support awareness at organisational, business-process and system levels, including sharing context with other organisations where required.

##### Correlate multi-repository audit logs into unified, risk-level views

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-wide audit correlation capability that:
- collects audit records from multiple data sources,
- puts them into a consistent format suitable for linking,
- links related events across those sources into connected stories and timelines, and
- produces results that are classified by organisational, mission/business-process, and information-system risk levels.

###### WHY (control requirement)
AU-6(3) (Enhancement) requires the organisation to **analyse and correlate audit records from different repositories** to improve **organisation-wide situational awareness**. This includes awareness across **three levels of risk management** (organisational, mission/business-process, and information system) and supports **cross-organisation awareness** where applicable.

###### HOW (specific steps/approach)
1. **Define the purpose of correlation and how it will be used in audit review**: Create a documented procedure that explains what the correlation results will be used for (for example: incident narratives, risk trend reporting, control effectiveness reviews) and how the results will feed organisational, mission/business-process, and information-system reporting.
2. **Identify and connect audit repositories**: Keep an up-to-date list of audit record sources (for example: identity provider/authentication, endpoint/server operating system audit, application audit, cloud control-plane logs, privileged access management (PAM), and where applicable operational technology (OT) gateway audit/telemetry) and set up data collection for each.
3. **Standardise audit records so they can be correlated**: Configure a normalisation step so all collected records provide the same key information needed for linking. At minimum, this includes: event time, person/account, device/host, session/transaction identifiers where available, resource, action, result, and environment/system identifiers.
4. **Link events across repositories into unified views**: Implement correlation rules (for example: correlation rules or correlation-as-code) that connect related events across sources into single timelines/sessions/transactions (for example: authentication success/failure → privilege change → administrative action → sensitive data access). Ensure each linked result records the **time window**, **source repositories**, and **correlation rule version** used.
5. **Classify outputs against the three risk levels**: Add information to correlated events so they are mapped to: (a) organisational risk drivers, (b) mission/business processes/services, and (c) specific information systems (using asset-to-system and service mapping, such as configuration management database (CMDB) and service catalogues).
6. **Make it repeatable and support audit checks**: Run correlation on a regular schedule (for example, daily/weekly) and also run it on demand for investigations. Store the correlation outputs and supporting details (rule version, data sources collected, time window) so results can be reproduced.
7. **Govern outputs and responsibilities**: Name the roles responsible for running and reviewing correlation, including information security and privacy involvement where relevant, and define how results will be reviewed and reported.

###### WHO
- **Security Operations Lead / security information and event management (SIEM) Engineer**: sets up data collection, standardisation, correlation logic, and scheduled correlation runs.
- **Information Security Manager**: owns the correlation procedure and ensures outputs are used in audit review and reporting.
- **Privacy Officer (as applicable)**: reviews correlation use where personal data is involved and ensures privacy requirements are met.
- **Application/System Owners**: provide system/service mapping information and confirm that correlated outputs correctly map to their systems.

###### Acceptance criteria
- Correlated outputs can be produced for a defined time window and include:
  1) the set of collected repositories,
  2) the correlation rule version(s), and
  3) a linked timeline/session/transaction view across repositories.
- Outputs are clearly mapped to all three risk levels: organisational, mission/business-process, and information-system.
- Evidence shows correlation results are used in organisation-defined audit review/analysis/reporting (for example, reviewed dashboards/reports with documented approval).
- Correlation can be repeated and checked for audit purposes (stored metadata and versioning of correlation logic).

###### Actions Required for Compliance

- [ ] Create and get approval for a correlation procedure that sets out its purpose, expected outputs, and how the results will be used in audit review, analysis, and reporting.
- [ ] Identify, list, and prioritise the audit record storage locations that should be linked together (information technology and operational technology through controlled gateways where applicable).
- [ ] Set up audit log normalisation so it always produces the same set of matching fields: timestamp, user (principal/account), device or host, session or transaction, resource, action, result, and system identifiers.
- [ ] Set up automated correlation rules (correlation-as-code) that link related timelines, sessions, and transactions across different repositories, and record the rule version and which repositories the rules came from.
- [ ] Enrich related events by linking them to the organisation’s key risk drivers, mission and business processes, and information systems, using asset and service mapping.
- [ ] Schedule and run correlation jobs using defined time windows. Store the correlation results and related information so the work can be repeated and used as audit evidence.
- [ ] Assign specific named roles for running the correlation checks and for reviewing the results, involving information security and privacy teams where relevant, and record formal approval (sign-off) for the reports.


---

#### AU-6.4 — Central Review and Analysis (Enhancement)

This requirement is about having one central place where your organisation can collect, review, and analyse records of system and user activity from different parts of your service. This helps authorised staff spot patterns and problems across the whole environment, instead of checking each component separately. Without this, important warning signs could be missed, suspicious behaviour could be harder to trace back to its source, and it would be difficult to produce reliable evidence for investigations and reporting.

To meet this expectation, the organisation must decide which components’ activity records will be included, put in place a working central system that actually receives and stores those records, and ensure it can support automated review and analysis across components. It must also produce clear written procedures for how reviews, analysis, and reporting are carried out, assign named responsibilities, involve the appropriate information protection and privacy roles where required, and document how the approach is built and configured. Finally, it must ensure the records are kept and available for the required review period, and keep evidence that reviews and reports were produced.

##### Central SIEM review and correlation for multi-component audit records

- Category: Software
- Priority: Critical

###### WHAT
Set up a central capability (usually a **security information and event management (SIEM)** or **log analytics** platform) that collects, stores, and supports automated checking and analysis of audit records from multiple parts of the organisation.

###### WHY (control requirement)
**AU-6(4) (Enhancement)** requires the organisation to **provide and implement the capability to centrally review and analyse audit records from multiple components**. The guidance also states that **automated mechanisms** for central review and analysis include **SIEM products**.

###### HOW (specific steps/approach)
1. **Define the central review scope**: create an onboarding register that lists the components in scope (for example: identity provider (IdP), virtual private network (VPN)/remote access, web/application programming interface (API) front ends, application services, databases, privileged access tools, and administration consoles) and the types of audit records to review (for example: authentication events, changes to privileges, administrative actions, access to sensitive data, and policy/authorisation denials).
2. **Centralise log collection and standardise**: configure secure log forwarding from each component to the central SIEM (using **transport layer security (TLS)**; and **mutual authentication** where supported). Make sure each event uses consistent identifiers, including: timestamp, source component, host/application/service, user/service account, action, outcome/result, severity, and correlation references such as session ID/transaction/request ID where available.
3. **Set up automated review and analysis**: create scheduled searches, dashboards, and alerting/correlation rules to support cross-component review topics (for example: a chain of privileged actions across IdP → application → database within a defined time window; repeated failed logins followed by successful privileged access).
4. **Produce review outputs that can be audited**: configure report templates that export review evidence (for example, **PDF/CSV**) showing the review time window, the identifiers for the search/correlation rules used, and proof that the analysis ran (including reviewer identity/role where the workflow supports this). Store outputs in an access-controlled repository that matches retention requirements.
5. **Operate with controlled change**: manage SIEM parsing rules, correlation rules, and report content using change control (a versioned rules/content repository; promotion through development/test/production; approvals). Limit access to SIEM review functions to authorised staff using role-based access control.
6. **Run and keep evidence**: carry out the defined review process on a scheduled basis, keep evidence that reviews and reports were produced, and periodically check that required sources remain connected and generating the expected audit records.

###### WHO (role responsible)
- **Security Operations Lead / security operations centre (SOC) Analyst Manager**: owns the review use-cases, dashboards, and scheduled analyses.
- **SIEM/Platform Engineer**: implements log collection, standardisation, correlation rules, and report templates.
- **Information Security / governance, risk and compliance (GRC)**: maintains the central review scope register and ensures it matches organisational review procedures and retention.
- **Data Protection/Privacy Officer (where applicable)**: reviews any privacy-related impact of central log retention and access.

###### Acceptance criteria
- The SIEM receives audit records from **multiple defined components**, and events can be searched in a **single central view**.
- Automated scheduled reviews and correlation analyses are implemented for the defined in-scope review topics.
- Cross-component correlation works for at least one representative scenario (for example, a privileged action chain across at least two components) and produces an exportable review output.
- Review outputs (reports/exports) are stored with traceability (time window and rule/search identifiers) and access is limited to authorised roles.
- Evidence exists that SIEM review content and correlation rules are managed through controlled change (versioning and approvals) and that review runs are completed according to the documented procedure.

###### Actions Required for Compliance

- [ ] Create a register of in-scope components and audit record types for central review.
- [ ] Set up secure forwarding of logs from each in-scope system component to the central security information and event management (SIEM) system, using consistent event details (fields).
- [ ] Set up scheduled searches and dashboards for the agreed review topics across all components.
- [ ] Create and test rules that link related events from different sources for at least one privileged-access scenario and one authentication scenario.
- [ ] Set up reusable report templates that include the review time window and the correlation and query identifiers.
- [ ] Place security information and event management (SIEM) parsing, correlation, and reporting content under change control, with versioning and promotion between environments.
- [ ] Set up and carry out the main review process, and keep records showing the results of those reviews for the required period.


---

#### AU-6.5 — Integrated Analysis of Audit Records (Enhancement)

This expectation is about joining the dots. When you review records of what happened in your systems, you should also look at other evidence—such as vulnerability scan results, operational monitoring alerts, and performance information—to identify behaviour that is suspicious or should not be happening. If you only look at one source, you may miss real attacks, treat harmless activity as a problem, or fail to notice unusual activity occurring at the same time as warning signs in other data.

To meet this expectation, the organisation must:

- define which additional information sources will be used (including, where available, threat information and known “indicators” of compromise);
- document how the combined review will work; and
- ensure audit records from different parts of the organisation can be brought together and linked by time, system, user, or indicator.

The review must be carried out by named people, with appropriate input from those responsible for privacy and security. The organisation must also use repeatable methods and standard analysis approaches where possible, and adjust them to fit its systems.

##### SIEM-integrated correlation of audit, scan, monitoring and performance

- Category: Software
- Priority: Critical

###### WHAT
Set up an integrated analysis capability in the security information and event management (SIEM) system (and optional security orchestration, automation and response (SOAR)) that brings together **audit record information** with **vulnerability scanning information**, **system monitoring information**, and **performance data**. Where available, it should also use **threat intelligence feeds** and **indicators of compromise (IoC)** data to spot **activity that is inappropriate or unusual**.

###### WHY (control requirement)
AU-6(5) enhancement requires that analysis of audit records is combined with analysis of the organisation’s defined sources (parameter **au-06.05_odp.01**: vulnerability scanning information, system monitoring information, performance data). This improves the ability to identify inappropriate or unusual activity. The guidance explains that integrated analysis means linking information collected from scanning and monitoring (and other sources) with audit record analysis. It also notes that linking with vulnerability scanning helps confirm whether scan results are trustworthy and helps match attack detection events to scanning results.

###### HOW (specific steps/approach)
1. **Define the inputs and matching fields for integrated analysis**: document which log and audit sources count as “audit record information”, and which other sources will be used (at minimum vulnerability scan results, monitoring alerts, and performance data; optionally threat intelligence feeds and IoCs from **au-06.05_odp.02**). Define the fields used to link records (for example: asset identifier, user/account, Internet Protocol (IP) address / media access control (MAC) address, service, and time windows).
2. **Bring data into the SIEM and put it into a consistent format**: make sure vulnerability scan outputs are loaded with the asset, time, finding identifiers (for example, common vulnerabilities and exposures (CVE) / common weakness enumeration (CWE) where available), and supporting evidence. Also ensure monitoring alerts and performance metrics are loaded and formatted using the same asset/user identifiers and timestamps.
3. **Create correlation rules that link across sources**: build logic that connects audit events to (a) relevant scan findings for the same asset and time window, (b) monitoring detections for the same user/host and time window, and (c) performance anomalies that match the same sessions or transactions where possible.
4. **Create one combined investigation summary (single conclusion)**: configure the SIEM/SOAR workflow so that when an audit-driven case is opened, it automatically adds the linked scan, monitoring, and performance evidence and produces one integrated assessment (not separate reviews).
5. **Use standard analysis scripts where possible**: where data needs to be interpreted or enriched (for example, extracting user/asset/session from application audit logs), use standard scripts maintained by the organisation, with local updates for the application’s log formats.
6. **Allow for missing data and handle evidence clearly**: ensure the workflow can still produce an integrated conclusion if one source type is missing (for example, scan data is not available for a time window). Clearly record which types of evidence were available.
7. **Set named responsibility for review and accountability**: configure case ownership and approval steps so that named analysts (including security and privacy involvement where required by the organisation) review the integrated outputs and record the outcomes.

###### WHO
- **Security Operations Lead / security operations centre (SOC) Analyst (named role)**: responsible for tuning the correlation rules and reviewing cases.
- **SIEM Engineer**: implements data ingestion, consistent formatting, correlation rules, and enrichment scripts.
- **Application Owner / Logging Engineer**: ensures the audit record fields needed for linking (asset/user/time/session) are present and correctly formatted.
- **Information Security and Privacy representatives (as applicable)**: review the integrated analysis workflow for privacy and accountability requirements.

###### Acceptance criteria
- The SIEM can link an audit event with at least **vulnerability scan information**, **system monitoring alerts**, and **performance data** for the same asset/user/time window, producing a single integrated case summary.
- Correlation rules clearly link audit events to scan findings and monitoring detections (with evidence attached) and include performance anomaly context where available.
- Data ingestion stores vulnerability scan findings, monitoring alerts, and performance metrics using consistent identifiers and timestamps that support correlation.
- Standardised enrichment and parsing scripts are used for audit record normalisation (with documented local adjustments).
- If one evidence source is unavailable, the workflow still produces an integrated conclusion and records which evidence types were available.
- Case ownership and review steps are set for named reviewers, and the integrated outputs are auditable (evidence is retained for the investigation).

###### Actions Required for Compliance

- [ ] Define the combined data sources and matching rules (asset, user, IP address, and time windows) needed to produce evidence for audits, scanning, monitoring, and performance.
- [ ] Set up security information and event management (SIEM) to standardise vulnerability scan results, monitoring alerts, and performance measurements, using the same identifiers and timestamps for all data.
- [ ] Set up security information and event management (SIEM) rules that connect audit records to the relevant results from security scans, monitoring alerts, and matching performance issues.
- [ ] Create security orchestration, automation and response (SOAR) (or security information and event management (SIEM)) workflow playbooks to produce one combined investigation story, with supporting evidence attached from all related sources.
- [ ] Develop and deploy standard audit parsing and enrichment scripts to capture the required correlation fields, and apply local adjustments to match each application’s log format.
- [ ] Set up who owns each case and the specific review steps analysts must follow, so they produce and record a single integrated conclusion, with the availability of supporting evidence clearly noted.


---

#### AU-6.6 — Correlation with Physical Monitoring (Enhancement)

This requirement is about making sure the organisation can match what a person does on its computer systems with whether that same person was physically on site at the relevant time. Without this, suspicious or harmful activity can be harder to detect, because computer records may look normal on their own even if the person was not actually present, or when unusual behaviour needs stronger context to investigate.

To meet this expectation, the organisation must set up a method to combine information from its computer activity records with its physical access records, using a shared way to identify the person. This should allow linked events to support investigations. The organisation must also:

- document why and how the linking works  
- keep clear procedures for reviewing, analysing, and reporting the combined information  
- document how physical access is monitored  
- keep evidence showing that the linking has been carried out  
- include this approach in its system security plan and, where applicable, its privacy plan  

The organisation must assign named responsibilities to the people who review the records, manage physical monitoring, and oversee information security and privacy.

##### SIEM correlation of logical audit events with physical access logs

- Category: Software
- Priority: Critical

###### WHAT
Set up an auditable way to link **computer audit records** (for example, sign-ins, permissions, and privileged actions) with **physical access monitoring records** (for example, badge/door/visitor events). This helps identify suspicious, inappropriate, unusual, or malicious activity.

###### WHY (control requirement)
The NIST AU-6(6) requirement asks for combining **information from computer audit records** with **information from physical access monitoring** to improve the ability to spot suspicious, inappropriate, unusual, or malicious activity. The guidance also stresses the value of matching a person’s computer access identity with their physical presence at the site at the time of the computer access.

###### HOW (specific steps/approach)
1. **Define the correlation design**: document the purpose of the correlation, the **time matching method** (for example, matching events by their event time using a configurable time window such as ±15 minutes), and how data from both sources will flow into the correlation process.
2. **Standardise how identities are linked**: make sure both computer audit events and physical access events can be matched to a **single shared person identifier** (for example, employee ID, or a controlled mapping between a user principal name and a badge credential ID). Keep this mapping under change control and version it.
3. **Collect and standardise the logs** in the organisation’s security information and event management (SIEM) / log analytics platform:
   - Computer audit records from the application and connected identity/access systems (identity provider (IdP), privileged access management (PAM), etc.), including the user identifier, event time, and event type.
   - Physical access logs from badge readers/door controllers/visitor systems, including the credential/person identifier, location/door, and event time.
4. **Set up correlation checks (detection-as-code)** that add physical presence evidence to computer events within the agreed time window. When suspicious conditions are found (for example, unusual use of high-level permissions, unusual sign-in behaviour, or access outside the expected role), create a linked investigation record.
5. **Produce investigation outputs**: ensure alerts/cases include both:
   - the physical access evidence (door/location, time, credential/person ID), and
   - the computer audit evidence (event time, action, system/application, user/principal).
6. **Keep proof for audit purposes**: retain the linked output details, the correlation check identifiers/versions, and the version of the identity mapping used at the time of correlation.
7. **Update system documentation**: add the correlation capability to the relevant **system security plan** (and **privacy plan** where applicable), including who is responsible for review/handling and any privacy considerations for physical monitoring data.

###### WHO
- **Security operations centre (SOC)/SIEM engineer**: set up SIEM ingestion, standardisation, correlation checks, and evidence retention.
- **Application security/engineering lead**: ensure the application and connected identity audit events provide the required fields (user identifier, times, event types).
- **Physical security lead**: provide the physical access log fields and confirm the quality of the identity mapping.
- **Information security/privacy officer (as applicable)**: approve updates to the system security plan/privacy plan and ensure privacy requirements are met.

###### Acceptance criteria
- Linked outputs are produced for qualifying computer audit events, with physical presence evidence attached (within the documented time window).
- The identity mapping between the computer user/principal and the physical credential/person ID is consistent, versioned, and controlled for changes.
- Correlation checks are implemented in a way that can be audited (check IDs/versions recorded), and the linked outputs keep enough evidence to support investigation.
- The system security plan (and privacy plan where applicable) is updated to describe the correlation capability, data sources, and handling considerations.

###### Actions Required for Compliance

- [ ] Explain why the correlation is being done, how the time window is chosen, and how data moves between logical audit logs and physical access logs.
- [ ] Set up a shared system that links each person’s digital identity (logical principal) to their real-world credential (physical credential), with version tracking and formal change control.
- [ ] Set up security information and event management (SIEM) to collect and standardise both logical audit events and physical access events, including the event times, identifiers, and locations.
- [ ] Create and deploy rules that link suspicious computer activity to evidence that a person was physically present, within the agreed time window.
- [ ] Set up investigation or case reports to include both the logical event information and the physical access evidence, including the door or location and the relevant timestamps.
- [ ] Enable retention of correlated alert details, including the correlation rule identifier and version, and the version of the mapping table that was used at the time the correlation was performed.
- [ ] Update the system security plan (and the privacy plan where applicable) to explain how the correlation capability works and how it should be handled.


---

#### AU-6.7 — Permitted Actions (Enhancement)

This requirement is about ensuring that only the correct people and automated tasks are allowed to do the correct actions, and only those actions, with audit records. If permissions are not clearly defined and enforced, someone could accidentally or intentionally change, delete, or incorrectly add to audit information. This would weaken investigations, compliance checks, and accountability.

The organisation must clearly define and document exactly which actions are allowed for each relevant system process, job role, and individual user involved in reviewing, analysing, and reporting audit records. It must use the minimum access needed—for example, allowing only reading, or allowing reading plus adding or writing entries—while restricting actions such as running changes and deleting records where this is not required.

The organisation must keep these permissions up to date in its official policies and procedures, ensure its account and access management processes apply and enforce the permissions in practice, and confirm that the system blocks any actions that are not explicitly permitted.

##### Enforce least-privilege permitted actions on audit records via RBAC

- Category: Software
- Priority: Critical

###### WHAT
For each **{{ insert: param, au-06.07_odp }} (role, user)** involved in reviewing, analysing, and reporting audit record information, define and enforce the **actions the system is allowed to take** on that audit record information (at minimum: **read, write, execute, append, delete**). The system must **block any action that is not explicitly permitted**.

###### WHY (control requirement)
AU-6(7) requires the organisation to **specify permitted actions** for each **{{ insert: param, au-06.07_odp }}** linked to the review, analysis, and reporting of audit record information, applying least privilege. Permitted actions must be **enforced by the system** and include **read, write, execute, append, and delete**.

###### HOW (specific steps/approach)
1. **Create an audit-record permission matrix** that lists each relevant **role/user** (for example: reviewer, analyst, report author, approver, privileged administrator, service account) and the allowed action types for each audit-record object/workspace (for example: log store, case workspace, report draft repository, evidence attachments). Make sure the matrix clearly states which of **read/write/execute/append/delete** are permitted (and which are not) for each role/user.
2. **Enforce these permissions in the application and supporting services** using the organisation’s identity and access model (for example, **role-based access control (RBAC)** / **attribute-based access control (ABAC)**), so each action type is technically controlled:
   - **Read**: allow viewing audit record information.
   - **Append**: allow adding analysis notes/case annotations without enabling wider changes.
   - **Write**: allow updating analysis fields only where needed.
   - **Execute**: allow only the workflow actions required for review/analysis/reporting (for example: generate report, approve a step), not arbitrary code execution.
   - **Delete**: allow only zero or explicitly justified “break-glass” roles; otherwise deny.
   Ensure the system returns an access-denied result for any action that is not permitted.
3. **Manage permissions through account management workflows** (group-based entitlements via the central identity provider) so permitted actions are assigned to the correct **role/user** and removed when responsibilities change.
4. **Make the permission matrix auditable and change-controlled** by treating it as the source of truth and applying changes through controlled configuration management (for example, infrastructure/application configuration managed via version control with peer review and approvals).
5. **Validate enforcement and prevent unauthorised changes** by running automated checks that compare the effective permissions in the live environment against the documented matrix, and by carrying out periodic access reviews/attestations for each role/user.

###### WHO
- **Application Owner / Security Architect**: define the permission matrix and least-privilege mapping.
- **Identity and Access Management (IAM) Engineer / Platform Engineer**: implement **role-based access control (RBAC)** / access enforcement and identity provider group entitlements.
- **Security Operations Centre (SOC) / Compliance Lead**: confirm permitted actions match review/analysis/reporting responsibilities.
- **System Administrators (restricted)**: maintain configuration only through approved change management.

###### Acceptance criteria
- For every **{{ insert: param, au-06.07_odp }} (role/user)** in the audit review/analysis/reporting workflow, the system has an explicit, documented mapping of permitted actions covering **read/write/execute/append/delete**.
- The application and any integrated services **enforce** these permitted actions (attempts to perform non-permitted actions are denied by the system).
- **Delete** is denied for all roles/users where it is not explicitly required by the matrix.
- Effective permissions in production match the documented matrix (verified through drift checks and/or access review evidence).
- Permission changes are traceable to approved change records and configuration versions.

###### Actions Required for Compliance

- [ ] Create an audit-record access matrix that maps each **au-06.07_odp** role or user to what they are allowed to do with each audit-record object (read, write, execute, append, or delete).
- [ ] Implement role-based access control (RBAC) and authorisation checks in the application and integrated audit-record services so any action that a user is not permitted to do is blocked (denied).
- [ ] Set up identity provider (IdP) group entitlements so that each role or user gets only the permissions listed in the permissions matrix.
- [ ] Put in place a controlled process for changes to the permissions matrix and authorisation settings, including version tracking, required approvals, and a complete audit trail.
- [ ] Run automated checks to compare the actual permissions in the live (production) environment against the documented permission matrix, and alert if they do not match.
- [ ] Carry out regular access reviews (attestations) for each role and user to confirm that the permissions allowed for their job still follow the principle of least privilege.


---

#### AU-6.8 — Full Text Analysis of Privileged Commands (Enhancement)

This requirement is about checking what highly privileged users actually type when they perform high-privilege actions—not just confirming that they acted. The risk it addresses is that harmful or unauthorised activity could be hidden in the details of a command, such as a specific account, file location, or option, and could be missed if you only look at the command’s name.

To meet this expectation, the organisation must review the full text of every recorded high-privilege command, including all details and options. This review must be done in a separate, physically isolated analysis environment, or on a dedicated separate system used only for this checking, so the checking process cannot affect, or reveal information about, the environment where elevated access is available.

The organisation should use both:
- searches for known suspicious patterns, and
- sensible “best-guess” checks to identify less obvious misuse.

The organisation must also document what is checked, how it is checked, and how the results are reviewed and reported. Named individuals must be responsible for the review, analysis, reporting, and oversight of privacy and security.

##### Physically isolated privileged command full-text analysis pipeline

- Category: Software
- Priority: Critical

###### WHAT
Set up a dedicated, physically separate analysis component/subsystem that performs **full text analysis** of **logged privileged commands, including the command parameters** (not only the command names). Use **pattern matching** and **heuristics**.

###### WHY (control requirement)
AU-6(8) enhancement requires the organisation to **“perform a full text analysis of logged privileged commands”** using a **physically separate component/subsystem** (or another dedicated system) that is used **only for that analysis**. This ensures the analysis cannot weaken, alter, or interfere with the privileged command and audit source environment. Full text analysis must consider the **full command text (commands and parameters)** and must include **pattern matching and heuristics**.

###### HOW (specific steps/approach)
1. **Create a dedicated analysis zone**: use a separate appliance or virtual machine (VM) host in a physically separate environment, or use an **air-gapped** design (or a **one-way transfer** design). This zone must have **no administrative connectivity** back to the privileged execution environment.
2. **Export privileged command audit records** to the analysis zone using a controlled method (for example, a one-way data transfer approach, or a scheduled batch export with integrity checks). Make sure the exported record includes the **full command string exactly as logged**, including any quoting/escaping and parameters.
3. **Keep and preserve the full command text** on the analysis system. Store an **immutable** copy for traceability, and ensure analysis is performed on the **complete command line**, not on a derived “command name” field.
4. **Implement detection logic as code** on the analysis system:
   - **Pattern matching** (regular expression/keyword patterns) across the full command text to identify known risky constructs (for example: privilege escalation flags, suspicious file paths, indicators of credential material, destructive actions, and unusual option combinations).
   - **Heuristic scoring** for unusual or risky parameter combinations (for example: rare flag sets, path traversal indicators, attempts to access sensitive locations, and use of interpreters in elevated contexts).
5. **Produce auditable findings** that point back to the original audit event (timestamp, user, session, host, and the specific full command/parameter parts that triggered the rules/heuristics). Send findings into the organisation’s case/alert workflow **without giving the analysis system any ability to execute privileged commands**.
6. **Set review and reporting procedures**: define who reviews findings, how often, escalation thresholds, and how privacy and security considerations are handled (for example, data minimisation/redaction in reports while keeping full evidence in the isolated analysis store).
7. **Document the analysis scope and configuration**: list which privileged command sources are included, which command types are analysed, rule/heuristic versions, tool versions, the transfer/export method, and the operational runbook for analysis and review.

###### WHO
- **Security Operations Centre (SOC) / Detection Engineering**: implement and maintain the detection rules/heuristics and the analysis runbook.
- **Security Information and Event Management (SIEM) / Logging Engineering**: implement the export pipeline to ensure full command text is transferred.
- **Information Security / Privacy Officer (where applicable)**: approve the privacy/data handling approach for command parameters in reports.
- **System Owner / Privileged Access Governance Lead**: ensure the scope is covered and that review/escalation procedures are followed.

###### Acceptance criteria
- Privileged command audit events are exported to a **physically separate** analysis system with **no administrative path** back to the privileged environment.
- The analysis engine checks the **full command text including parameters** for every eligible privileged command event.
- Detection includes both **pattern matching** and **heuristic** checks across the full command line.
- Findings include **evidence** (the full command and the triggering parameter substrings) and are traceable to the originating audit event.
- The organisation can provide audit-ready evidence of: scope, rule/heuristic versions, export/transfer method, and named review/escalation procedures.

###### Actions Required for Compliance

- [ ] Define which privileged command sources are allowed, and confirm that the audit records include the full command line (the command and all parameters) exactly as it was executed.
- [ ] Set up a physically separate “privileged command analysis” appliance or zone that has no administrative network connection back to the privileged execution environment.
- [ ] Set up a controlled export process (a one-way transfer or a batch export checked for data integrity) that sends the complete command text into the analysis area.
- [ ] Set up the analysis engine to check the full command text using both pattern matching (regular expressions and keywords) and a heuristic scoring method.
- [ ] Store analysed command evidence in write-once (immutable) storage, and produce findings that point back to the original audit event and the specific triggering parameter text fragments.
- [ ] Add the findings to the organisation’s alert and ticket workflow using the minimum necessary permissions, and do not allow privileged command execution from the analysis system.
- [ ] Create and test an audit-ready runbook that explains how often reviews happen, when issues are escalated, and how personal data and privacy are handled for command parameters.


---

#### AU-6.9 — Correlation with Information from Nontechnical Sources (Enhancement)

This requirement is about connecting sensitive information about incidents with the organisation’s official activity records. The goal is to spot patterns that could indicate wrongdoing by an individual. If this careful linking is not done, important clues about breaches of harassment-related policies or improper use of company information could be missed. It could also lead the organisation to waste time investigating the wrong people, and increase the risk of accidentally exposing private information.

The organisation must clearly set out which types of non-public records are allowed to be linked and explain why this is being done, to improve awareness across the organisation of potential security and insider-risk situations. The organisation must only carry out the linking when there is a reasonable suspicion that someone is involved in an incident, using documented review, analysis, and reporting steps. Named staff must be responsible for the work, with oversight from those responsible for information security and privacy.

Access to the sensitive non-public records must be restricted. The organisation must keep records showing what was linked and what was found. Legal advice must be obtained before any further targeted, directed analysis begins.

##### Case-gated correlation of sensitive nontechnical records with audit logs

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled, case-by-case workflow that links **authorised non-technical incident-related records** (for example, harassment or policy-violation records, and records of improper use of information assets) with **audit record information**. This will help the organisation build a shared understanding of what is happening, to spot possible malicious insider activity.

###### WHY (control requirement)
AU-6(9) (Enhancement) requires the organisation to **link information from non-technical sources with audit record information** to improve organisation-wide situational awareness. Guidance says this linking should generally happen **only when a person is suspected of being involved in an incident**, that organisations **limit access** to sensitive non-technical sources, and that **legal advice is obtained before starting** these actions.

###### HOW (specific steps/approach)
1. **Define an eligible non-technical record catalogue**: create a documented list of the non-technical record types that are allowed to be linked (at minimum: harassment/policy-violation incident records and improper use of information-asset incident records). Include the minimum required details for linking (for example: the person’s identity, the incident date/time range, the affected asset or system identifiers, and the incident reference).
2. **Use case “gates” with a legal basis**: require a case intake ticket/workflow that records (a) the documented basis for **reasonable suspicion**, (b) a reference to **legal advice approval** (or a legal counsel ticket/approval ID), and (c) the agreed **linking scope** (time window, person or persons, and system or asset identifiers). Linking must be blocked if any of these are missing.
3. **Restrict access to non-technical sources**: set up access controls so only the authorised case team (for example, Insider Risk Lead, Information Security, Privacy, and Legal liaison as applicable) can view non-technical records. Use the minimum necessary permissions (least privilege) and time-limited access (for example, “just-in-time” access) with strong authentication.
4. **Carry out the linking in the security monitoring/forensics process**: match the case person(s) to audit identities (for example, user IDs, service accounts, and device IDs). Then run linking searches against audit sources (for example, authentication events, administrative actions, and data access events) within the approved scope.
5. **Keep the outputs as evidence**: save the linking results as case evidence, including: the non-technical record reference(s), the audit record identifiers and timestamps used, the linking search method (or search IDs), the analyst’s identity, and access logs showing who viewed or ran the linking and when.
6. **Add documented review, analysis, and reporting**: require that the linking outputs are reviewed by the accountable roles (Information Security and Privacy oversight as applicable), and that reporting is produced for the insider-risk process. Keep records in line with organisational policy.

###### WHO
- **Insider Risk Lead / Security Operations Centre (SOC) Lead**: owns the case workflow and ensures linking is case-gated and within scope.
- **Information Security (or Security Operations)**: owns running the audit-log linking and maintaining evidence integrity.
- **Privacy Officer (where applicable)**: provides oversight for privacy impact and access restrictions.
- **Legal Counsel**: provides and/or approves legal advice before any directed analysis.
- **System/Platform Owner (security monitoring/insider-risk tooling)**: implements the technical controls (access enforcement, linking execution, evidence storage).

###### Acceptance criteria
- Linking non-technical records with audit logs cannot be carried out unless the case intake includes (1) documented reasonable suspicion and (2) a legal advice approval reference.
- Only authorised case-team roles can access non-technical records; access is logged and time-limited where supported.
- Linking results are stored with complete evidence: non-technical record references, audit record identifiers and timestamps, linking search identifiers or logic, analyst identity, and access logs.
- Linking is carried out strictly within the approved scope (time window, person(s), and system or asset identifiers) and produces a report that can be reviewed for the insider-risk process.

###### Actions Required for Compliance

- [ ] Create and get approval for a documented list (catalogue) of the eligible non-technical record types, including the required correlation information fields.
- [ ] Set up the insider-risk case intake process so that it only accepts cases with documented reasonable suspicion, a reference to approval from legal advice, and a clearly stated correlation scope.
- [ ] Set up least-privilege access controls for non-technical records using role-based access control (RBAC) and attribute-based access control (ABAC), allow temporary “just-in-time” permission increases when needed, and enable access logging.
- [ ] Integrate the case workflow with security information and event management (SIEM) and forensics correlation, so audit queries run only within the approved scope and according to the agreed subject mapping.
- [ ] Store the evidence from correlation activities alongside non-technical record references, audit record identifiers and timestamps, query identifiers and logic, and the identity of the analyst.
- [ ] Define and follow documented review and reporting steps, with oversight from Information Security and Privacy teams, before any outputs are used in day-to-day operations.


---

### AU-7 — Audit Record Reduction and Report Generation (Control)

This requirement ensures that authorised staff can collect and summarise existing records of system activity so they can quickly see what happened, identify unusual patterns, and produce clear reports if something goes wrong later. Without this, important evidence could be difficult to find, summaries could accidentally change the original facts, or events could be presented in the wrong order—making incidents harder to understand and harder to hold the right people and systems accountable.

To meet this expectation, the organisation must provide an on-demand capability that lets staff review, analyse, and create tailored reports for both routine checks and investigations after an incident. This must be done without changing the original record content and without altering the original time sequence. Any reduced summaries and generated reports must be stored separately from the original records, and the reports must reflect the correct chronology.

The organisation must document how this is done, assign named responsibilities, limit use to authorised personnel, and keep the relevant plans, procedures, design information, and configuration information up to date.

##### Query-time audit record reduction with ordered, immutable reporting

- Category: Software
- Priority: Critical

###### WHAT
Set up an on-demand capability that turns existing audit records into analyst-friendly summaries and produces tailored reports for routine review and investigations after an incident. This must keep the original audit record details unchanged and keep the original order of events in time.

###### WHY (control requirement)
AU-7 requires the organisation to **provide and implement audit record reduction and report generation capability** that supports **on-demand review and reporting**. It should use **advanced filtering and data mining** to spot unusual or suspicious behaviour. Importantly, it must ensure that **reduced outputs do not change or overwrite the original audit records**, and that **time order is preserved**—including when source systems do not provide timestamps with enough detail.

###### HOW (specific steps/approach)
1. **Load audit logs into an unchangeable, add-only audit store** (for example, write-once storage such as WORM, or an immutable event store) so the reduction and reporting process cannot rewrite the original audit records.
2. **Standardise and enforce event identity and timestamp detail when data is received**:
   - Require a stable **event identifier** (for example, `event_id` or a deterministic hash) and keep the **original event timestamp**.
   - Ensure timestamp detail is sufficient to order events correctly (prefer millisecond precision or better). If upstream systems provide less detail, add a deterministic secondary ordering method (for example, an ingestion sequence number) while still keeping the original timestamp field.
3. **Do reduction using “read-time” derived views** (or store non-destructive summaries separately):
   - Create saved queries and dashboards that filter, summarise, and add anomaly-focused context without changing the underlying immutable events.
   - Store reduced outputs (summaries, timelines, counts) in a **separate derived-data location**, with traceability back to the source `event_id` set.
4. **Create customised reports from the query results**:
   - Provide a report generator that runs parameterised queries (time window, system, account, event type) and produces reports that include the **ordering key** used.
   - Ensure report timelines and sequences reflect the preserved ordering (primary: event timestamp; secondary: deterministic tie-breaker).
5. **Limit and monitor who can run reduction and report generation**:
   - Use enterprise identity controls (role-based access control (RBAC) and least privilege) so only authorised Security Operations Centre (SOC), Incident Response (IR), and IT Audit roles can run reduction queries and export reports.
   - Record report generation activity (who/what/when/filters used) in a separate audit trail.
6. **Document the process and manage it through configuration control**:
   - Keep controlled documentation for the reduction and reporting process, including query logic, ordering rules, timestamp handling, and how evidence can be traced back to sources.
   - Use version control for query and report definitions, and manage changes through the organisation’s configuration and change management process.

###### WHO (role responsible)
- **Security Operations (SOC) / Incident Response Lead**: defines what analysts need in reports and which anomaly-focused filters to use.
- **Security Engineering / Security Information and Event Management (SIEM) / Audit Platform Engineer**: implements ingestion rules, immutable storage, read-time reduction, and the report generator.
- **Identity and Access Management (IAM) / Platform Access Administrator**: sets up role-based access control (RBAC) and manages access approvals using least privilege.
- **Compliance / Assurance**: checks that evidence is audit-ready (traceability, correct ordering, no modification) and reviews the documentation.

###### Acceptance criteria (verifiable)
- Reduced views and generated reports are produced **without modifying** the immutable source audit records (show that the source store is append-only and that reduction writes only to derived-data and report outputs).
- Reports preserve correct chronology: for a test dataset with events that share the same timestamp, the report ordering matches the defined ordering key (timestamp precision plus deterministic tie-breaker).
- Each report includes traceability to the underlying events (for example, a list of `event_id` references or a verifiable mapping to source records).
- Only authorised roles can run reduction and report generation; all executions and exports are logged to a separate audit trail.
- Timestamp precision handling is documented and evidenced (ingestion contract plus configuration showing the enforcement and normalisation rules).

###### Actions Required for Compliance

- [ ] Set up an audit log that cannot be changed and only grows by adding new entries, so all collected audit records used for reduction and reporting are securely recorded.
- [ ] Define and enforce an ingestion agreement that requires each event to have a stable, unchanging identifier and that the original event time is kept, with enough detail (granularity) to distinguish events accurately.
- [ ] Create query-time reduction saved queries (and/or non-destructive derived summaries) that never overwrite the original audit events.
- [ ] Set up report generation so it uses parameterised queries and sorts the results using the saved timestamp, with a consistent tie-breaker when timestamps are the same.
- [ ] Limit report creation, report generation, and report exports to authorised Security Operations Centre (SOC), Incident Response (IR), and Information Technology (IT) Audit roles using enterprise role-based access control (RBAC), and record all report actions in logs.
- [ ] Create and maintain version-controlled definitions for queries and reports. Document the end-to-end reduction and reporting workflow, the ordering rules, and how evidence can be traced back to its source.


---

#### AU-7.1 — Automatic Processing (Enhancement)

This expectation is about helping the organisation quickly find the right evidence in its event logs. It requires the organisation to automatically sort and search log records for the incidents that matter. Without this, important signs of misuse, failed access attempts, or suspicious activity could be lost among thousands of entries. That would slow down investigations and make it more likely that wrongdoing is missed or dealt with too late.

To meet this expectation, the organisation must clearly define which information in each log entry will be used to identify events of interest. This includes what happened, when it happened, whether it succeeded or failed, who was involved, the source and destination network addresses, the system component involved, what information was accessed, and where the event occurred.

The organisation must then put in place and run an automated capability that processes, sorts, and searches these records using the same defined information every time. This capability must support filtering by each field, including the organisation’s chosen level of detail for location, so staff can reliably produce reports and retrieve the matching records when needed.

##### Automated audit record indexing and field-based search

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated capability that **processes, organises, and searches audit records** for “events of interest” using the organisation-defined **fields within audit records** (AU-07.01_odp).

###### WHY (control requirement)
AU-7(1) (Enhancement) requires the organisation to provide and implement the capability to **process, organise, and search audit records** for events of interest, based on the content specified by **{{ insert: param, au-07.01_odp }}**. The guidance explains that events of interest are identified from audit record content such as **event type, event dates/times, success/failure, identities, IP addresses, system resources, information objects, and event locations**.

###### HOW (specific steps/approach)
1. **Define a standard “audit search structure”** in the security information and event management (SIEM) / log analytics layer using exactly the AU-07.01_odp fields: **event type, event date/time, success/failure, user identity, source/destination IP, system resource, information object, event location** (including the organisation’s chosen level of detail for location).
2. **Implement an intake and standardisation process** that reads each incoming audit record, extracts the fields above, and converts source-specific fields (for example, platform event identifiers and message formats) into the standard structure. Make sure **event_time** is kept as the timestamp used for sorting.
3. **Store the standard fields in a searchable way** using suitable data types (for example, a timestamp for event date/time; standardised forms for identities, IPs, system resources, information objects, and event locations) so the platform can reliably **sort and filter** by each field.
4. **Enable automated searching** by creating query templates/saved searches (or an internal application programming interface (API)) that let users filter by **each required field** and sort by **event date/time**. Ensure the returned results match the standard field values.
5. **Make “events of interest” repeatable for operations** by implementing the organisation-defined query templates/dashboards that analysts can run again and again for incident investigation and collecting evidence.
6. **Test end-to-end** using test audit events that include both success and failure outcomes, multiple identities, multiple IP endpoints, multiple system resources, multiple information objects, and multiple event locations; confirm the searches return the correct matching records.

###### WHO (role responsible)
- **Security Monitoring/Detection Engineer**: designs the standard structure, intake mappings, and search templates.
- **Platform/Cloud Logging Engineer**: sets up collectors and the processing pipeline.
- **SIEM Administrator**: manages indexing, retention, and access controls for search results.
- **Application Owner / System Owner** (as needed): confirms that the audit record fields are available and that the mapping is correct for the application’s audit sources.

###### Acceptance criteria
- The SIEM/log analytics platform can ingest audit records and **fill in all AU-07.01_odp fields** (event type, event date/time, success/failure, user identity, source/destination IP, system resource, information object, event location) for each processed record (or clearly document any exceptions where a source cannot provide a field).
- A user can run a search that **filters by each field individually** and **sorts by event date/time**, and the results match the expected records.
- End-to-end tests show that “events of interest” queries return the correct records for at least: (a) one success and one failure event, (b) multiple user identities, (c) distinct source/destination IPs, (d) distinct system resources and information objects, and (e) distinct event locations at the configured level of detail.
- Evidence is auditable: search queries/templates and field mappings are documented and version-controlled.

###### Actions Required for Compliance

- [ ] Define the standard audit search format, using the nine **AU-07.01_odp** fields, and set the organisation’s level of detail for where events are recorded.
- [ ] Set up data ingestion and standardisation rules to extract and fill every **AU-07.01_odp** field from each audit source.
- [ ] Set up indexing so the event date and time are saved in a format that can be sorted, and so all other fields can be searched and filtered.
- [ ] Create and publish query templates (or an internal search application programming interface (API)) that filter results by each **AU-07.01_odp** field and sort the results by the event date and time.
- [ ] Run full end-to-end checks using known audit records to confirm the system correctly matches outcomes (success or failure), users (identities), IP addresses, resources, information objects, and locations.
- [ ] Document how each field is mapped, the query templates used, and any limits from the source systems. Also keep evidence that the tests were completed successfully.


---

### AU-8 — Time Stamps (Control)

This expectation is about making sure every official activity record has the correct time, so the records can be trusted and properly investigated. If system clocks are wrong or do not match the organisation’s approved time source, audit records can appear in the wrong order. This makes it harder to spot suspicious behaviour, confirm what happened, or respond quickly when something goes wrong.

To meet this expectation, the organisation must ensure audit records are time-stamped using the system’s own internal clock, but that clock must be accurate to within 10 milliseconds of the organisation-approved time source.

The recorded time must be written in a clear, consistent way: either using Coordinated Universal Time (UTC), or using a fixed local time offset from UTC, or explicitly including that local offset as part of the timestamp. The organisation should document how this is done and configure systems so the timestamp format and time source settings match the documented approach.

##### Enforce 10ms time sync and UTC/offset audit timestamps

- Category: Software
- Priority: Critical

###### WHAT
Implement an enterprise-standard approach for setting system time and recording audit timestamps, so that every audit record timestamp is created using the system’s internal clock, stays accurate to within **10 milliseconds** of the organisation-approved time source, and is sent in **Coordinated Universal Time (UTC)** or a **fixed local UTC offset** (or with the **offset included** in the timestamp).

###### WHY (control requirement)
AU-8 requires that **system-generated timestamps include the date and time**, and that the organisation defines and enforces the **level of time detail (granularity)** used for audit record timestamps. The guidance also notes that time service accuracy (for example, within tens or hundreds of milliseconds) is important because it supports other security features and helps ensure audit trails are trustworthy.

###### HOW (specific steps/approach)
1. **Define and publish the organisation-approved time source(s)** (for example, authoritative Network Time Protocol (NTP) / Precision Time Protocol (PTP) endpoints) and the expected accuracy and role (primary or secondary) for the application’s hosting environments.
2. **Synchronise the application host clocks** (virtual machines, containers where applicable, and any supporting nodes that generate audit events) to the approved time source using operating system or platform time services, and enforce the settings using infrastructure-as-code.
3. **Set and standardise the timestamp format** for audit logging across the application and the logging pipeline:
   - Use **UTC** by default; or
   - If local time is required, use a **fixed offset from UTC** and ensure the **offset is included** in the timestamp that is sent (for example, ISO-8601 with an offset), avoiding daylight saving time (DST) confusion.
4. **Continuously check that accuracy stays within 10ms** by monitoring the measured difference from the approved time source (not just confirming “NTP is enabled”). Trigger alerts as the difference approaches the **10ms** limit and when nodes stop synchronising.
5. **Stop non-compliant audit events**: check the timestamp structure, time zone, and offset at the application logging stage and/or the security information and event management (SIEM) ingestion stage; hold back or flag events that do not match the required UTC/fixed-offset format.
6. **Create audit-ready evidence**: keep configuration evidence (time service settings, approved time source identifiers) and monitoring evidence (offset measurements and alerts) for production, test, and disaster recovery (DR) environments.

###### WHO (role responsible)
- **Platform/Infrastructure Engineering**: implement and enforce time synchronisation configuration and monitoring on hosting nodes.
- **Application Engineering**: configure audit logging to send UTC or fixed-offset timestamps, with the offset included.
- **Security Operations / SIEM Team**: implement ingestion checks (including quarantine rules) and retain evidence.
- **Compliance/Assurance**: confirm evidence completeness against the organisation-defined time detail level (10ms).

###### Acceptance criteria
- For all production audit record sources, the measured clock difference from the organisation-approved time source is **within 10ms** at the time audit events are generated (confirmed using monitoring data/exports).
- Audit records produced by the application/logging pipeline use **UTC** or a **fixed local UTC offset** with the **offset included** (no daylight saving time–dependent ambiguity).
- If drift exceeds a pre-defined warning threshold (set to allow fixes before the 10ms limit is breached), alerts are generated and the remediation actions are recorded.
- An evidence pack exists for each environment (production/test/DR): time service configuration, approved time source identifiers, and monitoring outputs showing 10ms compliance.

###### Actions Required for Compliance

- [ ] Publish the organisation-approved time source(s) and the expected accuracy for the application hosting environments.
- [ ] Set up and require operating system and platform time synchronisation on all nodes that generate audit records, so they all use the approved time source.
- [ ] Standardise application audit logging so that it records timestamps in Coordinated Universal Time (UTC) or in a fixed local UTC offset, and includes the offset in the timestamp.
- [ ] Set up monitoring to check how far the system clock differs from the approved time source, and raise an alert when it gets close to the 10 millisecond (10ms) limit.
- [ ] Add security information and event management (SIEM) and log ingestion checks to reject, quarantine, or flag audit events that have a timestamp with an incorrect format, time zone, or offset.
- [ ] Collect and keep evidence (configuration and monitoring reports) for the live (production), testing (test), and disaster recovery environments.


---

### AU-9 — Protection of Audit Information (Control)

This expectation is about keeping records of system activity safe, and making sure you are told immediately if someone tries to tamper with or remove them. These audit records, the settings that control what is recorded, the reports they produce, and any personal details used in the process are vital evidence for investigations. If unauthorised people can access, change, or delete this information, wrongdoing can be hidden and accountability becomes impossible.

To meet this expectation, the organisation must clearly define what counts as audit information and which tools are used to create and manage audit logs, then limit access to both to authorised staff only. It must stop unauthorised changes and deletions of the audit information and the audit logging tools, detect attempts to access, alter, or delete audit information, and automatically alert the Security Operations Centre incident responder and the system security officer using an agreed, working method as soon as this activity is detected.

##### Restrict and tamper-evidence audit logs with automated SOC alerts

- Category: Software
- Priority: Critical

###### WHAT
Put in place technical and process controls so that audit information (audit records, audit log settings, audit reports, and any personal data used for auditing) and the audit logging tools are available only to authorised roles, are protected from unauthorised changes or deletion, and automatically trigger alerts to the **Security Operations Centre (SOC) incident responder** and the **system security officer** when this kind of activity is detected.

###### WHY (control requirement)
AU-9 requires protection of audit information and audit logging tools by restricting access and use to authorised people, preventing unauthorised changes or deletion, detecting unauthorised access/changes/deletion, and alerting the **Security Operations Centre (SOC) incident responder** and the **system security officer** (roles defined by the organisation).

###### HOW (specific steps/approach)
1. **Define and list audit information and audit logging tools for each environment (production/test/disaster recovery):**
   - Identify audit records, audit log settings, audit reports, and any personal data used for auditing.
   - Identify the actual audit logging tools (for example: the operating system audit feature, application audit outputs, syslog receivers, log collection tools/agents, security information and event management (SIEM) intake services, and admin consoles used to manage logging).
2. **Use identity-based access and the minimum permissions needed for audit information and audit logging tools:**
   - Connect access to log search/export/admin consoles and any “change logging settings” screens to the organisation’s identity provider (IdP).
   - Create dedicated roles (for example, *Audit Viewer* and *Audit Admin*) and ensure only the Security Operations Centre (SOC) incident responder and the system security officer (and any explicitly approved log administrators) can view or change audit logs/settings.
   - Require phishing-resistant multi-factor authentication (MFA) for any role that can view or change audit logs/settings.
3. **Make audit log storage and sending resistant to tampering:**
   - Send audit events to a central security information and event management (SIEM) or log platform using controlled access credentials.
   - Configure the central platform to use “add-only” (append-only) or “write-once” style protection, or equivalent protection, and enable integrity checks where supported.
   - Ensure that local log rotation/retention cannot be changed by unauthorised users (where the platform allows), and that changes to logging configuration are recorded as audit events.
4. **Detect unauthorised access/changes/deletion and alert automatically:**
   - Set up detection rules for events such as: changes to audit log settings, attempts to stop or disable logging services, deletion or truncation of audit logs, unauthorised access to log search/export, and unauthorised changes to log collector/agent configuration.
   - Send alerts to the Security Operations Centre (SOC) using an agreed method (for example, security information and event management (SIEM) alerts to the ticketing/incident channel) and ensure both the Security Operations Centre (SOC) incident responder and the system security officer are included.
5. **Strengthen administrative access and change control:**
   - Limit the administrative interfaces (network, host, and application) used to manage audit logging tools.
   - Manage audit log settings through configuration management and policy-based controls with review and approval, so unauthorised changes are prevented and authorised changes can be traced.

###### WHO (role responsible)
- **Security Operations Centre (SOC) incident responder:** receives and reviews AU-9 alerts; checks that detections are accurate.
- **System security officer:** owns AU-9 detection and alert settings, approves access, and ensures the control is operating as intended.
- **Platform/Infrastructure security engineer:** sets up tamper-resistant forwarding, immutability protections, and access controls.
- **Identity and access management (IAM) administrator:** sets up identity provider (IdP) roles, multi-factor authentication (MFA), and periodic access reviews.

###### Acceptance criteria
- Only authorised roles can access audit records, audit log settings, audit reports, and the administration interfaces for audit logging tools.
- Audit logs are sent to a central platform with tamper-resistant/immutable storage characteristics (or equivalent integrity protections) and integrity checks.
- Attempts to access, change, delete, or disable/alter audit information or audit logging tools generate detectable events.
- Automated alerts are produced by the detection rules (not manual judgement) and are sent to both the Security Operations Centre (SOC) incident responder and the system security officer through the agreed operational channel.
- Evidence is available for: (a) the audit information/tool inventory, (b) the access control setup, (c) the immutability/tamper-evidence setup, and (d) detection rule coverage and alert delivery testing.

###### Actions Required for Compliance

- [ ] Create an inventory of all audit information types and document which audit logging tools are used for each environment.
- [ ] Set up identity provider (IdP)–integrated roles that allow access to audit logs and administration of audit log settings, using the minimum permissions needed (least privilege).
- [ ] Require phishing-resistant multi-factor authentication (MFA) for any role that can view or change audit logs or settings.
- [ ] Set up central log forwarding using append-only or write-once storage (or an equivalent “cannot be changed” approach), and include checks that verify the logs’ integrity.
- [ ] Set up detection rules to identify unauthorised access to, changes to, truncation (shortening), deletion, or disabling of audit logging tools.
- [ ] Set up automated alert routing so that both the security operations centre (SOC) incident responder and the system security officer receive AU-9 alerts.
- [ ] Test and record evidence that alerts are generated by simulating unauthorised attempts to access, change, or delete audit information.


---

#### AU-9.1 — Hardware Write-once Media (Enhancement)

This requirement is about making sure your important records of system activity are written so they cannot be changed after they are created. These records are used to spot suspicious behaviour, investigate what happened, and report it. If the records can be altered, overwritten, or reused, wrongdoing could be hidden and investigations could be undermined.

To meet this expectation, the organisation must write the first set of audit trail records used for detection, analysis and reporting, and also any backups of those audit trails, onto hardware-enforced write-once, read-many media such as CD-R, DVD-R or BD-R. With this type of media, the medium itself prevents changes once writing is finished.

The organisation must not use simpler “write-protected” or re-writable media such as USB drives, tape cartridges, CD-RW or DVD-RW for this purpose.

The organisation must document which media is used, where it is stored, and the steps and responsibilities for writing and protecting it. It must also be able to provide evidence that the initial audit trail and backups were actually written to the correct write-once media.

##### Write initial audit trails and backups to hardware WORM media

- Category: Software
- Priority: Critical

###### WHAT
Create the **initial audit trail** (the set of audit records used for detection, analysis, and reporting) and its **audit trail backups** on **hardware-enforced write-once read-many (WORM) media** (for example, CD-R, DVD-R, BD-R). This ensures the media cannot be changed after writing is finished.

###### WHY (control requirement)
The United States National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **AU-9(1)** enhancement requires: **“Write audit trails to hardware-enforced, write-once media.”** The guidance explains this applies to:
- the **first creation of audit trail packages** (the audit trail used for detection, analysis, and reporting), and
- the **backup of those audit trail packages**,

and **does not** apply to raw audit records before they are written into an audit trail.

It also clarifies that **WORM** is different from:
- **write-protected** media, or
- **re-writable** media (for example, USB, tape, CD-RW, DVD-RW).

###### HOW (specific steps/approach)
Set up an auditable “package-to-WORM” process where the system performs only the **final write** to approved WORM media, using a clear **finalise/close** step that locks the content so it cannot be altered.

1. **Select and document approved WORM media types**: Choose the specific hardware-enforced WORM media types allowed for storing audit trails (for example, CD-R, DVD-R, BD-R). Record the exact media identifiers/part numbers and where they are stored.
2. **Define where audit trail packaging starts and ends**: Make sure the system produces **audit trail packages** (time-limited batches) that represent the **initial audit trail** used for detection, analysis, and reporting. Do not try to write the raw event outputs directly to WORM.
3. **Write to WORM only at the final stage**: Configure the security information and event management (SIEM) / logging system or audit archiving process so packages are prepared in a controlled area that can be changed, and then the **final write** is done only to the WORM device/media.
4. **Enforce hardware finalisation/closure**: Configure the WORM writing process to run the device-specific **finalise/close** operation after a successful write. If finalisation fails, treat it as a control exception and **do not** mark the package as “archived”.
5. **Back up to WORM using the same approach**: Copy/backup each completed audit trail package to a second set of WORM media (or a second WORM target) using the same finalise/close process.
6. **Create and keep proof (evidence)**: For each package, store an unchangeable record (manifest) that includes: package ID, time window, hash(es), WORM media identifier(s), writer/device identifier, and the finalisation result. Keep these manifests in an auditable location for review during assessment.
7. **Stop use of non-write-once media**: Use technical and procedural controls so the final write destination cannot be redirected to USB, tape, CD-RW, or DVD-RW. For example: restrict allowed writer targets, enforce workflow permissions, and check the media type before the final write.

###### WHO
- **Security/Compliance Lead**: approves the WORM media types, the retention approach, and what evidence must be kept.
- **Security information and event management (SIEM) / Logging Platform Owner** (or **Log Management Engineer**): builds the package-to-WORM workflow and ensures finalise/close enforcement.
- **IT Operations / Archive Administrator**: handles media in a controlled way and maintains the media inventory and storage locations.
- **Internal Audit / Assurance**: checks the evidence (manifests, finalisation logs, media identifiers) during assessment.

###### Acceptance criteria
- The initial audit trail packages and their backups are written to **hardware-enforced WORM media** (approved CD-R/DVD-R/BD-R) and each package has a recorded successful **finalise/close** step.
- No audit trail packages are marked as “archived” unless the WORM finalisation step succeeded.
- Evidence exists for each package: a manifest with hash(es), time window, WORM media identifier(s), writer/device identifier, and finalisation outcome.
- The workflow prevents final writes to non-write-once media (USB/tape/CD-RW/DVD-RW) and raises exceptions if an invalid destination/media type is selected.
- Storage locations and responsibilities for media handling are documented and followed.

###### Actions Required for Compliance

- [ ] Define and get approval for the approved “write once, read many” (WORM) media types that are protected by hardware (for example, CD-R, DVD-R, and BD-R). Also record where this data is stored and who is responsible for it.
- [ ] Set up an audit-trail packaging process that creates the first audit-trail packages as time-limited batches for detection, investigation, and reporting.
- [ ] Set up the logging and security information and event management (SIEM) export process so that packages are first placed in a controlled, changeable staging area, and then written only once to the write-once, read-many (WORM) storage target.
- [ ] After every successful write to write-once, read-many (WORM) storage, complete a device-specific “finalise/close” step. If that finalise/close step does not succeed, stop and fail the archive process.
- [ ] Set up automatic backup and copying of each completed audit trail package to a second write-once, read-many (WORM) media set, using the same “finalise/close” rules.
- [ ] Create unchangeable, per-package evidence records (including hashes, the time window, write-once-read-many (WORM) media identifiers, writer/device ID, and the finalisation outcome) and keep them for audit purposes.
- [ ] Set up technical allow-listing and checks to stop any final saving to write-once media (USB, tape, CD-RW, DVD-RW). If a selection is not valid, raise an exception.


---

#### AU-9.2 — Store on Separate Physical Systems or Components (Enhancement)

This requirement is about keeping records of system activity in a location that is physically separate from the systems being monitored. The risk it addresses is that if the monitored system is compromised, an attacker could change or delete the evidence of what happened, or prevent it from being available when you need it for investigations, compliance, or accountability.

To meet this expectation, the organisation must store audit records as soon as they are created, and again when they are backed up for long-term storage. These records must be kept in a repository that uses different physical hardware or a different physical component from the system or component being audited. This separation must apply to the original records, backup copies, and long-term archive copies, so the audit evidence stays protected even if the audited system is affected.

##### Physically separate audit repository with backup and archive tiers

- Category: Software
- Priority: Critical

###### WHAT
Keep audit records in a repository that is part of a **physically separate system or component** from the system/component being audited. This separation must apply to **initial creation**, **backups**, and **long-term storage**.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) AU-9(2) enhancement requires that audit records {{ insert: param, au-09.02_odp }} are stored in a repository that is **physically different** from the audited system/component. The organisation-defined timing is **immediately after creation**, and again for **backups** and **long-term storage**.

###### HOW (specific approach)
Set up a dedicated, organisation-managed **Audit Collector** repository on infrastructure that is physically separate from the audited systems, using separate **backup vault** and **long-term archive** storage tiers:
1. **Immediate creation path:** Configure each audited system/component to send audit events to the Audit Collector **immediately after creation** (use forwarding without installing software where possible; allow only small local buffering for resilience).
2. **Physically separate repository:** Run the Audit Collector on dedicated servers/storage (for example, a separate rack/room and a separate storage system/volume group) so that a compromise of the audited environment cannot directly compromise the audit repository.
3. **Backup separation:** Back up the Audit Collector repository to a **backup vault** on physically different infrastructure (separate backup servers/storage; make sure backup media/targets are not stored alongside the audited systems).
4. **Long-term archive separation:** Move older audit records from the Audit Collector repository to a **long-term archive** tier on physically different infrastructure (for example, a separate archive storage platform with retention controls).
5. **Evidence and mapping:** Keep an auditable record of which assets map to which components. For each audited system/component, record the corresponding Audit Collector host/storage asset IDs and the backup/archive asset IDs, including physical location identifiers (rack/room/site).

###### WHO
- **Security Architect / Compliance Lead:** defines the separation design and approves the physical segregation approach.
- **Infrastructure/Platform Engineering:** deploys and configures the Audit Collector, backup vault, and archive tiers.
- **Security Information and Event Management (SIEM) / Logging Engineering:** implements event forwarding, event formatting (parsing), and reliable event intake.
- **Operations/IT Service Owner:** ensures day-to-day operation, monitoring, and change control.

###### Acceptance criteria
- Audit events from a representative audited system are written to the Audit Collector repository **immediately after creation** under normal operating conditions.
- The Audit Collector repository, backup vault, and long-term archive tiers are hosted on **physically different** systems/components than the audited systems (checked using the asset inventory and physical location records).
- Backups of audit records are stored in the physically separate backup vault, and long-term archives are stored in the physically separate archive tier.
- Evidence package exists: documentation showing forwarding targets, backup/archive job scope including audit datasets, and an asset-to-physical-location mapping table for the audit evidence chain (audited system → collector → backup vault → archive).

###### Actions Required for Compliance

- [ ] Set up an audit evidence chain—showing how evidence moves from the audited system to the audit collector, then to the backup vault, and finally to the long-term archive—and document that the locations are physically separated (site, rack, room, and storage array separation).
- [ ] Set up every audited system or component to send audit records to the Audit Collector immediately when they are created (reduce or turn off dependence on local buffering, except where it is needed for resilience).
- [ ] Install the Audit Collector repository on separate physical servers and limit administrative access to it using approved privileged access controls.
- [ ] Set up backup jobs so they include the Audit Collector audit data sets, and store the backups in a separate backup vault that is physically different from the main systems.
- [ ] Set up long-term archiving and retention so that audit records are moved from the Audit Collector storage area to a separate, physically distinct archive storage tier.
- [ ] Create and keep an auditable record that links each audited system or component to its data collector, backup, and archive asset identifiers, and to its physical location.


---

#### AU-9.3 — Cryptographic Protection (Enhancement)

This requirement is about ensuring that your audit records, and the tools used to produce and check them, cannot be changed in secret without being detected. Without this, someone could tamper with evidence of what happened (or change the software that reviews it), and you may not find out until it is too late—damaging investigations, compliance, and confidence in decisions.

To meet this expectation, the organisation must use approved cryptographic integrity protection. This means both the audit information and the audit tools are protected with digitally signed checks. A secret signing key creates a verifiable integrity mark, and a publicly available verification key allows authorised people to confirm later that nothing has been altered.

The secret signing key must be protected against unauthorised access, and the public verification information must be available for verification. The organisation must document how this is done, store the integrity evidence together with the audit information and tools, and ensure that any integrity check failure is clearly flagged and recorded with enough detail to identify what was affected and when.

##### Asymmetric signatures for audit records and verification evidence

- Category: Software
- Priority: Critical

###### WHAT
Put in place cryptographic controls to protect the **integrity of audit information**. This means creating **signed hash evidence** for audit records, and using automated checks that produce clear, auditable **pass/fail** results.

###### WHY (control requirement)
NIST AU-9(3) (Enhancement) requires: **"Implement cryptographic mechanisms to protect the integrity of audit information and audit tools."** The guidance specifies using **signed hash functions with asymmetric cryptography**. In this approach, a **secret key** is used to sign, and a **public key** is used to verify. This allows unauthorised changes to audit information to be detected.

###### HOW (specific steps/approach)
1. **Define the audit record integrity scope**: decide which audit events and fields count as “audit information” for this application (for example: event type, actor identity, target, timestamp, source system, schema version, and a stable event identifier).
2. **Standardise audit content before hashing**: convert each record into a consistent, repeatable format before creating the hash (for example: canonical JSON with a fixed key order, a fixed timestamp format, and consistent encodings). This prevents attackers bypassing the control through formatting differences.
3. **Create signed integrity evidence**: for each audit record (or a justified batch of records), calculate a hash of the standardised content and sign it using an **approved asymmetric algorithm** (for example: ECDSA or RSASSA-PSS with SHA-256/384). Store the signature (or signed hash) with the audit record.
4. **Secure the signing secret key**: perform signing using a dedicated signing service protected by a hardware security module (HSM) or key management service (KMS), or an equivalent enterprise key management solution. Use strict access controls and separate responsibilities.
5. **Make verification information available**: provide the matching **public verification key/certificate** to those who need to verify (for example: a read-only certificate store or a signed metadata endpoint). Record the key identifier and version with each signature.
6. **Verify and record outcomes**: run verification jobs (scheduled and on-demand) that check signatures using the public key. Save the verification results (pass/fail, key identifier, record identifier, timestamp, and failure reason) as **separate auditable events**.
7. **Treat verification failures as evidence**: if verification fails or signatures are missing, raise an alert and record enough detail to understand what was affected and when (record identifier, source, and whether the expected signature was present and valid).
8. **Document the approach**: document the signing and verification design, the standardisation method, who is responsible for key handling, and the operational steps for key changes and handling verification failures.

###### WHO
- **Application owner / Security architect**: defines the audit scope and integrity model.
- **Platform/infrastructure team**: builds the signing service integration with HSM/KMS and manages the key lifecycle.
- **Developers**: implement standardisation, attach signatures to audit records, and integrate verification job processing.
- **SOC/SIEM operations**: monitors verification failure alerts and ensures evidence is retained.

###### Acceptance criteria
- Every selected audit record includes cryptographic integrity evidence (signed hash/signature) created using an asymmetric signing key.
- Verification using the published public key succeeds for records that have not been changed, and fails for records that have been changed or are missing signatures.
- Signing keys are stored and used only through an approved key management mechanism (HSM/KMS) with restricted access.
- Verification results (pass/fail) are generated and kept as auditable events, with traceable record identifiers and failure reasons.
- Documentation exists covering standardisation, signing and verification workflow, key handling, and key rotation/incident procedures.

###### Actions Required for Compliance

- [ ] Choose and document which audit events and data fields are covered by cryptographic integrity protection.
- [ ] Apply a consistent, repeatable format to audit records before creating the hash (a unique digital fingerprint).
- [ ] Use an approved digital signing service that uses hardware security modules (HSMs) or key management services (KMSs) to sign a separate digital “fingerprint” (hash) for each record, or for a justified group of records.
- [ ] Store the signature and the key identifier with every audit record in the audit store.
- [ ] Publish the matching public verification key or certificate, and make sure verifiers can reliably find and download it.
- [ ] Set up automated checks that verify digital signatures and record clear, auditable pass or fail results for each verification.
- [ ] Create alert and evidence-handling procedures for missing or invalid signatures, including the record identifiers and the reasons for each failure.


---

#### AU-9.4 — Access by Subset of Privileged Users (Enhancement)

This requirement ensures that only a very small, approved group of people can control the system’s audit log settings and the process that records audit events. This is important because if other highly trusted staff could change or interfere with audit logging, they might accidentally or deliberately stop records being created, or change what the records show. That would make it harder to investigate issues or confirm what happened.

To meet this expectation, the organisation must formally authorise audit log management only for:
- audit logging administrators (the people who run the audit log collection and processing process), and
- the system security officer.

The organisation must prevent everyone else who has privileged access from making changes to audit logging.

The organisation must also keep an up-to-date list of who is allowed to manage audit logging, and ensure the system’s access permissions match that list exactly. The rules must be clearly documented so access can be checked and verified over time.

##### RBAC restricts audit logging management to authorised subset

- Category: Software
- Priority: Critical

###### WHAT
Limit *management of audit logging functionality* so that only the organisation-defined subset of privileged users/roles—**audit logging administrators (security information and event management (SIEM)/audit pipeline operators)** and the **system security officer** (parameter **au-09.04_odp**)—can enable or disable audit logging, change audit logging settings, and manage how audit logs are handled.

###### WHY (control requirement)
NIST AU-9(4) requires: **“Authorize access to management of audit logging functionality to only {{ insert: param, au-09.04_odp }}.”** The goal is to stop privileged users from stopping audit activity or changing audit records, so audit reliability is protected.

###### HOW (specific steps/approach)
1. **Define the authorised roles in the enterprise identity provider (IdP)/identity and access management (IAM)** as two role categories that match **au-09.04_odp**: `AuditLoggingAdmin` and `SystemSecurityOfficer`.
2. **Use deny-by-default authorisation in the audit logging management area** (the user interface (UI), application programming interface (API), command line interface (CLI), or console used to manage audit logging). Give management permissions only to those two role categories; make sure all other privileged identities are explicitly denied.
3. **Link roles to the exact audit logging management permissions** in the audit logging platform(s) (for example, SIEM, log pipeline/orchestration, and audit log retention/forwarding controls). Apply least privilege for actions such as enable or disable, retention changes, routing or forwarding changes, and any “audit settings” changes.
4. **Require stronger sign-in (step-up authentication) and apply conditional access** for audit logging management actions (for example, phishing-resistant multi-factor authentication (MFA) and passkeys, plus restricted admin network/location) specifically for audit logging management endpoints.
5. **Keep an auditable, reconciled list of the “effective authorised subset”** by exporting (a) IdP group/role membership and (b) the audit platform’s effective management authorisations, then comparing them and alerting on any differences (drift).
6. **Record and monitor audit logging management actions** (who did what and when) and alert on any attempted access by unauthorised privileged users.

###### WHO (role responsible)
- **IAM/Identity Engineer**: create and manage `AuditLoggingAdmin` and `SystemSecurityOfficer` roles/groups and conditional access policies.
- **SIEM/Logging Platform Administrator**: set up role-to-permission mappings in the audit logging platform(s).
- **System Security Officer**: checks the authorised subset and approves changes to the role mapping.
- **Security Operations / security operations centre (SOC)**: monitors alerts for unauthorised attempts and management actions.

###### Acceptance criteria
- Only identities in the **au-09.04_odp** subset can successfully carry out audit logging management actions (enable or disable, configuration changes, retention/routing changes) in the audit logging management area.
- All other privileged users/roles are blocked (deny-by-default) and receive access denied responses for management actions.
- The organisation can provide audit-ready evidence showing the authorised subset (IdP membership) and the effective management authorisations in the audit logging platform, including reconciliation results showing no drift.
- Audit logging management actions are recorded with enough detail (person, action, target, time) and are monitored with alerts for unauthorised attempts.

###### Actions Required for Compliance

- [ ] Create identity provider (IdP) roles and groups for `AuditLoggingAdmin` and `SystemSecurityOfficer` in line with au-09.04_odp.
- [ ] Set up “deny by default” authorisation for the audit logging management user interface (UI), application programming interface (API), and command-line interface (CLI), so only approved roles can manage audit logging.
- [ ] For each role, assign the smallest set of audit logging management permissions needed (to allow or block logging, change settings, set how long logs are kept, and send logs to the right place).
- [ ] Require additional sign-in verification (step-up authentication) and apply access rules based on the situation for actions that manage audit logging.
- [ ] Put in place a reconciliation process between identity provider (IdP) membership and the audit platform’s effective management authorisations, and raise alerts if there are any differences (drift).
- [ ] Enable audit trails and monitoring for all actions related to managing audit logs and for any unauthorised access attempts.


---

#### AU-9.5 — Dual Authorization (Enhancement)

This requirement is about making sure that no single person can quietly change the records that show what happened on your most sensitive on-premises systems. Specifically, any movement or deletion of audit log records for security-relevant events on systems that handle Confidential and Secret data must be approved by two different authorised people.

Without this “two-person” safeguard, a dishonest or compromised insider could remove or alter evidence, making wrongdoing harder to detect, investigate, or prove.

To meet this expectation, the organisation must:
- clearly state that dual approval applies to both moving and deleting those audit records;
- use a process that prevents the change unless two authorised individuals approve it; and
- keep records showing who approved the change and when.

The organisation should also rotate which people carry out these dual approvals over time to reduce the risk of collusion. An exception should only be allowed when immediate action is needed to protect public and environmental safety. In that case, the reason for the emergency must be recorded, and the change must still be handled through an approved process.

##### Two-person approval for audit log movement/deletion (Conf/Secret)

- Category: Software
- Priority: Critical

###### WHAT
Put in place a “two-person control” process that requires **two separate authorised people** to approve any **movement** or **deletion** of **security-relevant audit log records** on **on-premises systems** that handle **Confidential** and **Secret** information. The log change must not happen unless the **exact action** is approved by **two different authorised individuals**.

###### WHY (control requirement)
This requirement comes from **National Institute of Standards and Technology (NIST) AU-9(5)**, which states: **“Enforce dual authorization for {{ param, au-09.05_odp.01 }} of {{ param, au-09.05_odp.02 }}.”** The guidance also requires two-person approval to reduce the risk of collusion. It expects **rotation of who can approve** and allows an exception only when **immediate action is needed to protect public and environmental safety**.

###### HOW (specific steps/approach)
1. **Define exactly which actions and systems are covered** in an auditable control definition:
   - Scope AU-09.05_odp.01 = **movement, deletion**.
   - Scope AU-09.05_odp.02 = **audit log records for security-relevant events** on the on-premises systems that handle **Confidential** and **Secret** data.
   - Define what counts as “movement” (for example: archive/export/replication to another storage location) and what counts as “deletion” (for example: purge or overriding retention rules).
2. **Set up one control point** for log movement/deletion on each eligible on-premises log platform (for example: log storage, security information and event management (SIEM) ingestion/archival component, privileged log management tools):
   - Stop people from making direct administrative changes.
   - Use a **controlled execution application programming interface (API) or command-line interface (CLI) wrapper** that only allows the action when a **short-lived, signed authorisation token** is provided.
   - The wrapper must check the token and **refuse** the action if the required two-person approval evidence is missing or invalid.
3. **Create a two-person approval workflow** (information technology service management (ITSM) or approval engine, plus orchestration):
   - Require **two different approvers** chosen from an **authorised eligibility list**.
   - Record and link to the request: the target system, log type, record identifiers/time period, destination (for movement), and deletion scope.
   - Ensure the workflow cannot move to the **“execute”** step until both approvals are in place.
4. **Keep audit evidence that links approvals to execution**:
   - Store unchangeable records showing the request ID, both approvers’ identities, approval times, the exact parameters approved, and the token ID used to run the action.
   - Ensure the log platform also records that the operation happened and links it back to the workflow request ID.
5. **Rotate who is allowed to approve** to reduce collusion risk:
   - Use a rotation schedule for the eligibility list (for example, quarterly).
   - Ensure approvers are selected from the current eligible set.
   - Keep evidence of rotation (the schedule and who was eligible for each approval).
6. **Implement a limited emergency safety exception**:
   - Provide an emergency route only for **public/environmental safety**.
   - Require the emergency request to include a justification and still produce auditable evidence.
   - After the emergency action, require a follow-up review/attestation through the two-person approval process (or an equivalent governance review) within a defined time window.

###### WHO
- **Security Governance Lead / Compliance Owner**: defines what is in scope, when exceptions are allowed, and the rotation policy.
- **Platform Owner (SIEM/Log Platform)**: implements the control point (the execution wrapper/API validation) and ensures all actions go through it.
- **Identity and Access Management (IAM) Lead**: maintains the authorised approver eligibility list and multi-factor authentication (MFA) requirements.
- **Security Operations Centre (SOC)/Operations Manager**: runs the workflow, ensures emergency exceptions are used correctly, and completes the post-emergency review.

###### Acceptance criteria
- For any in-scope **movement** or **deletion** of security-relevant audit logs on eligible on-premises **Confidential/Secret** systems, the action **cannot be carried out** unless there are **two distinct authorised approvers**.
- Any attempt to execute without valid two-person approval tokens is **rejected** by the control point.
- For each executed operation, there is **audit evidence** showing both approvers, approval times, identities, and the exact approved parameters, and the log platform references the workflow request.
- Two-person approval eligibility is **rotated** according to the defined schedule, and rotation evidence is available for audit.
- Emergency exceptions are only available for **public/environmental safety**, include a justification, and have auditable follow-up review evidence.

###### Actions Required for Compliance

- [ ] Define and document what counts as “movement” and “deletion” for in-scope security-relevant audit log records on Confidential/Secret on-premises systems.
- [ ] Set up a controlled service (wrapper/application programming interface) for moving or deleting logs. This service should only allow the action when a valid, signed, short-lived authorisation token is provided, and the request has been approved by two authorised people.
- [ ] Set up a process that requires two different authorised approvers, and make their approvals apply only to the exact system, log, time range, and destination specified.
- [ ] Set up tamper-proof audit logs that record: the identity of both approvers, the date and time of approval, the approved parameters, and the token or request ID used to carry out the execution.
- [ ] Create and enforce an approved list of eligible approvers, using rotation scheduling, and keep supporting evidence for audit purposes.
- [ ] Create an emergency “exception” route that is only allowed to protect public or environmental safety, with a required written justification and a governance review after the action is taken.


---

#### AU-9.6 — Read-only Access (Enhancement)

This expectation is about ensuring that only the people who need to review records can access the organisation’s audit information, and that they cannot alter it. Audit information is the evidence trail of what happened in the system. If the wrong people can change or delete it, they could conceal suspicious activity and make later investigations unreliable.

To meet this expectation, the organisation must allow read-only access to audit information only for Security Operations Centre (SOC) analysts and the system auditor role, and prevent everyone else from accessing it in a way that would let them make changes. The system should enforce that these authorised roles can view audit records but cannot modify or delete them. It should also maintain an up-to-date, system-generated list showing exactly who has this read-only permission. The organisation should be able to demonstrate that this access list matches what the system actually allows in practice.

##### RBAC-enforced read-only audit access for SOC and system auditor

- Category: Software
- Priority: Critical

###### WHAT
Set up and enforce access rules so that only the approved subset of privileged users/roles—**security operations (SOC) analysts** and the **system auditor role**—can view audit information. They must be able to access it **strictly read-only** (they must not be able to modify, delete, purge, or clear audit records).

###### WHY (control requirement)
NIST SP 800-53 **AU-9(6)** (Enhancement) requires: *“Authorize read-only access to audit information to {{ insert: param, au-09.06_odp }}.”* The guidance explains that limiting privileged access to read-only reduces the risk of malicious cover-up, such as deleting audit records.

###### HOW (specific steps/approach)
1. **Define the authorised set** in the organisation’s access model exactly as per **param au-09.06_odp** (SOC analysts and the system auditor role).
2. **Create or standardise two dedicated access roles** in the enterprise identity provider (IdP) and link them to the minimum permissions needed to view audit information only (for example, `audit:read` and, if needed, `audit:export:read`).
3. **Enforce read-only controls at the point of access**:
   - For the audit viewer user interface: remove or disable any actions that could change audit data (delete, purge, clear, or overwrite).
   - For audit retrieval application programming interfaces (APIs) and log query endpoints: ensure server-side access checks block any change actions and reject any request that tries to alter audit records.
4. **Prevent all other roles** from accessing audit information in a way that allows changes:
   - Remove broad or automatic permissions (for example, “admin” groups) from audit viewing.
   - Ensure only the two dedicated roles are allowed to access the audit information resources.
5. **Keep an auditable, system-generated list of effective access**:
   - Store the effective access mappings (IdP group/role assignments and the application’s effective role-based access control (RBAC) decisions) in an evidence store.
   - Run periodic checks to confirm the effective access list matches the authorised set.

###### WHO (role responsible)
- **Identity and Access Management (IAM) Engineer / Security Architect**: set up IdP roles, RBAC mappings, and export the evidence.
- **Application Security Engineer / Backend Engineer**: enforce read-only server-side access controls for the audit viewer and audit APIs.
- **SOC Lead / System Auditor**: confirm that authorised users can view audit information and cannot perform destructive actions.

###### Acceptance criteria
- Only SOC analysts and the system auditor role can successfully retrieve audit information.
- Any attempt by any other role to access audit information (or any attempt to use delete/purge/clear functionality) is blocked by server-side controls.
- Read-only roles cannot delete, purge, clear, or overwrite audit records via either the user interface or the API.
- An auditable evidence record exists showing the **effective** read-only authorisation list, and it is periodically checked against the authorised set.

###### Actions Required for Compliance

- [ ] Create separate identity provider (IdP) roles for security operations centre (SOC) analysts and the system auditor, using the least-privilege permissions possible, limited to viewing audit information (for example, `audit:read`).
- [ ] Set up the audit viewer screen so that read-only users cannot perform any destructive actions (delete, purge, clear, or overwrite).
- [ ] Set up authorisation checks on the server for every audit record retrieval page, and block (explicitly deny) any audit record changes for users who do not have the required permissions.
- [ ] Remove any wide audit access permissions that have been granted to other privileged groups, and confirm that only the au-09.06_odp roles are able to access audit information.
- [ ] Create and store an evidence export showing the effective audit read-only access list (identity provider assignments and role-based access control decisions for applications).
- [ ] Run a regular reconciliation check to compare the current effective access list against the authorised list, and raise an alert if they differ.


---

#### AU-9.7 — Store on Component with Different Operating System (Enhancement)

This requirement is about keeping records of important system activity safe from problems that could affect the system itself. If audit records are kept on the same type of computer and operating system as the system being monitored, then a weakness in that operating system could let an attacker change or destroy the very evidence needed to investigate what happened.

To meet this requirement, the organisation must:
- identify which systems generate audit records, and
- store those records on a separate computing component that uses a different operating system from the one being audited.

The organisation should be able to demonstrate, using documented settings and system records, exactly where the audit records are sent and which operating system the receiving component uses. It must also ensure the configuration is actually set up so records are sent to that location.

The organisation should keep its policies and system documentation up to date, including checking during any changes that this separation is still in place.

##### OS-diverse authoritative audit log storage via remote collector

- Category: Software
- Priority: Critical

###### WHAT
For each system/component being audited, store its audit information on a separate computing component that uses a different operating system from the one being audited.

###### WHY (control requirement)
AU-9(7) enhancement requires that audit information be stored on a component running a different operating system from the system/component being audited. This lowers the risk that an operating system–specific weakness could affect both the audited system and the audit records.

###### HOW (specific steps/approach)
1. **Choose an official audit storage component** (for example, a log collector or log server cluster) and document the **operating system pairing rule** (for example, Windows systems send logs to a Linux collector; Linux systems send logs to a Windows collector, or vice versa).
2. **List every source that produces audit information** (servers, endpoints, network devices, and any application parts that generate security-relevant audit events). Record them in a logging catalogue/configuration database mapping: *source system → official log destination → destination operating system*.
3. **Set up audit forwarding** so audit events are sent to the official log destination (for example, Windows Event Forwarding and syslog where applicable; Linux syslog-ng or rsyslog, or built-in forwarding; network device syslog/event export). Make sure the official destination is the remote collector, not mainly local storage on the audited operating system.
4. **Limit local copies** of audit logs on the audited systems to a short retention period (or turn them off where supported). Document why this is done and the retention period, so the main record set remains on the operating system–different component.
5. **Check and record proof of operating system difference**: capture and store the official destination hostname or IP address and the destination operating system details (from system records, infrastructure-as-code outputs, or collector operating system configuration records) as audit evidence.
6. **Prevent configuration drift** using configuration management and policy checks that confirm (a) the forwarding targets and (b) that the collector operating system is different from the source operating system. Repeat these checks during change management (system upgrades, collector changes, network changes).

###### WHO
- **Security Engineering / SOC Engineering**: define the official log storage standard, the operating system pairing rule, and what evidence is required.
- **Infrastructure/Platform Engineering**: deploy and secure the operating system–different log collector(s) and implement the forwarding settings.
- **Application/Systems Owners**: ensure their systems are set to forward audit events to the official destination.
- **Compliance/Assurance**: review the mapping and evidence package and confirm that re-checks are done during change management.

###### Acceptance criteria
- For every audited system/component in scope, there is an auditable mapping showing the audit destination component and that the **destination operating system differs** from the **source operating system**.
- Audit forwarding is set so audit records are stored on the remote official log destination (with local copies limited as documented).
- Evidence exists (exports/system inventory/infrastructure-as-code outputs) showing the official destination operating system and the configured forwarding destination for each source.
- In the next relevant change window, drift checks confirm that forwarding targets and operating system separation remain in place.

###### Actions Required for Compliance

- [ ] Choose and document an approved audit log storage location (a log collector or log server cluster). Also document a clear rule that maps each audited source system to a specific operating system (OS) diversity approach.
- [ ] Create and keep up to date a logging catalogue that links each audit source to its official destination (source → destination), including evidence from the destination operating system.
- [ ] Set up each audited system or component to send its audit records to the single approved (authoritative) destination, using the built-in forwarding, syslog, or event export method as appropriate.
- [ ] On audited systems, disable or reduce local audit log retention to a short, documented time window, so the authoritative record set is held on the operating-system-diverse component.
- [ ] Collect and store evidence that shows (1) where messages are being forwarded to and (2) the operating system of the destination system that is responsible for receiving them, to support audit readiness.
- [ ] Set up configuration management and “policy as code” checks to alert when forwarding settings drift from the approved configuration, and to confirm that operating system diversity is maintained during normal operations and during change management.


---

### AU-10 — Non-repudiation (Control)

This expectation is about making sure the organisation can prove, with clear and hard-to-dispute evidence, who did what—for example, creating information, sending and receiving messages, approving information, signing documents, and confirming receipt of specific information. Without this, people could later claim they never created, sent, received, approved, or signed something, which would leave the organisation unable to resolve disputes, meet legal or regulatory duties, or investigate wrongdoing.

To meet this, the organisation must use reliable methods so that every relevant action is recorded with: the person’s identity (or a clearly authorised process acting on their behalf), the exact time, and enough detail to identify what the action related to. The evidence must be stored in official system audit records (or equivalent controlled records), protected against unauthorised changes, and kept in a form that can be checked later.

The organisation must also document how this evidence is produced, assign named responsibilities, and include this requirement in its audit and accountability, system planning, and privacy planning where applicable.

##### Tamper-evident audit evidence for create/send/receive/approve/sign actions

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement **non-repudiation evidence** for the organisation-defined **actions** (creating information, sending and receiving messages, approving information, signing documents, and receiving specific information) so that the organisation can produce **unquestionable evidence** that a specific individual (or an authorised process acting on behalf of an individual) carried out those actions.

###### WHY (control requirement)
NIST SP 800-53 **AU-10** requires: “Provide unquestionable evidence that an individual (or process acting on behalf of an individual) has performed {{param, au-10_odp}}.” The guidance explains that non-repudiation helps prevent claims that someone did not create/send/receive/approve/sign, and that evidence can be produced using methods such as **digital signatures** and **digital message receipts**.

###### HOW (specific steps/approach)
1. **Define the non-repudiation action catalogue** in the application workflow layer, mapping each AU-10 action to a specific evidence type:
   - **Signing / approving**: cryptographic digital signature evidence linked to the exact document/version (hash/fingerprint) and the signer’s identity.
   - **Creating information**: evidence recorded as an unchangeable “creation receipt” showing the creator’s identity, the time, and the identifier of the created record.
   - **Sending / receiving messages**: evidence recorded as digital message receipts (send receipt plus receive receipt) showing the sender/receiver identity, message identifier, time, and a reference to the message content (for example, a hash).
   - **Receiving specific information**: evidence recorded as an acknowledgement receipt linked to the specific information item identifier and the recipient’s identity.
2. **Link evidence to identity and authority at the time of the action**:
   - Integrate the application with the enterprise identity provider (IdP) so each evidence record includes the authenticated user identity.
   - For “process acting on behalf of an individual”, enforce delegation/authorisation rules during operation (for example, approval matrices or time-limited delegation records) and include the delegator identity and delegation reference in the evidence.
3. **Make evidence tamper-evident and ready for audit**:
   - Store evidence in an append-only/unchangeable way (for example, write-once-read-many (WORM)-style storage or immutable object storage patterns) and ensure evidence records cannot be edited by users.
   - For signature/receipt records, use cryptographic integrity (hashing and signatures where supported by the platform) so later checks can detect any changes.
   - Keep evidence in controlled system audit records (or equivalent controlled records) so it can be reviewed later.
4. **Ensure evidence is created automatically by the system**:
   - Configure the application workflow so evidence creation is part of the transaction for each AU-10 action (no manual “upload evidence” steps).
   - Add correlation identifiers so auditors can trace: action → evidence item → referenced document/message/record.
5. **Provide a way to verify evidence**:
   - Implement an internal verification function (administrator/audit view) that, given an evidence item and reference ID, checks cryptographic integrity and shows the identity, time, and referenced item.

###### WHO (role responsible)
- **Application Owner / Engineering Lead**: implements workflow evidence creation and correlation.
- **Security Architect**: defines evidence types, the tamper-evidence approach, and verification requirements.
- **Identity and Access Management (IAM) Lead**: ensures identity assurance and delegation/authorisation integration.
- **Security Operations / Audit Team**: checks audit readiness, retention, and review procedures.

###### Acceptance criteria
- For each AU-10 action in **au-10_odp** (creating, sending, receiving, approving, signing, receiving specific information), the system produces an evidence item that includes: (a) the individual identity (or authorised delegate/process with delegation reference), (b) the time, and (c) a reference to the exact record/document/message/information item.
- Evidence items are stored in a tamper-evident/unchangeable manner and cannot be changed by standard users.
- Signature/approval evidence is cryptographically linked to the exact document/version; message receipts are linked to the message identifier and content reference.
- A verifier can reproduce an audit trail and validate integrity for a sample of actions without relying on files provided by users.

###### Actions Required for Compliance

- [ ] Match each **au-10_odp** action (**create**, **send**, **receive**, **approve**, **sign**, **acknowledge**) to the correct type of evidence record in the application workflow.
- [ ] Integrate the application with the organisation’s identity provider so evidence records include the authenticated person’s identity and the level of assurance used.
- [ ] Set up checks to confirm who is allowed to act on someone else’s behalf (“process acting on behalf”), and keep evidence that records the person who delegated the authority and the delegation reference.
- [ ] Set up cryptographic “binding” for signatures and approvals (document and version hash), and for receipts (message and record identifiers plus hashes that reference the related content).
- [ ] Store all evidence records in a secure repository that cannot be changed and only allows new entries to be added (append-only), so users cannot modify them.
- [ ] Add an evidence verification function that checks the evidence has not been altered and shows the identity, date and time, and the referenced item so it can be reviewed for audit purposes.


---

#### AU-10.1 — Association of Identities (Enhancement)

This requirement is about ensuring that when confidential or secret information is created or sent, it is clearly and securely linked to the exact person or system that produced it, and that the proof cannot be quietly changed later. Without this, someone could deny creating or sending a particular document or message, or the organisation could be unable to prove who was responsible if information is misused, leaked, or disputed.

To meet this expectation, the organisation must use strong, verifiable digital signatures for confidential and secret information, and must store the identity of the producer and the supporting evidence in records that cannot be altered once written. The organisation must also provide a way for authorised people to look up and verify who produced specific information, using the stored signature and audit evidence, with access limited to those authorised to carry out these checks.

##### Cryptographically bind producer identity to Confidential/Secret content

- Category: Software
- Priority: Critical

###### WHAT
For information marked **Confidential** or **Classified (Secret)**, the application must **use cryptography to link the person (or system) that created the information to the exact content** (or exact item reference). It must also **store proof of this link in records that cannot be altered**, so authorised staff can later **identify and confirm who produced the information**.

###### WHY (control requirement)
AU-10(1) enhancement guidance requires the organisation to define and apply the **strength of the link** between the information producer identity and the information. It also requires that this link is supported by audit evidence that allows the producer to be identified after the information is shared. The organisation’s required setting is: **“Strong binding using cryptographic signing and immutable audit records for Confidential and Classified (Secret) data.”**

###### HOW (specific steps/approach)
Set up a process that signs the content/item and stores unchangeable proof for Confidential/Secret items:

1. **Link the producer identity at creation/send time**: when a user (or a system acting for a user) creates or sends a Confidential/Secret item, the application must capture the **authenticated producer identity** from the organisation’s identity provider (enterprise identity provider), **not** a generic account. It must then link that identity to the item.

2. **Cryptographic signing**: create a **digital signature** for a standardised version of the item (for example, a content hash plus details that uniquely identify the item reference, such as document/message ID, classification, timestamp, and identifiers for the producer identity claim). Store the signature with the item.

3. **Immutable audit evidence**: create an audit record that, at minimum, includes the **producer identity**, **item reference**, **signature identifier**, **inputs needed to check the signature** (hash/signature verification inputs), and **verification context** (for example, signing key/certificate reference, algorithm, timestamp). Save these records to an **append-only / tamper-evident** storage system (for example, an immutable log service or write-once-read-many (WORM)-capable storage) with retention set according to organisational policy.

4. **Verification capability for authorised staff**: provide a controlled “verify producer” function. Given an item reference, it must perform repeatable checks by:
   - confirming the signature using the expected public key/certificate chain, and
   - retrieving the matching immutable audit record to show the linked producer identity and the supporting evidence.

5. **Access restriction**: limit access to the verification function and the underlying immutable audit evidence using least privilege (role-based access control (RBAC) and attribute-based access control (ABAC)). Ensure only authorised roles can run verification and view the producer-link evidence.

6. **Classification-aware behaviour**: ensure this signing and immutable audit evidence process is applied **only** to **Confidential** and **Classified (Secret)** items. Lower classifications follow existing workflows unless the organisation chooses to apply the same strength.

###### WHO
- **Application Owner / Engineering Lead**: implement signing, standardisation (canonicalisation), and verification functions.
- **Security Architect / Compliance**: define the required link strength, the evidence fields to store, and the verification rules.
- **Identity and Access Management (IAM) Administrator**: ensure authenticated producer identity details are correctly mapped and available to the application.
- **Security Operations Centre (SOC) / Security Operations**: use the immutable audit evidence during investigations and support audit readiness.

###### Acceptance criteria
- For every Confidential/Secret item created or sent through the application, the system produces a **checkable cryptographic signature** that links the **authenticated producer identity** to the **exact item reference**.
- The application stores **immutable audit evidence** that includes producer identity, item reference, and the inputs needed to verify the signature in a tamper-evident/append-only store.
- An authorised user can provide an item reference and get a **repeatable verification result** showing the linked producer identity and the evidence from the immutable audit record.
- Access to verification and audit evidence is limited to authorised roles and is logged.
- The process is applied using classification rules (Confidential/Secret only) and is consistently demonstrated across environments (production/test/disaster recovery) according to the organisation’s change management process.

###### Actions Required for Compliance

- [ ] Define the “Confidential” and “Classified (Secret)” item types, and confirm the exact item reference identifiers used for signing and verification.
- [ ] Create a standard (canonical) version of each item’s content, then calculate a hash (a unique fingerprint) for it, and combine this with binding information that identifies the producer and the item, including the producer identity claim identifier, item ID, classification, and timestamp.
- [ ] Use cryptographic signing with keys or certificates that are linked to the authenticated sender (or use a controlled signing service that signs on the sender’s behalf, with an auditable record showing that link).
- [ ] Create an audit record structure that cannot be changed after it is written (an “append-only” log). It should capture the producer’s identity, the item reference, the signature identifiers, and the information used to verify the signature.
- [ ] Create a restricted “verify producer” function that checks the signature and retrieves the matching unchangeable audit evidence using the item reference.
- [ ] Apply a classification-aware rule so that signing and tamper-proof audit evidence are produced only for items marked Confidential and Classified (Secret).
- [ ] Limit and record access to verification and unchangeable audit evidence, using role-based access control (RBAC) and attribute-based access control (ABAC) aligned to authorised roles.


---

#### AU-10.2 — Validate Binding of Information Producer Identity (Enhancement)

This requirement is about ensuring that every document or record you produce for later review clearly and permanently shows who originally created it, and that no one can quietly change that creator information in the meantime. Without this check, someone could alter records so they look as if they were produced by a different person or system, which would damage trust, accountability, and any investigation that depends on those records.

To meet this expectation, the organisation must, every time information is produced for review, verify that the original creator identity is correctly linked to the information using a method that can be repeated and independently checked. If the verification fails, the organisation must quarantine the affected information, notify the Security Operations Centre, and start incident response within 24 hours. It must also keep clear records of the validation results, the evidence used to reach those results, and the actions taken after any failure.

##### Cryptographically sign producer identity and verify at review time

- Category: Software
- Priority: Critical

###### WHAT
Create a cryptographic link between each information item’s **producer identity** and the **content** (for example, by having the producer sign a hash of the content in a consistent format). Then **check this link every time the item is prepared for review**.

If the check fails, the item must be **quarantined**, the **security operations centre (SOC)** notified, and **incident response started within 24 hours**.

###### WHY (control requirement)
The AU-10(2) enhancement guidance requires checking that the **information producer identity** is correctly linked to the information, to prevent changes between when the information is produced and when it is reviewed. This check must happen **at the defined frequency** (organisation parameter: **every time information is produced for review**). The organisation must also define what happens when the check fails (organisation parameter: **quarantine, notify SOC, start incident response within 24 hours**). Cryptographic checksums and signatures are explicitly acceptable ways to do this.

###### HOW (specific approach)
###### 1) Define a consistent “review payload” for hashing
- Create a canonicalisation process for the information that will be reviewed (for example, consistent rules for formatting, consistent ordering of fields, and consistent encoding).
- Calculate a **content hash** (for example, SHA-256) from the canonicalised version.

###### 2) Link producer identity using cryptographic signing at production
- When the information is produced, create a **producer identity assertion** by signing the following set:
  - `content_hash`, `producer_identity`, `signing_time`, and a `review_item_id` (or another equivalent unchangeable identifier).
- Store with the produced item:
  - `producer_identity`, `content_hash`, `signature`, `signing_time`, and (where applicable) a certificate chain reference.

###### 3) Validate the link every time the item is prepared for review
- Build an automated “review production” gate so that, for each item:
  - `content_hash` is recalculated from the item being prepared for review,
  - the signature is verified against the expected `producer_identity`,
  - a **pass/fail** result and verification evidence are recorded (hash, signature details, verification outcome, timestamp).

###### 4) Apply quarantine and SOC/incident response workflow on failure
- If validation fails:
  - move the item to a **quarantine store** with restricted access and mark it **do not review**,
  - notify the **SOC** using the organisation’s standard alerting/security orchestration, automation and response (SOAR) mechanism,
  - create or trigger an incident and ensure **incident response is started within 24 hours** (set an SLA timer in the workflow).

###### 5) Keep audit evidence for independent checking
- Record validation results and failure-handling actions in an **append-only/immutable audit trail** (for example, write-once, read-many (WORM)-capable storage or immutable logging), including:
  - item identifier, recalculated hash, expected producer identity, verification result, and quarantine/notification/incident timestamps.

###### WHO
- **Application owner / engineering lead**: implement signing at production and the review-time validation gate.
- **Security architect / compliance lead**: approve the canonicalisation rules, signing and verification design, and the quarantine/SOC workflow requirements.
- **SOC / incident response lead**: define and run the incident workflow and confirm the 24-hour initiation SLA.
- **Identity and public key infrastructure (PKI) team**: manage signing keys and certificates, and ensure the correct mapping between producer identity and keys.

###### Acceptance criteria
- For every item produced for review, the system performs cryptographic verification of the producer identity link (no review-ready item can bypass the gate).
- For each review item, the system records verification evidence (recalculated hash, producer identity, signature verification outcome, timestamps).
- If verification fails, the item is quarantined (cannot be used for review) and the SOC is notified; an incident is created and incident response is started within **24 hours**.
- Audit logs show end-to-end traceability from production signing to review-time validation, including any quarantine/SOC/incident response actions.

###### Actions Required for Compliance

- [ ] Define a standard “review payload” format and implement consistent, repeatable content checks (deterministic hashing) for review items
- [ ] Set up signing on the producer side so that the producer’s identity is linked to the content hash and the immutable item identifier.
- [ ] Set up a validation checkpoint at review time that recalculates the hash and checks the signature for every item.
- [ ] Set up quarantine controls so that validation failures are kept in a separate restricted store, and ensure they are enforced as “do not review”.
- [ ] Set up validation-failure handling so the security operations centre (SOC) is notified and an incident is started through the security orchestration, automation and response (SOAR) platform, with a 24-hour initiation service-level agreement (SLA).
- [ ] Set up tamper-proof, write-once (append-only) audit logs to record validation evidence and the dates and times when items are placed into quarantine, security operations centre (SOC) handling, and incident response.


---

#### AU-10.3 — Chain of Custody (Enhancement)

This requirement is about ensuring that every time someone reviews or releases information, the organisation can later prove exactly who did it and under which approved identity. This must be recorded as part of the item’s documented history. Without this, it becomes easier for the wrong person to be credited, for approvals to be impersonated or swapped, or for an unauthorised automated check to be used. That could result in unauthorised information being shared and in disputes about responsibility that are difficult to resolve.

To meet this expectation, the organisation must keep a clear record of who handled each reviewed or released item. This means linking the reviewer and releaser identities and their credentials to the specific information item and its label, and recording when the action happened and why the information was transferred. If the review is automated, the system must ensure that only approved automated review steps are used, and that the identity of the automated step is recorded before the information is released.

##### Identity-bound review/release chain of custody in release workflow

- Category: Software
- Priority: Critical

###### WHAT
Implement an identity-based review and release process that, for every information item released, creates a complete chain of custody. This must link the **reviewer** and **releaser** credentials to the specific information item and its **information label**, and must include the **date/time** and the **reason for the transfer**. If the review is automated, make sure the automated review is a separate, approved actor and record its identity.

###### WHY (control requirement)
This requirement (NIST AU-10(3) enhancement) means that **reviewer or releaser credentials must remain within the established chain of custody** for information that is reviewed or released. The guidance says the chain of custody must show **every person who handled the evidence**, including **date/time** and **reason for the transfer**. It also requires the system to link the **reviewer’s identity** to the information item and its **information label**. For automated review, only approved automated review functions must be used.

###### HOW (specific steps/approach)
1. **Create a release workflow with clear separation of duties**: require a separate **Review** step (done by a human) and a separate **Release** step (done by a human). Use role-based permissions so the same account cannot do both steps for the same item.
2. **Tie approvals to verified identity and the credential basis**: connect the workflow to the organisation’s identity provider (IdP) so the approval records capture the authenticated user identity and the credential assurance context (for example, the multi-factor authentication method and assurance level) at the time of review and at the time of release.
3. **Record chain-of-custody details on the information item at release time**: save structured fields in the application’s release record (and/or evidence record), including:
   - `information_id` (unchangeable reference)
   - `information_label/classification`
   - `reviewer_user_id` + `reviewer_credential_basis`
   - `releaser_user_id` + `releaser_credential_basis`
   - `review_timestamp` and `release_timestamp`
   - `transfer_purpose`
   - (if applicable) `destination/recipient` as part of the transfer context
4. **If automated review exists, treat it as a separate approved actor**: implement automated review as a distinct workflow step carried out by an approved service/function identity (not a human account). Record the automated review function identity in the same chain-of-custody record.
5. **Make chain-of-custody records tamper-evident and ready for audit**: store chain-of-custody records using an append-only or write-once-read-many (WORM)/immutable retention approach (or an immutable logging pipeline). Send the structured events to security information and event management (SIEM) for retention and integrity monitoring.
6. **Check completeness before allowing release**: block release unless the record includes reviewer identity + credential basis, reviewer completion, the correct information label, and the transfer purpose.

###### WHO
- **Application Owner / Product Owner**: ensures the workflow requirements are implemented and kept up to date.
- **Security Engineering / Identity and Access Management (IAM) Engineer**: integrates IdP authentication and captures the credential basis.
- **Platform/DevOps Engineer**: implements tamper-evident/immutable storage and forwards events to SIEM.
- **Compliance/Audit Lead**: checks that evidence is sufficient and that retention is correct.

###### Acceptance criteria
- For every released `information_id`, the system produces a chain-of-custody record containing **reviewer identity + credential basis**, **releaser identity + credential basis**, **information label/classification**, **review and release timestamps**, and **transfer purpose**.
- Release is blocked if any required chain-of-custody fields are missing, or if the review step is not completed.
- Separation of duties is enforced so the same human account cannot perform both review and release for the same item.
- If automated review is used, the chain-of-custody record identifies the **approved automated review function identity**, and only approved automated review functions can be selected/executed.
- Chain-of-custody records are stored in an append-only/tamper-evident way and can be retrieved for audit (including via SIEM) for the organisation’s required retention period.

###### Actions Required for Compliance

- [ ] Design the application release process with separate **Review** and **Release** steps, and ensure that different people are responsible for each step (separation of duties).
- [ ] Integrate the workflow with the organisation’s identity provider (IdP) so that, at the time of approval, the system records the authenticated identity of the reviewer or releaser and the level of confidence in their credentials.
- [ ] Add structured chain-of-custody details to the information release record, including: information ID, information label, the identity of the reviewer and releaser and the basis for their authority, the relevant dates and times, and the reason for the transfer.
- [ ] Block the release unless automated checks confirm that the chain-of-custody record is complete and the review step has been finished.
- [ ] Set up automated review as a separate, pre-approved workflow step (using a dedicated service or function identity) and record that identity in the chain-of-custody record.
- [ ] Keep chain-of-custody records in a write-once, tamper-evident system, and send unchangeable audit records to security information and event management (SIEM) for storage and verification.


---

#### AU-10.4 — Validate Binding of Information Reviewer Identity (Enhancement)

This requirement ensures that the person who reviewed the information is genuinely linked to that exact information at the moment it is moved from one security area to another or released. This prevents the data from being quietly changed after it has been approved. Without this check, someone could replace or tamper with the content between the time it is approved and the time it is transferred or released, which could lead to unauthorised disclosure or misuse of sensitive material.

To meet this requirement, before any transfer or release between the organisation’s on-premises Department of Defense (DoD) Confidential and Secret data areas, the organisation must verify—using a cryptographic proof (for example, a tamper-evident checksum)—that the reviewer identity matches the specific data being sent. If the verification fails, the organisation must block the transfer or release, notify the incident response team, and repeat the same reviewer-identity validation check within 24 hours.

The organisation must also keep records showing what was checked, what actions were taken when checks failed, and how the process is implemented and governed.

##### Cryptographically bind reviewer identity to payload at transfer

- Category: Software
- Priority: Critical

###### WHAT
Set up a transfer/release “gate” that, right before information moves between agreed security areas (for example, on-premises Department of Defense (DoD) Confidential to on-premises DoD Secret), uses cryptography to confirm that the **information reviewer’s identity** is linked to the **exact information content** being transferred/released.

###### WHY (control requirement)
The AU-10(4) enhancement guidance requires confirming that the information reviewer’s identity is correctly linked to the information at the **transfer or release point**. This is to stop unauthorised changes happening after review but before transfer/release. The check must be done at the transfer/release point using a **cryptographic check** (for example, a cryptographic hash that binds the identity to the content). If the check fails, the system must trigger agreed actions.

###### HOW (specific approach)
1. **Define security areas and coverage**: Configure the gate so it only applies this validation for the security areas defined by the organisation (for example, DoD Confidential and Secret) and only for the on-premises transfer/release processes that are in scope.
2. **Create an identity-to-content link at review time**: When a reviewer approves content, the application/gateway creates a signed “binding record” (token/manifest) that includes:
   - reviewer identity (a stable identifier from enterprise identity and access management)
   - transfer context (workflow ID, destination security area, time, and any relevant transfer settings)
   - cryptographic hash(es) of the exact content bytes (and any supporting information that affects meaning)
   - a signature over the above details using a key held by the gateway (or an equivalent trusted method)
3. **Check immediately before transfer/release**: At the moment the content is about to cross the security boundary, the gate must:
   - re-calculate the content hash(es) from the bytes actually being sent
   - verify the binding token signature
   - verify the token context matches the current transfer request (destination security area/workflow/time window)
   - verify the reviewer identity link is present and matches what is in the token
4. **If the check fails: stop, alert, and re-check**: If any cryptographic or context check fails, the gate must:
   - **block** the transfer/release
   - **notify** the incident response team (through the organisation’s incident response/security operations centre (SOC) ticketing/alerting integration)
   - start an automated **re-check within 24 hours** using the same validation logic
5. **Keep audit evidence**: Save audit records for every transfer attempt, including:
   - the content hash(es) used for the check
   - the reviewer identity from the binding token
   - the validation result (pass/fail) and the failure reason (for example, signature invalid, hash mismatch, context mismatch)
   - the time, transfer request ID, and what action was taken (blocked/released)
   Use append-only storage with write-once-read-many (WORM) capability, or an equivalent immutability control, to support auditability.

###### WHO
- **Application owner / system owner**: ensures the transfer/release process routes through the gate and that the binding token is created at review.
- **Security engineering / platform team**: builds the gate, the cryptographic binding, and the audit logging.
- **Incident response (SOC/IR) team**: receives and triages validation failure notifications and manages the results of the 24-hour re-check.

###### Acceptance criteria
- For all transfers/releases between the configured security areas, the system performs cryptographic validation of the reviewer-identity link to the exact content **immediately before** crossing the security boundary.
- If the content is changed after review (or the binding token context does not match), the transfer/release is **blocked** and an incident response notification is generated.
- A re-check is automatically triggered and completed **within 24 hours** of each validation failure.
- Audit evidence exists for each attempt showing the reviewer identity, content hash(es), validation outcome, and failure reason.
- Validation is enforced only for the organisation-defined security areas (for example, DoD Confidential and Secret) and does not apply outside the agreed scope.

###### Actions Required for Compliance

- [ ] Set up the transfer/release enforcement point so it checks and validates only the specified security domains (Confidential and Secret) and only the agreed, limited workflows.
- [ ] Generate a binding token when a review is approved that links the reviewer to the exact payload being approved. The token must include the reviewer’s identity, the transfer context, and cryptographic hash(es) of the exact payload.
- [ ] Implement a check right before crossing the domain boundary that re-calculates the payload hash(es), verifies the binding token signature, and confirms the context matches.
- [ ] Enforce fail-closed behaviour: block any transfer or release if any validation check fails, and raise an incident/alert to the incident response team.
- [ ] Set up an automated re-check that repeats the same validation after a failure within 24 hours.
- [ ] Store unchangeable audit records for every attempt, including the reviewer identity, the payload hash(es), the validation result, the reason for any failure, and the action taken.


---

### AU-11 — Audit Record Retention (Control)

This requirement is about keeping a clear record of what happened, for long enough to prove it later. If audit records are deleted too soon or cannot be found quickly, the organisation may struggle to investigate incidents after the event, respond properly to legal requests, or meet its own and external record-keeping duties.  

The organisation must set a retention period of 365 days from when the records are created, and keep the records available for administrative, legal, audit, and other operational needs until it is confirmed they are no longer required. It must also ensure the records can be provided for Freedom of Information Act requests, court orders, and actions by law enforcement for as long as they are needed to respond.  

To achieve this, the organisation should have written rules and step-by-step procedures for how records are kept, stored, and disposed of; define common categories of records linked to these types of requests; assign named responsibilities; involve the right privacy and information-handling roles in decisions; and make sure system administrators carry out the storage and access work.

##### Automate 365-day audit log retention with legal-hold extension

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated process to keep audit records for **365 days from when they are created**. Keep them **available for administrative, legal, audit, and other operational purposes**. Add a **legal-hold process** to extend how long records are kept when they are needed for **Freedom of Information Act (FOIA) requests, subpoenas, or law-enforcement actions**, until it is confirmed they are no longer required.

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication (SP) 800-53 **AU-11** requires the organisation to keep audit records for the stated period (**parameter: au-11_odp = 365 days**) to support investigations after events have occurred and to meet regulatory and organisational information-retention requirements. The guidance also requires records to remain available for **FOIA requests, subpoenas, and law-enforcement actions**, and to keep them until they are confirmed no longer needed for administrative, legal, audit, or operational purposes.

###### HOW (specific steps/approach)
1. **Define what to keep and how to classify it**: Create a list that maps audit-record categories (for example, authentication, authorisation, privileged or administrative actions, security-relevant configuration changes, and data access) to the log sources that produce them.
2. **Store records in a central, controlled archive**: Send audit records to a central archive with access controls (or a security information and event management (SIEM) / log-management archive tier) that supports tamper-resistant storage (for example, write-once or tamper-evident storage) and quick retrieval.
3. **Keep records for 365 days from the time of the event**: Set up automated retention rules so each audit-record category is kept for **365 days from creation**, with scheduled deletion that follows a defined timetable.
4. **Extend retention using legal hold when needed**: Create an auditable workflow so that when a FOIA request, subpoena, or law-enforcement request is received, the organisation applies a legal-hold flag to the relevant categories, sources, and time ranges, and **keeps the records until the case is closed**.
5. **Use standard ways to respond to requests**: For each request type (FOIA, subpoena, law enforcement), define standard search templates, retrieval steps, and approval checks (including how to handle redaction where required by other policies).
6. **Control when records can be deleted**: Make sure deletion is blocked for any records under legal hold, and that records are only deleted after an explicit decision that they are no longer needed for administrative, legal, audit, or operational purposes.

###### WHO (role responsible)
- **Security Operations / Security Operations Centre (SOC) Lead**: owns the audit-record category mapping, operational retrieval procedures, and evidence preparation.
- **Compliance / Legal Records Officer**: owns the legal-hold triggers and the decisions for when cases are closed.
- **Platform/Cloud or Infrastructure Engineering**: implements archive routing, retention automation, and access controls.
- **Information Governance / Privacy Officer (where applicable)**: checks handling requirements for records that may include personal data.

###### Acceptance criteria
- Audit records are kept for **365 days** from creation across all defined audit-record categories.
- Records under an active legal hold are **not deleted** and remain retrievable until the legal hold is released by an authorised case-closure decision.
- The archive supports **after-the-fact investigation** retrieval within agreed operational timeframes (for example, minutes to hours, as defined by the organisation).
- For FOIA, subpoena, and law-enforcement requests, the organisation can provide an auditable evidence trail showing: what was requested, which categories/time ranges were placed under hold, and what was retrieved.
- Retention and legal-hold actions are recorded and can be reviewed for audit purposes.

###### Actions Required for Compliance

- [ ] Create an audit-record category structure (taxonomy) and link each category to the systems that generate the relevant logs.
- [ ] Set up central routing of audit logs into a secure, access-controlled archive storage tier
- [ ] Set up automated retention rules to keep each category for 365 days from when the event is created.
- [ ] Set up a legal hold process that extends how long records are kept for Freedom of Information Act (FOIA), subpoena, and law-enforcement cases until an authorised decision is made to close the case.
- [ ] Define and publish standard instructions for handling Freedom of Information Act (FOIA) requests, subpoenas, and law-enforcement requests.
- [ ] Enable records of all retention, deletion, and legal-hold decisions so they can be audited, and confirm that archived information can be retrieved when needed.


---

#### AU-11.1 — Long-term Retrieval Capability (Enhancement)

This requirement is about making sure that records of system activity kept for many years can still be retrieved and understood when needed. Without this, important evidence for investigations, audits, or legal responsibilities could become unusable because the original system has changed, the file format is no longer supported, or the archive cannot be accessed reliably.

To meet this expectation, the organisation must convert audit records into widely readable standard formats such as JavaScript Object Notation (JSON) or Comma-Separated Values (CSV), and keep the right tools or readers to open those files long after the original system is no longer available. It must also keep clear documentation explaining what the converted records mean, including any changes made during conversion.

Finally, the organisation must periodically re-check that archived records can be retrieved from long-term storage and successfully opened and read using the retained approach, and must record the results of those checks.

##### Archive-ready audit log export with standard schema and re-test

- Category: Software
- Priority: Critical

###### WHAT
Set up an organisation-owned, version-controlled process to export audit records for long-term storage. The process should convert older audit records into common, widely readable formats (for example, JSON and/or CSV), store them in long-term archive storage, and include supporting metadata and checks to confirm the data has not been altered. Create a controlled “reader environment” (the tools and instructions needed) to interpret each archived schema version. Then run regular “retrieve and parse” tests using representative archived data sets, and record the results.

###### WHY (control requirement)
AU-11(1) requires that the organisation uses **au-11.01_odp (measures)** to ensure that **long-term audit records produced by the system can be retrieved**. The guidance also expects measures such as **converting records into newer formats**, **keeping the ability to read the records (including suitable equipment)**, and **keeping documentation** so staff can interpret the records—along with periodic checks to confirm retrieval still works.

###### HOW (specific steps/approach)
1. **Define a standard “archive-ready” audit schema** (fields, data types, timestamp format and time zone, event codes, actor identifiers, correlation IDs) and publish a **schema versioning policy**.
2. **Normalise and convert logs** from each audit log source in the application environment (for example, application events, API access events, admin actions, and authentication events where applicable) so exports are produced in **JSON and/or CSV** using the standard schema.
3. **Store exports in long-term archive storage** using an immutable or retention-locked approach. Create **archive metadata** (schema version, export job version, generation time, source system, record counts) and **integrity checks** (for example, per-file checksums and a manifest).
4. **Retain documentation and a controlled reader environment**: keep a versioned “how to read” guide for each schema version, and package the parsing and validation tools (for example, a container image or an offline virtual machine template) that can read the archived formats.
5. **Periodically re-check retrieval**: on a defined schedule, retrieve a representative sample or date range from the archive, use the retained reader environment to parse and validate key fields, and record whether each test passed or failed, including evidence.
6. **Maintain backward compatibility**: when the schema changes, ensure the export process either continues to produce the earlier schema versions for historical comparison, or provides a documented conversion mapping so archived records remain interpretable.

###### WHO (role responsible)
- **Application Security/Engineering Lead**: owns schema definition, export pipeline implementation, and reader tooling integration.
- **Security Operations / SIEM and Logging Owner**: defines audit event coverage and coordinates evidence for retrieval re-checks.
- **Platform/Cloud Engineering**: implements archive storage, immutability and retention controls, and packaging of the reader environment.
- **Compliance/Assurance**: reviews evidence of periodic re-checks and confirms documentation completeness.

###### Acceptance criteria
- Archived audit exports are produced in **standard JSON/CSV** that match a **documented, version-controlled schema**.
- Each archive set includes **metadata** (schema version, export job version, generation time, source) and **integrity evidence** (manifest and checksums).
- A **versioned reader environment** and **“how to read” documentation** exist and can read historical schema versions.
- Scheduled retrieval tests successfully **retrieve, parse, and validate** representative archived records, with recorded evidence of results.
- Demonstrated ability to interpret key fields (timestamps, actor, event type, outcome) from archived records using the retained documentation and tools.

###### Actions Required for Compliance

- [ ] Define and publish a versioned organisation audit export format (the data fields, the date and time format including time zone, and the event codes), and publish a matching “how to read” guide for each format version.
- [ ] Set up log normalisation and conversion for each audit log source so that exports are produced in standard JavaScript Object Notation (JSON) and Comma-Separated Values (CSV) formats that match the required schema.
- [ ] Set up long-term archive storage with rules that prevent changes and control how long data is kept, and create a manifest file with metadata such as the schema version, export job version, number of records, and checksums.
- [ ] Set up and maintain a controlled “reader” environment (a container or offline virtual machine) and validation tools that can read and check every saved version of the schema.
- [ ] Plan and run regular tests that retrieve and analyse archived sample data. Record whether each test passed or failed, along with any corrective actions taken.
- [ ] Set a rule for backward compatibility when changing the schema: either keep producing the previous schema versions, or provide documented conversion mappings to translate between versions.


---

### AU-12 — Audit Record Generation (Control)

This requirement is about making sure the organisation can automatically record important events that happen within its systems, in a way that can later be reviewed and explained. Without this, suspicious activity, mistakes, or unauthorised changes could go unnoticed, leaving the organisation unable to investigate incidents, confirm what happened, or learn from problems.

The organisation must configure its application servers, network security devices, operating systems, and database servers so they can produce audit records for the types of events the system can record. The organisation must also keep a documented list of which event types can be audited.

The system security officer and the information system owner must be able to decide which event types each system component records. The system must then generate audit records for the selected event types, including the required details.

This approach must be documented and supported by repeatable configuration settings. The organisation must also be able to produce the resulting audit records as evidence.

##### Per-component audit event selection with authorised control

- Category: Software
- Priority: Critical

###### WHAT
Set up audit record generation so that every system component (for example, application servers, operating systems, database servers, and network security devices) produces audit records for the event types it can generate. Also ensure the specific subset of event types to record is chosen for each component by authorised roles.

###### WHY (control requirement)
AU-12 requires the organisation to ensure audit records are generated for the event types selected for audit logging, with audit record generation capability across system components. The guidance says the event types in **AU-2d** are the event types that must be logged, and they are a **subset of all event types** the system can generate. Therefore, the system must allow event-type selection for each component, and it must actually generate audit records for the selected event types.

###### HOW (specific steps/approach)
1. **Create an auditable event list for each component type** (operating system, application server, database server, network security device) showing all event types the component can generate, and mark which ones are in the organisation’s **AU-2d subset**.
2. **Set up a version-controlled configuration baseline** that links each component instance to:
   - the full set of event types it can generate, and
   - the required subset of event types to log (the AU-2d subset).
3. **Allow only authorised per-component selection** by using role-restricted change processes, so only the **system security officer** and the **information system owner** can approve changes to the per-component event-type selection.
4. **Apply repeatable configuration** to enable audit logging on each component and configure it to produce audit records for the selected event types (for example, operating system audit settings, database audit settings, application framework audit hooks, and network device syslog/event category settings).
5. **Check that audit records are being generated correctly** by running automated checks that:
   - confirm each component is producing audit records for every selected event type, and
   - confirm the produced records include the required audit record content fields defined by the organisation’s audit record content requirement.
6. **Keep audit-ready evidence** by saving configuration snapshots (baseline version, approval records, and applied settings) and periodic test results showing that audit records are being generated for the selected event types.

###### WHO
- **System Security Officer (SSO):** approves changes to per-component event-type selection.
- **Information System Owner (ISO):** approves changes to per-component event-type selection.
- **Platform/Infrastructure Engineering (implementation owner):** implements and reconciles the configuration baselines for application servers, operating systems, databases, and network security devices.
- **Security Operations / security information and event management (SIEM) team:** checks that audit records are received and include the required fields.

###### Acceptance criteria
- For each defined system component instance, the organisation can show (with evidence) that audit logging is enabled and configured to generate audit records for the **AU-2d event types** selected for that component.
- Only the SSO and ISO can approve changes to the per-component event-type selection (enforced through workflow and controls).
- Automated verification shows that audit records are generated for each selected event type and include the required audit record content fields.
- Evidence includes versioned configuration baselines, approval records, and verification outputs for production and (where applicable) test or staging environments.

###### Actions Required for Compliance

- [ ] Create a version-controlled, auditable event catalogue for each component type, and map each event type to the AU-2d subset.
- [ ] Set a standard configuration for each component that chooses the AU-2d event types for every instance of that component.
- [ ] Set up an approval process that limits changes to per-component event-type selections to the system security officer and the information system owner.
- [ ] Set up each application server, operating system, database server, and network security device to record audit logs for the selected event types.
- [ ] Run automated checks to confirm that audit records are created for every selected event type and that each record includes the required content fields.
- [ ] Store audit-ready evidence, including baseline versions, approval records for changes, saved configuration snapshots, and verification results.


---

#### AU-12.1 — System-wide and Time-correlated Audit Trail (Enhancement)

This requirement is about ensuring that when important security events happen, the organisation can put together one complete, accurate timeline of what occurred across all its systems. Without this, records from different systems may be missing, not aligned, or difficult to compare, which makes it harder to investigate incidents, demonstrate what happened, or identify suspicious activity in the correct order.

To meet this expectation, the organisation must collect security-relevant event records from every relevant source, including operating systems, applications, network devices, identity services, and cloud or on-premises gateways, and combine them into a single, organisation-wide audit trail. Each record must include a reliable date and time, using the same time basis across all sources, so that related events can be ordered correctly and their timestamps match within 5 seconds.

The organisation must also be able to provide evidence that all required sources are included and that the timing is accurate.

##### Time-correlated system-wide audit trail via normalised UTC ingest

- Category: Software
- Priority: Critical

###### WHAT
Set up a system-wide (logical) audit trail by collecting security-relevant audit records from all in-scope system components and sending them into one central logging and security information and event management (SIEM) platform. Make sure every record includes a dependable timestamp, and that timestamps from different sources can be matched to each other across the organisation within the agreed tolerance.

###### WHY (control requirement)
AU-12(1) enhancement requires the organisation to “compile audit records from {{ insert: param, au-12.01_odp.01 }} into a system-wide (logical or physical) audit trail that is time-correlated to within {{ insert: param, au-12.01_odp.02 }}.” Time correlation means timestamps in individual records can be reliably linked to other records, so the events can be ordered correctly within the organisation’s allowed tolerance.

###### HOW (specific steps/approach)
1. **Define and enforce the correct time source**: Choose an approved authoritative time source (for example, redundant network time protocol (NTP) servers; consider precision time protocol (PTP) where needed). Require all in-scope systems that produce events (operating systems (OS), applications, network devices, identity services, and cloud/on-premises gateways) to synchronise to it. When records are received, standardise the timestamp format to one agreed basis (typically coordinated universal time (UTC)) while keeping the original event time field.
2. **Collect from all required system components**: Create and maintain a list that maps each asset to its log source, covering “all system components that generate security-relevant events (OS, applications, network devices, identity services, and cloud/on-premises gateways)”, so the central process receives data from every required source.
3. **Standardise timestamps without changing the event time**: Configure the central ingestion process to use each event’s own timestamp (not the time it was received), convert it to UTC, and store both **event_time_utc** and **event_time_original** (including timezone/offset details where available). Reject or flag events that have missing or invalid timestamps.
4. **Use one consistent audit trail structure**: Configure the SIEM/log platform to store all collected security events in a single, unified structure (index/data model) with consistent fields for event time, source identity (host/device/service), event type, and user/session identifiers.
5. **Demonstrate time matching within tolerance (≤ 5 seconds)**: Use a repeatable test that performs coordinated security-relevant actions across multiple components (for example, identity sign-in → application access → operating system/network/gateway audit events). Check the time difference between the earliest and latest **event_time_utc** for the same test scenario, and show it is consistently within **5 seconds**.
6. **Run ongoing checks and keep proof**: Add automated checks that continuously monitor timestamp quality (for example, signs of clock drift, missing timestamp rates, and out-of-order detection). Keep the results of these checks as audit evidence.

###### WHO
- **Security Architect / Compliance Lead**: responsible for the AU-12(1) design, defines what evidence is needed, and approves the authoritative time source and how tolerance is handled.
- **Platform/Infrastructure Engineering**: sets up the authoritative time service and ensures all producing systems synchronise their clocks.
- **SIEM/Logging Engineering**: builds the ingestion normalisation, the unified audit trail structure, and the timestamp quality controls.
- **Security Operations Centre (SOC) / Detection Engineering**: runs and maintains the repeatable time-correlation test scenarios and records the results.

###### Acceptance criteria
- Audit records from all in-scope system components defined in **au-12.01_odp.01** are collected into a single system-wide audit trail (logical index/data model) in the central platform.
- For every collected event, a dependable timestamp is present and stored as **event_time_utc**, taken from the event’s native timestamp (not the ingestion/receipt time), with the original timestamp preserved.
- A repeatable validation shows that event ordering across representative component types is achievable with time correlation within **au-12.01_odp.02 (within 5 seconds)**.
- Timestamp quality monitoring is in place (for example, missing/invalid timestamp detection), and evidence that the validation tests were run is retained for audit.

###### Actions Required for Compliance

- [ ] Choose and deploy an approved, reliable time service with built-in redundancy (Network Time Protocol (NTP) / Precision Time Protocol (PTP)), and ensure that all in-scope devices that generate data keep their clocks synchronised.
- [ ] Create a clear list that links each asset (such as operating systems, applications, network devices, identity services, and cloud or on-premises gateways) to the log sources that record its activity.
- [ ] Set up the central data intake pipeline to read the original event date and time, convert it to Coordinated Universal Time (UTC), and keep the original timestamp and time zone details.
- [ ] Set up data ingestion checks to flag or reject any events that have missing or incorrect timestamps, and to stop events being re-timed based on when they were received.
- [ ] Standardise the security information and event management (SIEM) and log data structure so all events use the same event time in Coordinated Universal Time (UTC) and the same source identity fields.
- [ ] Run a repeatable test scenario involving multiple components, and document that the timing sequence can be matched or ordered within 5 seconds.
- [ ] Set up ongoing checks to confirm that timestamps are accurate, and keep the results of those checks as evidence for audits.


---

#### AU-12.2 — Standardized Formats (Enhancement)

This requirement is about making sure your records of important activity are written in the same way across the whole organisation. If different systems and devices record events in different formats, it becomes difficult to share information, compare what happened, and analyse events together. This can slow down investigations and make it harder to hold people accountable if something goes wrong.

To meet this expectation, the organisation must define one standard format for audit records, including how the information is structured and named. Every system must use this standard format when creating records for every event that needs to be audited.

The organisation must also ensure the organisation-wide record covers both software activity and physical or logging activity. If any records are produced in a non-standard way, they must be converted into the standard format when compiling the overall record.

The organisation should document how records are created, where they are produced, and who is responsible. It must then produce and keep the organisation-wide set of standardised records.

##### Standard audit record schema with ingestion-time normalisation

- Category: Software
- Priority: Critical

###### WHAT
Set up a single, organisation-approved, version-controlled audit record format for the system-wide audit trail. Make sure every audit record stored in both the logical and physical system-wide audit trails is created in, or converted into, that same standard format.

###### WHY (control requirement)
AU-12(2) (Enhancement) requires the organisation to produce a system-wide (logical or physical) audit trail made up of audit records in a **standardised format**. The guidance says that if the original sources do not match the standard, systems may convert records into standard formats when building the system-wide audit trail. Normalising records at the point the system-wide trail is built is therefore an acceptable approach.

###### HOW (specific steps/approach)
1. **Define the standard audit record format** as a documented, version-controlled structure (for example, JSON or key-value). It must include: event date and time (with time zone), event category/type, who did the action (actor identity), the source host/device, source IP address, the target resource, the action taken, the outcome/result, reason codes, correlation identifiers (for example, session or transaction IDs), and the schema version. Specify which fields are required versus optional, the allowed values, the data types, and the encoding rules.
2. **Normalise at the point of ingestion** in the central logging and security information and event management (SIEM) pipeline, so every auditable event is mapped to the standard format before it is written to the system-wide audit trail store.
   - Create mapping rules for each source type (for example, Windows Security logs, Linux syslog/auth, network device logs, cloud control-plane audit logs, and application audit events).
   - Add validation checks: require mandatory fields and correct data types. If mapping fails, quarantine the event and create a mapping-failure audit record (also in the standard format) for traceability.
3. **Use a consistent event “taxonomy”** by aligning event categories, actions, and outcomes across all sources to the standard lists of allowed values. Enrich events with consistent identifiers (for example, normalised user or service principal, host naming, and resource naming).
4. **Include both logical and physical audit trails** by routing non-IT and physical logging sources (for example, access control systems, badge readers, CCTV analytics event logs, and environmental or security sensors that generate auditable events) through an integration or collector that outputs the standard audit record format into the same system-wide audit trail.
5. **Convert non-standard records when compiling the system-wide trail** by making the normalisation layer the single, authoritative step for system-wide storage. Legacy or vendor logs must be transformed into the standard schema, with an explicit `original_format`/`source_format` indicator and the schema version.
6. **Document procedures and ownership**: publish runbooks showing how audit records are generated by each component, where they are produced (collector or mechanism plus configuration), how mapping and normalisation are performed, and how schema version changes are rolled out.

###### WHO (role responsible)
- **Security Engineering / Security Operations Centre (SOC) Engineering**: owns the standard audit record schema, ingestion normalisation rules, and validation/quarantine behaviour.
- **Application Owner / Platform Engineering**: ensures the application produces auditable events that can be mapped to the standard identifiers and integrates with the logging pipeline.
- **Operational Technology (OT) / Physical Security Integration Lead (where applicable)**: ensures physical and physical-adjacent logging sources are integrated into the standardised trail.
- **Information Security Governance**: approves schema changes and keeps evidence of compliance.

###### Acceptance criteria
- The organisation-wide logical audit trail store contains audit records that match the approved standard schema (including required fields, correct data types, and consistent allowed values) for all integrated auditable sources.
- Non-standard source events are either (a) normalised into the standard schema before storage or (b) quarantined with mapping-failure events recorded in the standard format.
- Physical and physical logging sources that contribute to the system-wide audit trail are integrated so their auditable events appear in the same standardised format.
- Evidence exists: schema documentation (version-controlled), the mapping rule set, ingestion pipeline configuration, and runbooks showing how records are produced and normalised.

###### Actions Required for Compliance

- [ ] Define and publish a standard audit record format that is version-controlled, including which fields are required or optional, the kind of data each field holds, how the data is encoded, and the allowed values for each field.
- [ ] Set up ingestion-time normalisation rules that convert each auditable source’s original events into the standard format before they are stored across the whole system.
- [ ] Add checks to ensure required information is present and in the correct format, and move any mapping problems into a quarantine process while recording them using standard traceability events in the agreed format.
- [ ] Add physical and operational technology (OT) security event sources into the same event “normalisation” process, so their recorded events are stored in the standard, auditable format.
- [ ] Align the event classification (category, type, action, result) and standardise identifiers for users, service principals, hosts, and resources so events can be matched across different systems.
- [ ] Document runbooks covering how audit records are created, how collectors and mechanisms are set up, how normalisation works, and the steps for changing the schema version


---

#### AU-12.3 — Changes by Authorized Individuals (Enhancement)

This requirement ensures that, during a serious incident, only the System Owner and the Security Operations Lead can quickly change what is recorded on key on-site systems. This helps investigators see the correct evidence. Without this control, important warning signs could be missed because logging is too limited, or the wrong information could be recorded—wasting time and potentially allowing an attacker to hide their actions.

The organisation must put in place and use an emergency ability to change logging on federal on-premises servers, network security devices, and security monitoring agents within 15 minutes of an approved incident or threat alert. This emergency change must be limited to logging changes related to authentication, use of privileges, administrative actions, and security-relevant policy changes. Any change must stay within these permitted categories, can be used to broaden or narrow logging as needed, and must be fully traceable to the authorised person who made the change, including when it was done and exactly what was changed.

##### Emergency logging change workflow for authorised roles within 15 mins

- Category: Software
- Priority: Critical

###### WHAT
Create a capability that lets **only authorised people or job roles** change **what logging is collected** for **specified system components**. This must use **pre-set event types** and must be done **within 15 minutes** of an **approved incident or threat alert**. Every change must be fully traceable, showing **who made the change, what they changed, and when**.

###### WHY (control requirement)
AU-12(3) enhancement requires: “Provide and implement the capability for **{{ individuals or roles }}** to change the logging to be performed on **{{ system components }}** based on **{{ selectable event criteria }}** within **{{ time thresholds }}.”** Guidance also expects logging changes to help extend or limit logging during threat situations and to be traceable.

###### HOW (specific steps/approach)
###### 1) Define the emergency logging-change policy (machine-enforceable)
- Create a single, version-controlled “policy-as-code” definition that lists:
  - **Authorised roles/individuals**: *System Owner* and *Security Operations Lead*.
  - **Target system components**: *federal on-prem servers, network security devices, and security monitoring agents*.
  - **Selectable event criteria** (only these categories may be changed): *authentication, privilege use, administrative actions, security-relevant policy changes*.
  - **Time threshold**: changes must be carried out **within 15 minutes** of an approved incident or threat alert.
- Restrict allowed actions to specific options (for example, enable, extend, or limit) and block any other event types or target components from being selected.

###### 2) Start only after an approved incident/threat alert
- Link the incident/threat process to the automation controller so the emergency logging-change workflow can only begin when the ticket or alert is in an **approved** state.
- Record the **approval time** and the incident/alert identifier to start the 15-minute timer.

###### 3) Enforce role-based execution using identity and a privileged workflow
- Require the change to be carried out through an identity-first privileged access route (for example, privileged access management with just-in-time access) that only allows the workflow to be triggered by:
  - **System Owner**
  - **Security Operations Lead**
- Require phishing-resistant multi-factor authentication (MFA) for these roles and ensure the automation uses the authorised identity.

###### 4) Automate the logging changes using only approved settings
- Use orchestration and configuration management to apply logging changes to the defined component types, using only the event types approved by the policy.
- Ensure the automation records:
  - who started the change (authorised identity),
  - when it was approved,
  - when execution finished,
  - which event types were changed,
  - which targets were affected.
- Support temporary versus permanent changes by requiring an explicit end time or expiry duration for temporary changes (while still restricting changes to the allowed event types).

###### 5) Produce audit-ready evidence and confirm timing
- Write an unalterable change record to the organisation’s audit log and security information and event management (SIEM) system (or an append-only store), including the calculated time between **approval** and **completion**.
- Add a check that stops the workflow if it cannot be completed within **15 minutes** (or immediately escalates it and triggers compensating actions).

###### WHO
- **Security Operations Lead**: approves the incident/threat alert and starts the emergency workflow when needed.
- **System Owner**: authorised to trigger and carry out the emergency logging change for the defined scope.
- **Security Engineering / Automation Engineer**: builds the policy-as-code, orchestration, and audit evidence.
- **SIEM/Logging Platform Owner**: ensures immutable audit records are ingested and retained.

###### Acceptance criteria
1. Only *System Owner* and *Security Operations Lead* can start the emergency logging-change workflow.
2. The workflow can only apply changes to the defined component groups (federal on-prem servers, network security devices, security monitoring agents).
3. The workflow can only change logging for the defined selectable event criteria (authentication, privilege use, administrative actions, security-relevant policy changes).
4. Execution is allowed only when the incident/threat alert is **approved**; unapproved alerts cannot trigger changes.
5. For test incidents, the system records approval time and completion time and shows the logging changes complete **within 15 minutes**.
6. Audit evidence is produced for every change, including: authorised identity, timestamps, incident/alert ID, affected targets, and event criteria changed.

###### Actions Required for Compliance

- [ ] Define and publish an emergency log-change policy as code, including which roles are allowed to make changes, which systems are affected, what events trigger logging changes, and what actions are permitted (enable, extend, or limit).
- [ ] Set up the incident and threat workflow so that only an approved alert can trigger an execution request, and record the date and time the approval was given.
- [ ] Set up privileged access and just-in-time (JIT) access so that only the System Owner and the Security Operations Lead can start the emergency logging change process, using phishing-resistant multi-factor authentication (MFA).
- [ ] Set up automation playbooks that make only the logging changes that have been approved by policy, and apply them to the specified on-premises servers, network security devices, and security monitoring agents.
- [ ] Set up permanent, unchangeable audit records for every change, including the authorised identity, approval time, completion time, incident or alert reference, the targets, and the event criteria that were changed.
- [ ] Add a timing check to ensure the task is completed within 15 minutes of approval, and escalate if it cannot be completed within that time.


---

#### AU-12.4 — Query Parameter Audits of Personally Identifiable Information (Enhancement)

This requirement is about keeping a clear record of the exact search or retrieval criteria used when someone looks up personal information in your systems. Without this, it is difficult to spot misuse, investigate concerns, or show that only the right people accessed personal data for legitimate reasons—because you may know that a search took place, but not what it searched for.

The organisation must set up and run an auditing feature that applies to any user or automated job that searches datasets known to contain personal identifiers. The system must capture the specific search details used and store them in the organisation’s audit records for later review. The organisation must also document how and when these audit records are created, what they should include, and how the system is designed and configured to do this, including assigning named responsibilities to staff for creating and overseeing these records.

Finally, the organisation must be able to demonstrate that audit records are created automatically, are complete, and are kept for the required period.

##### PII query-parameter audit logging for qualifying query events

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated auditing capability that records the **exact query details (explicit query parameters)** used in **user (or automated) query events** when those queries access **datasets that contain personal data (personally identifiable information (PII))**.

###### WHY (control requirement)
AU-12(4) enhancement requires the organisation to **provide and implement** the ability to **audit query details** for **data sets containing PII**, so authorised staff can track and understand how PII is accessed, used, and shared.

###### HOW (specific approach)
1. **Define when auditing applies**: create a documented mapping from your data catalogue/data classification to a simple “PII dataset scope” (yes/no). Define “qualifying query events” as the application parts that run parameter-based data retrieval (for example, user interface search, application programming interface (API) queries, or scheduled extract jobs) against the scoped datasets.
2. **Add auditing to the query process**: add a middleware/component in the service that builds and runs queries (for example, a structured query language (SQL) builder / search query language builder). For qualifying events, it must create an audit record that includes:
   - event date and time
   - who did it (user or service account) and a session/request reference ID for linking related activity
   - which dataset was accessed (for example, table/index/report name or a logical dataset ID)
   - query purpose/type (search, filter, export, background retrieval)
   - the **exact query details** in a structured format (for example, a list of {field, operator, value} or an equivalent representation)
3. **Protect query details that may include PII**: store query criteria in a way that supports accountability while following the organisation’s privacy rules. Implement one of the following (approved by the organisation):
   - encrypt parameter values when stored, using keys limited to the audit-review role; and/or
   - replace values with tokens (only reversible by approved key holders); and/or
   - use hashes when only “match” or “contains” checking is needed, while still recording the field/operator.
4. **Send audit records to the audit system**: send audit events to the organisation’s central audit pipeline/security information and event management (SIEM) ingestion endpoint set up for tamper-resistant storage and restricted access. Make sure the events can be retrieved later for review.
5. **Make it complete and automatic**: build audit creation into the normal query execution process (no manual on/off switches). Add automated tests that run representative queries against PII-scoped datasets and confirm that audit events are produced with the expected structure.
6. **Run it in operations and document it**: keep runbooks that explain when auditing triggers, what the audit record should contain, how query details are protected, and how to retrieve audit evidence for investigations.

###### WHO (roles responsible)
- **Application security engineer / backend engineer**: implement the query auditing and the audit record format.
- **Data governance / privacy lead**: approve the PII-safe way of handling query details (encrypt/tokenise/hash) and the mapping that defines which datasets are in scope.
- **Security operations (SOC) / SIEM administrator**: set up audit pipeline ingestion, retention, and access controls.
- **System owner**: ensure the applicability mapping and runbooks are kept up to date.

###### Acceptance criteria
- For every qualifying query event that targets a PII-scoped dataset, an audit record is automatically created and stored.
- Audit records include the exact query details (field/operator/value or an equivalent structured representation) and the dataset identifier.
- Audit records are protected using the approved PII-safe handling method and can be retrieved by authorised reviewers.
- Automated tests show audit coverage for representative query types and confirm the audit record content matches the expected structure.
- Runbooks and documentation exist describing the trigger conditions, what the audit records contain, and how to retrieve them.

###### Actions Required for Compliance

- [ ] Create and keep up to date a mapping of personally identifiable information (PII) coverage in the data catalogue, and link it to the dataset identifiers used by the query layer.
- [ ] Define which types of queries qualify, and the exact application code paths that run parameterised data retrieval against datasets that are limited to personally identifiable information (PII)
- [ ] Add audit logging for query parameters as part of the query execution process, recording the user identity, the dataset identifier, and the structured query parameters.
- [ ] Set up protection for personal data in query parameter values (by encrypting, tokenising, or hashing), following the approved privacy policy and the approved rules for access to encryption keys.
- [ ] Send audit events to the organisation’s central audit log system (security information and event management (SIEM)) using storage that cannot be changed without leaving a clear trace, and restrict access to authorised staff only.
- [ ] Add automated integration tests that run sample queries on datasets that include only personal data (PII) within the approved scope, and check that the audit report information is complete and follows the expected format.
- [ ] Publish runbooks that explain: the trigger conditions, the audit data format (audit schema), how parameters are protected, and how authorised staff retrieve audit evidence.


---

### AU-13 — Monitoring for Information Disclosure (Control)

This requirement is about keeping a close daily watch on public places where information could be shared by mistake or on purpose—for example, public code websites, paste websites, and social networking pages. The goal is to spot any unauthorised release of the organisation’s information.

Without this, sensitive information—such as personal information the organisation holds or valuable internal work—could be made public. This could harm customers, staff, and the business, and could also lead to legal and reputational damage.

To meet this expectation, the organisation must check these public sources every day for signs of unauthorised disclosure. If anything suspicious is found, it must promptly:
- alert the incident response lead and the owner of the affected system
- escalate the matter to the organisation’s specialist response team
- open an incident record
- preserve evidence of what was seen and where it appeared
- assess what impact the disclosure could have had
- start requests to have the content removed from the relevant platform

##### Daily OSINT monitoring with SOC case workflow and takedown playbook

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated daily monitoring service that checks agreed public information sources and websites (public code repositories, paste sites, and social networking sites) for signs that organisational information may have been shared without authorisation. If a possible disclosure is found, the system must alert the incident response lead and the information system owner, escalate the matter to the security operations centre (SOC), open an incident, preserve the evidence, assess the impact, and start takedown requests.

###### WHY (control requirement)
AU-13 requires monitoring for information disclosure on open-source/public websites and ensuring that any suspected unauthorised disclosure triggers quick notification and response. The organisation’s agreed settings define: (1) which open-source sites to monitor, (2) the monitoring frequency (daily), (3) who must be notified, and (4) the follow-up actions (SOC escalation, incident creation, evidence preservation, impact assessment, and takedown requests).

###### HOW (specific steps/approach)
1. **Define monitoring scope and indicators (as code):** Create a version-controlled set of rules that lists the exact open-source information sites to monitor (for example, GitHub/public code repositories, paste sites, and social networking sites) and the detection indicators for organisational information (for example, organisation identifiers, project names, customer names, known patterns for proprietary items, and personal data (PII)/secret indicators).
2. **Run scheduled daily monitoring jobs:** Set up daily scheduled searches across the defined site categories using approved open-source intelligence (OSINT) search tools and/or platform application programming interfaces (APIs). Make sure each category is checked every day.
3. **Combine results into one evidence record:** For each match, record and store: source type (code/paste/social), URL, author/account (if available), time found/first seen, the matched indicator, and a confidence score.
4. **Start a SOC/security information and event management (SIEM)/security orchestration, automation and response (SOAR) workflow for suspected disclosures:** If a finding is above an agreed confidence threshold, automatically create a SOC case/ticket and link it to the incident workflow.
5. **Preserve evidence for audit purposes:** Automatically capture the permitted evidence items (for example, page snapshots/archived copies where allowed, plus metadata exports) and store them in an evidence store that cannot be changed (immutable) and is kept for the period required for incident handling.
6. **Notify the required roles immediately:** Automatically notify the **incident response lead** and the **information system owner** with clear, actionable details (what was found, where, when, and the confidence/indicator basis).
7. **Carry out a structured impact assessment and start takedown:** Within the incident workflow, require a triage/impact assessment (for example, whether PII is present, whether proprietary information/credentials are involved, and which systems are affected). Then follow a documented takedown playbook that submits takedown requests to the relevant platform and tracks submission IDs and outcomes.

###### WHO
- **SOC/SIEM/SOAR engineer:** builds the daily monitoring jobs, integrations, and case creation.
- **Incident Response Lead:** makes the triage/impact assessment decisions and ensures escalation and communications happen.
- **Information System Owner:** confirms what is affected and supports takedown/containment actions.
- **Compliance/Assurance:** checks audit evidence and confirms monitoring coverage.

###### Acceptance criteria
- Daily monitoring runs successfully for each defined open-source site category and produces audit-ready records.
- For any suspected disclosure that meets the configured threshold, the system automatically:
  - notifies the incident response lead and the information system owner,
  - escalates to the SOC and opens an incident,
  - preserves evidence (URL + timestamp + captured evidence items/metadata),
  - records the outcome of the impact assessment, and
  - starts takedown requests with tracked status.
- Evidence records are immutable and can be retrieved for audit.
- Monitoring rules/indicators are version-controlled and include a change history.

###### Actions Required for Compliance

- [ ] Define and version-control the open-source website categories that are monitored, and the detection indicators used to identify activity.
- [ ] Set up and run daily open-source intelligence (OSINT) monitoring tasks for each defined site category.
- [ ] Set up a standard evidence format (web address, dates and times, author or account, indicator, and confidence level) and store evidence in an unchangeable (immutable) way.
- [ ] Integrate monitoring results with the security operations centre (SOC) case workflow, using security information and event management (SIEM) and security orchestration, automation and response (SOAR), to automatically create incidents when they exceed the agreed threshold.
- [ ] Set up automated alerts to notify the incident response lead and the information system owner, including all required details.
- [ ] Add an incident triage step to assess the impact (for example, whether personal data, confidential business information, or login credentials are involved) and record the outcome.
- [ ] Create and run a removal (takedown) plan that sends the required requests, records the request reference numbers, and monitors the progress of any follow-up actions.


---

#### AU-13.1 — Use of Automated Tools (Enhancement)

This requirement is about using automated checks to keep watch on publicly available information, so you can quickly spot anything that might accidentally reveal sensitive details. Without this, new posts on relevant websites, forums, or feeds could go unnoticed for too long, increasing the risk that information is disclosed when it should not be.

The organisation is expected to set up and run automated monitoring using commercial alert services and automated scripts. These should regularly check selected public sources for new posts that match agreed relevance criteria, and confirm that the monitoring is actively running. The organisation must also clearly state who is responsible for reviewing any alerts and deciding what follow-up actions are needed.

Finally, the organisation must be able to provide evidence of this monitoring. This includes its governing documents and plans, the documented design and configuration of the monitoring tools, records of the tools used, and system audit records showing monitoring activity and results.

##### Automated open-source monitoring with governed alert intake

- Category: Manual
- Priority: High

###### WHAT
Set up and run automated processes to watch open-source information and information websites for new posts. Use a commercial monitoring alert service, and use automated scripts for any smaller or niche sources that the service cannot cover. Send alerts into a controlled review process and keep proof that the monitoring is set up, running, and producing recorded results.

###### WHY (control requirement)
AU-13(1) (Enhancement) requires the organisation to **monitor open-source information and information sites using automated mechanisms** (parameter: **au-13.01_odp = automated mechanisms**). The guidance explains that automated mechanisms include **commercial services that send notifications and alerts** and **automated scripts** to monitor new posts.

###### HOW (specific steps/approach)
1. **Define the monitoring scope**: create a monitoring register that lists each open-source source (for example, a URL, feed, or forum), the relevance criteria (topics, keywords, filters), and the intended purpose (for example, early detection of potentially sensitive disclosures).
2. **Configure the commercial monitoring service**: set up subscriptions and rules for each source and relevance criteria so it detects **new posts** and generates notifications and alerts.
3. **Route alert delivery through a governed workflow**: send alerts into an internal intake channel (for example, a ticketing system, security orchestration, automation and response (SOAR), or security information and event management (SIEM) process), not by ad-hoc email, so alerts are triaged, assigned, and closed with recorded outcomes.
4. **Ensure monitoring is actively running**: carry out operational checks (for example, scheduled verification checks or service health checks) and keep evidence that rules and subscriptions remain enabled during the assessment period.
5. **Record and retain evidence**: send alert receipt and handling records to the organisation’s SIEM/logging system and keep configuration exports (enabled rules and subscriptions) plus alert history for the relevant review window.
6. **Control changes and responsibilities**: manage changes to rules and sources through change control; assign named roles for reviewing alerts and for escalation and closure; record the reviewer’s identity and timestamps in the ticket and audit trail.

###### WHO (role responsible)
- **Security Operations Centre (SOC) / Threat Intelligence**: owns the monitoring register, relevance criteria, and the alert triage workflow.
- **Security Engineering / Governance, Risk and Compliance (GRC)**: ensures governance, change control, and audit evidence requirements are met.
- **Platform/IT Operations**: ensures the service integration, health checks, and log forwarding to SIEM.

###### Acceptance criteria
- The organisation can show that automated monitoring is set up for the defined open-source sources and relevance criteria, and that it detects **new posts**.
- Alerts are sent into a controlled workflow where named reviewers triage and record outcomes.
- Evidence is available showing monitoring rules and subscriptions are **enabled and active** during the assessment period.
- Audit and log evidence is available for alert receipt and handling (for example, SIEM events and ticket history), and configuration evidence is available (for example, exported rule and subscription configuration).

###### Actions Required for Compliance

- [ ] Create and get approval for a monitoring register that lists the open-source sources to use and the criteria for deciding whether each source is relevant for detecting new posts.
- [ ] Set up the commercial open-source monitoring service by turning on the required rules and subscriptions for each data source and each set of criteria.
- [ ] Integrate alert notifications into the organisation’s approved workflow (ticketing, security orchestration, automation and response (SOAR), and security information and event management (SIEM)), with a named person responsible for investigating and prioritising alerts (triage).
- [ ] Carry out operational checks to confirm that monitoring is still running (for example, regularly verify that scheduled rules or subscriptions are enabled).
- [ ] Send alert receipt events and workflow results to security information and event management (SIEM) or logging, and keep the evidence for the assessment period.
- [ ] Apply change control to updates of monitoring rules and data sources, and store configuration exports linked to the relevant change tickets.
- [ ] Review service level agreements (SLAs) and define escalation and closure criteria, ensuring reviewer identity and the date and time of review are recorded in audit records.


---

#### AU-13.2 — Review of Monitored Sites (Enhancement)

This requirement is about making sure the organisation’s selected public websites to monitor are still the right ones, every week. If the list is not checked regularly, the organisation could miss useful signs that someone has shared its information without permission, or it could waste time monitoring websites that no longer matter—creating gaps in detection.

To meet this requirement, the organisation must review the current list of open-source information websites at least once each week. It must confirm that each website is still relevant to the organisation’s monitoring purpose, and decide whether any new websites should be added. Any new websites added must be ones that could help provide evidence of unauthorised disclosure.

The organisation must keep clear records showing who reviewed the list and when, what decisions were made, and how any changes to the monitored websites link back to that weekly decision.

##### Weekly review workflow for monitored open-source sites

- Category: Software
- Priority: High

###### WHAT
Set up a scheduled, auditable process that reviews the organisation’s official list of open-source information sites being monitored at least **weekly**. For each site, confirm it is still relevant for detecting unauthorised disclosure, and record decisions to **keep/remove/adjust** existing sites or **add** new ones.

###### WHY (control requirement)
The National Institute of Standards and Technology (NIST) AU-13(2) enhancement requires the organisation to **review the list of open-source information sites being monitored**. The guidance also expects regular review to ensure sites remain relevant, and to support adding new sites based on credible threat intelligence.

###### HOW (specific steps/approach)
1. **Create and maintain an official monitored-sites record** (for example, a Git-based configuration or a secured configuration database) that includes, at minimum: site URL, monitoring purpose, owner, and evidence-mapping fields (for example, what unauthorised disclosure evidence the site could provide).
2. **Run a weekly review** (for example, every Monday at 09:00) that creates a review task (“review pack”) for named reviewers, using the latest snapshot from the official monitored-sites record.
3. **Use a structured relevance checklist for each site** with required fields: current relevance (still relevant / needs adjustment / remove), reviewer reasoning, and (if adding) justification clearly linked to potential unauthorised disclosure evidence.
4. **Require clear decision outcomes**: the process must record an explicit result for each site (**keep/remove/adjust**) and an explicit statement when no new sites are added.
5. **Apply changes using controlled updates**: any approved add/remove/adjust actions must be applied only through a controlled change method (for example, a ticket/change record linked to the weekly review ID) and checked against policy rules (for example, format, ownership, and category checks).
6. **Automatically keep audit evidence**: record the reviewer’s identity, review date/time, completed checklist outputs, and links to any ticket/change that updated the official monitored-sites record.

###### WHO
- **Information Security / Threat Intelligence Lead**: owns the review criteria and the relevance checklist.
- **Named reviewers (for example, Threat Intelligence analysts)**: complete the weekly review pack and record decisions.
- **Configuration/Change Manager (or Security Operations (SecOps) automation owner)**: ensures approved list changes are applied in a controlled way.

###### Acceptance criteria
- A weekly review is completed **at least once every week** for the monitored-sites list.
- For every site in the list, the review records a documented relevance decision (keep/remove/adjust) with reasoning.
- Any newly added sites include justification linked to potential unauthorised disclosure evidence.
- The official monitored-sites list is updated only through approved, traceable changes linked to the weekly review record.
- Audit evidence is available for each weekly cycle: reviewer identity, timestamp, checklist completion, and linked change/ticket references.

###### Actions Required for Compliance

- [ ] Define and publish the official “monitored sites” data format (including the website address, owner, purpose, and where evidence is recorded) in the configuration repository.
- [ ] Set up a weekly scheduled process that creates a review pack from the official list.
- [ ] Set up a required, site-by-site relevance checklist that clearly states what must be kept, removed, or adjusted, and require a written reason for adding anything to a site.
- [ ] Set up an approval step and controlled change process so that only approved decisions can update the official list.
- [ ] Set up automatic audit logs to record who reviewed, when the review happened, the checklist results, and the related change or ticket reference IDs.
- [ ] Run a weekly pilot cycle and check that reviews are completed and that supporting evidence is captured to meet audit requirements.


---

#### AU-13.3 — Unauthorized Replication of Information (Enhancement)

This requirement is about actively checking whether other people are copying your information or pretending to be you, especially online. If unauthorised copying or impersonation is not noticed, customers and partners can be misled, scams can spread, and your organisation’s reputation and day-to-day operations can be harmed.

To meet this expectation, the organisation must set out a clear, documented approach for finding unauthorised copying by external parties. This includes defining what counts as unauthorised copying or impersonation. The organisation should use repeatable methods and supporting tools to look for signs of misuse, such as scanning external websites for lookalike pages and monitoring public sources like social media for suspicious accounts or posts.

Named staff must be responsible for carrying out these checks, with input from the teams responsible for information security and privacy. Relevant staff must also be trained to recognise warning signs and to know how to report and escalate concerns. The organisation must keep records showing what was checked, what was found, who took action, and what follow-up decisions were made.

##### Automated discovery of external impersonation and content replication

- Category: Software
- Priority: Critical

###### WHAT
Set up a discovery capability that can be audited and repeated, to check whether outside parties are copying the organisation’s information without permission. This should focus mainly on public web activity (lookalike domains and copied or almost-identical pages) and, where possible, public social media channels.

###### WHY (control requirement)
NIST SP 800-53 AU-13(3) (enhancement) requires the organisation to **use discovery methods, processes, and tools** to find out whether **outside parties are copying the organisation’s information without authorisation**. The guidance specifically points to discovery approaches such as **checking external websites** and **monitoring social media**, with evidence that can be used for follow-up investigation.

###### HOW (specific approach)
1. **Define the discovery scope and decision rules**: create and keep an official list of scope that includes approved domains/website addresses (URLs), brand identifiers (names and logos where allowed), and high-risk pages (for example: login, contact, pricing, and downloads). Define what counts as “unauthorised copying” for your organisation (for example: lookalike domains/typosquatting, pages with very similar content and layout, impersonation wording, and fake forms used to collect credentials).
2. **Set up automated discovery tools**: arrange scheduled external checks to detect:
   - **Lookalike domains** (typosquatting and domains closely related to the brand)
   - **Page similarity** (copied or almost-identical content and layout)
   - **Impersonation signals** (for example: “official”, “verified”, incorrect contact details, inconsistent branding)
   - **Phishing signals** (for example: fake login pages, patterns consistent with collecting credentials)
   For each potential match, collect evidence such as the URL, date/time, page title, similarity score, and a screenshot or archived copy.
3. **Link to the investigation process**: when a potential match is found, automatically create an investigation record (using a security orchestration, automation and response (SOAR) or ticketing integration). Include the scope match, links to evidence, an initial risk rating, and the fields analysts need to record their decision.
4. **Have analysts review and escalate**: named analysts check each candidate manually, decide whether the copying is unauthorised, and record the result (for example: cleared, escalated to legal/brand protection, or a request to remove the content through the hosting provider or domain registrar). Make sure all actions taken are recorded.
5. **Keep audit-ready evidence and control changes**: keep the scan results and investigation outcomes for the audit period. Store the scan scope and detection thresholds as version-controlled configuration, so changes can be reviewed and repeated.
6. **Extend to social media monitoring (where feasible)**: set up monitoring for brand impersonation accounts and suspicious posts using approved public-source monitoring methods, and send any candidates into the same investigation process.

###### WHO
- **Information Security / security operations centre (SOC) analyst team**: reviews candidates and records outcomes.
- **Brand protection / Legal / Communications (as applicable)**: decides on escalation and takedown actions.
- **Security Engineering / platform team**: owns the discovery tool configuration, evidence retention, and integrations.
- **Privacy role (where personal data may be involved)**: advises on monitoring boundaries and how to handle any personal data that is encountered.

###### Acceptance criteria
- The organisation can show **repeatable discovery** (scheduled scans and/or continuous monitoring) for the defined brand/domain scope.
- For every detection, the organisation keeps **audit evidence** (candidate URL, timestamps, captured materials, and the reason for the similarity/indicator assessment) and records an **investigation outcome**.
- Unauthorised copying candidates are **sent through a documented escalation route**, with recorded actions (takedown requests or formal clearance).
- Scan scope and detection thresholds are **version-controlled**, and changes can be reviewed.
- (If social media monitoring is included) social media candidates are handled through the same evidence-and-investigation process.

###### Actions Required for Compliance

- [ ] Define and get approval for the official scope of domains and web addresses (URLs), brand identifiers, and high-risk pages. Include clear decision criteria for what counts as “unauthorised replication”.
- [ ] Set up external monitoring tools to identify lookalike domains and web pages that closely match in content and layout, including signs of phishing and impersonation.
- [ ] Run website scans at a frequency based on risk and save proof of findings (web address, date and time, screenshots or stored copies, and similarity scores).
- [ ] Set up alerts to automatically create investigation records in security operations and ticketing systems, including all required information and links to supporting evidence.
- [ ] Set out the results of analyst checks and what happens next (for example, cleared, kept for legal or brand protection, or a request to remove content) and record every action taken.
- [ ] Set up version-controlled records for the scan scope and the detection thresholds, and keep the scan and investigation evidence for the whole audit period.
- [ ] If relevant, enable approved public social media monitoring to detect brand impersonation and send any findings into the same investigation process.


---

### AU-14 — Session Audit (Control)

This requirement is about being able to record and later review what a user did during a specific work session when there are serious concerns, such as a confirmed or suspected security incident, an insider threat, or unauthorised access involving confidential or highly sensitive information. Without this, the organisation may find it difficult to understand what happened, who did it, and which data was affected. This can delay containment, weaken investigations, and increase the risk of the same harm happening again.

The organisation must set up and run session auditing so that, in the situations defined above, only the incident response team lead, the system security officer, and authorised legal or compliance investigators can record, view, and log the session content. It must develop, integrate, and use these activities with legal counsel, following all relevant laws, regulations, internal policies, and privacy requirements. It must also document the approach, procedures, system design and settings, and how records are stored and handled, while actively managing privacy risks that could arise from capturing personal information.

##### Case-gated session recording with RBAC and privacy/legal controls

- Category: Software
- Priority: Critical

###### WHAT must be done
Implement a session audit capability that can **record, view, and log the content of a user session** when the organisation-defined **circumstances** apply (confirmed or suspected security incident, insider threat, or unauthorised access involving **Confidential/Secret** data). Ensure only **authorised roles** can activate this capability and access the resulting records.

###### WHY (control requirement)
AU-14 requires the organisation to provide **session auditing** (in addition to event logging) that can capture session content, and to **turn it on only in clearly defined situations**. The guidance also requires addressing **privacy risk** and consulting legal counsel, civil liberties officials, and privacy officials, so that legal, privacy, and civil rights/civil liberties issues (including the use of personal data) are properly considered.

###### HOW (specific steps/approach)
1. **Define and enforce authorised roles** for session audit content (record/view/log) using enterprise **role-based access control (RBAC)** linked to identity (for example, identity provider (IdP) groups):
   - Incident response team lead
   - System security officer
   - Authorised legal/compliance investigators
2. **Create a case-driven activation workflow** in the incident/case management system that requires:
   - Case/incident reference
   - Data classification = Confidential/Secret
   - Circumstance code = confirmed versus suspected incident/insider/unauthorised access
   - Legal/privacy approval indicator (or a reference to an approval record)
3. **Integrate a session recording capability** (session capture technology) so that recording can be **started and stopped only when the case workflow is “armed”** and the classification/circumstance match the policy. Store session recordings as **retrievable records** linked to:
   - the case/incident ID
   - the user session identifier
   - the activating user (auditor)
4. **Protect access to recordings** using the principle of least privilege:
   - Separate permissions for **record**, **view**, and **log/export** actions
   - Require re-authentication (step-up authentication) for viewing and exporting
   - Ensure every view/export/download action is written to an **immutable audit trail** (and linked to the case ID)
5. **Implement privacy risk mitigations** before and after capture:
   - Configure capture scope to minimise non-relevant content where feasible
   - Use redaction workflows for personal data (using legal/privacy-defined rules)
   - Apply retention limits and secure handling consistent with the privacy plan
6. **Document and keep evidence of the approach**:
   - System security plan/design/configuration records showing activation conditions, RBAC mapping, storage locations, retention, and audit trail design
   - Evidence of legal/privacy consultation and approval criteria
   - Operational runbook for activation, review, redaction, retention, and access

###### WHO (role responsible)
- **System Security Officer**: owns the technical design, RBAC mapping, and enforcement of the activation policy.
- **Incident Response Team Lead**: runs the case-driven activation process and ensures circumstances/classification are recorded correctly.
- **Authorised Legal/Compliance Investigator**: provides/records legal approval criteria and participates in review/redaction decisions.
- **Privacy Officer / Legal Counsel**: checks privacy risk mitigations, retention, and personal data handling rules.

###### Acceptance criteria
- Only the defined authorised roles can **record, view, and log** session audit content.
- Session recording activates **only** when a case is opened/armed with circumstances matching the defined criteria and the data classification is **Confidential/Secret**.
- Session recordings are **retrievable** and are cryptographically/operationally linked to a specific **case ID** and **user session**.
- All actions (activation, view, export, and deletion/redaction where applicable) are logged to an immutable audit trail.
- Privacy mitigations (minimisation/redaction/retention) are implemented and evidenced through documented legal/privacy approval and configuration.

###### Actions Required for Compliance

- [ ] Define role-based access control (RBAC) roles for session audit records (viewing and logging) and link them to enterprise identity groups.
- [ ] Set up a case-based activation process that requires an incident reference number, a circumstance code, and a classification of either **Confidential** or **Secret**.
- [ ] Set up the session recording system so it only starts and stops when the case workflow is active (armed) and the required policy conditions are met.
- [ ] Link each session recording to the case identifier and the user’s session identifier, then store it in a secure, access-controlled repository where it can be retrieved.
- [ ] Limit access to recordings to the minimum permissions needed. Require an extra verification step before viewing or exporting, and record every access action in a log.
- [ ] Put in place privacy safeguards that have been approved by Legal and Privacy, including: collecting only what is necessary (capture minimisation), removing personal information (personally identifiable information (PII)) through a defined redaction process, and setting limits on how long data is kept (retention limits).
- [ ] Document the system design, the conditions for when it is activated, how information is kept and handled, and the proof that legal and privacy advice was sought.


---

#### AU-14.1 — System Start-up (Enhancement)

This requirement is about ensuring the system automatically starts recording user activity every time it is switched on, without anyone needing to remember to turn it on manually. If this does not happen reliably, key evidence about who did what after a restart could be missing or incomplete. That would make it harder to spot misuse, investigate incidents, or prove what happened—particularly if someone tries to interfere with the recording.

To meet this requirement, the organisation must set up and document clear procedures for recording user sessions. It must also formally state in its approved policy and plans that session recording must start automatically when the system starts up. The organisation must include this in its security and privacy planning, ensure the system is designed to begin the recording process at boot, configure the system using documented settings, and be able to demonstrate that new session records are created after a reboot using real user activity.

##### Boot-time initiation of session audit with post-reboot verification

- Category: Software
- Priority: Critical

###### WHAT
Automatically start **session audits** when the system boots, so session activity is recorded without needing manual actions.

###### WHY (control requirement)
AU-14(1) (Enhancement) requires that **session audits are started automatically at system start-up**. The guidance explains that this helps ensure the information collected is complete and lowers the risk of compromise through tampering or missing coverage after restarts.

###### HOW (specific steps/approach)
Set up the audit system to start at boot, and add automated checks that confirm it is actually creating audit records after a reboot.

1. **Define what “session auditing” covers** in your environment (for example, interactive logon/logoff, remote session start/stop) and match it to the audit events your platform produces.
2. **Update governance documents** so the requirement is clear and can be checked:
   - Audit and Accountability Policy: state that session auditing must start automatically at system start-up.
   - System Security Plan and Privacy Plan: describe what session data is collected, how it is protected, and privacy handling/retention expectations.
3. **Configure the audit service/agent to start at boot** using your platform’s built-in method:
   - Linux: make sure `auditd` (or an equivalent) is enabled and starts automatically on boot (for example, using systemd enablement), and that the audit rules for session events are loaded at start-up.
   - Windows: make sure the relevant auditing policy is set and the auditing system is enabled; also ensure any required services are set to start automatically.
   - Containerised/microservices workloads: make sure the node/host auditing is enabled at boot, and that any application-level session logging components are started automatically by the orchestration layer.
4. **Apply the configuration centrally** (to prevent changes going unnoticed): use configuration management (for example, Ansible, Puppet, Chef, or an equivalent) to apply the audit settings and ensure services are enabled during provisioning and during scheduled checks.
5. **Verify after boot that audit evidence is being produced**:
   - Add a start-up health check that confirms the audit service/agent is running and that at least one expected session audit event is created within a defined time window after reboot.
   - Raise an alert if the audit service is not running, or if no session audit events appear within the window.
6. **Protect audit records and collect them centrally**:
   - Send logs to the organisation’s security information and event management (SIEM) or logging platform using authenticated connections (for example, TLS) and monitor that logs are being received.
   - Apply tamper-resistance controls where possible (for example, restricted write access, write-once/read-many (WORM) or tamper-evident storage options, and access controls).

###### WHO (role responsible)
- **Security Engineering / SOC Engineering**: define what session auditing covers, the verification approach, and what evidence is required.
- **Infrastructure/Platform Engineering**: implement boot-time service start-up and configuration management.
- **Identity & Access Management (IAM) / Security Operations**: confirm that session events match authenticated user sessions and that SIEM ingestion is working.

###### Acceptance criteria
- After a controlled reboot, the audit mechanism responsible for session auditing is **running automatically** without manual intervention.
- Within the agreed time window after reboot, the system produces **new session audit records** (not only events from before the reboot).
- Central logging/SIEM receives the session audit events, and alerts are triggered if auditing fails to start or if no post-boot events are produced.
- The Audit and Accountability Policy, System Security Plan, and Privacy Plan explicitly document the start-up session-audit requirement and how session data is handled.

###### Actions Required for Compliance

- [ ] Update the Audit and Accountability Policy to state that session audits must start automatically when the system is switched on.
- [ ] Update the System Security Plan and Privacy Plan to describe how session audit information is collected, protected, and handled for privacy purposes.
- [ ] Set up the audit service or agent (and the required session audit rules) so it starts automatically when the system boots on each supported platform type.
- [ ] Set up central configuration management to apply and keep audit start-up settings consistent, so they cannot drift over time or be tampered with.
- [ ] Set up an automated check after the system starts to confirm the audit service is running and that session audit events are recorded within the agreed time window.
- [ ] Set up audit log forwarding to the organisation’s security information and event management (SIEM) system using authenticated connections, monitor that log data is being received, and confirm that audit events are visible end to end after a reboot.


---

#### AU-14.3 — Remote Viewing and Listening (Enhancement)

This expectation is about allowing only approved staff to quietly watch and listen to what is happening in an already-running user session, as it happens. This helps the organisation support, investigate, or manage that session without making the user restart. Without this, the wrong people could access live screen and audio, or authorised support could be ineffective because monitoring is delayed, disconnected, or focused on the wrong session.

To meet this expectation, the organisation must provide a working feature that lets authorised users remotely view the live screen and remotely hear the live audio from a specific existing session, with no intentional delay. Access must be strictly limited to the people explicitly approved to do this.

The organisation must also keep clear records of these viewing and listening actions, including who connected, which session was monitored, and when monitoring started and stopped. It must be able to show the relevant policies, procedures, system settings, and audit records.

##### Session-scoped remote view+listen with attach, MFA, and audit logs

- Category: Software
- Priority: Critical

###### WHAT
Set up a capability that lets **authorised users** **remotely view and hear** the **live content of an already-running user session** in **real time**, by **joining that existing session** (not starting a new one).

###### WHY (control requirement)
NIST Special Publication 800-53 **AU-14(3)** enhancement requires the organisation to **provide and implement** remote **viewing and listening** for **authorised users** that are linked to an **already-running user session** and operate in **real time**.

###### HOW (specific approach)
###### 1) Use a remote access platform that supports “attach” to a session (screen + audio)
- Choose and configure an enterprise privileged remote access / remote support capability that can **attach to an existing interactive session** and transmit **both screen and audio**.
- Make sure the platform supports **session binding** (the viewer/listener stays attached to the same session identifier) so monitoring cannot switch to a different session.

###### 2) Require explicit authorisation for viewing and listening
- Integrate with the organisation identity provider (IdP) and enforce **phishing-resistant multi-factor authentication (MFA)** (for example, FIDO2/passkeys) for all remote viewing/listening.
- Use **named-user** or **role-based access control (RBAC)** permissions that clearly allow the right to **view**, and separately (or together) allow the right to **listen**.
- Use an approval process for exceptional access (for example, a ticket/justification) so only explicitly authorised users can attach.

###### 3) Attach to an established session with real-time streaming
- Provide an operator process to select the **target established session** from an official session list.
- Configure **low-latency streaming** settings and turn off any features that intentionally delay. Treat “real time” as **no intentional buffering/delay added by the monitoring capability**.

###### 4) Record auditable evidence for every attach event
- Send audit events to the security information and event management (SIEM) system for:
  - who connected (identity),
  - which **session** was monitored (session identifier),
  - start time and stop time,
  - whether **viewing** was enabled and whether **listening** was enabled,
  - the initiating workflow context (for example, ticket/reference) and reason.
- Prevent audit logs from being altered and keep them according to the organisation’s enterprise logging retention policy.

###### 5) Privacy and minimisation controls
- Apply privacy controls suitable for the platform (for example, masking/redaction where possible, and limiting access strictly to the selected session only).
- Ensure the capability cannot be used for broad “monitor anything” access; it must be **session-specific**.

###### WHO
- **Security Architect / Compliance Lead**: sets the control requirements, authorisation model, and what audit evidence must be captured.
- **Privileged Access/Remote Support Engineer**: configures the remote access platform for session attach (screen+audio), multi-factor authentication (MFA), and session binding.
- **Identity and Access Management (IAM) Engineer**: integrates the identity provider (IdP), multi-factor authentication (MFA), and conditional access.
- **Security Operations Centre (SOC)/Security Information and Event Management (SIEM) Engineer**: ensures audit events are sent to the SIEM, formatted consistently, and kept according to policy.

###### Acceptance criteria
- An authorised user can **attach to an existing established session** and **simultaneously** view the live screen and hear the live audio.
- The monitoring stream is **real time** (no intentional delay added by the monitoring capability).
- An unauthorised user cannot attach; access is limited to **explicitly authorised** users and the selected **session identifier**.
- For every attach session, audit records exist showing **initiator**, **target session**, **start/stop times**, and whether **viewing** and **listening** were enabled.
- Audit events are visible in the SIEM and are retained and protected according to enterprise policy.

###### Actions Required for Compliance

- [ ] Choose and set up a remote access and privileged support platform that can join an existing session, with both screen viewing and audio relay.
- [ ] Integrate the platform with the organisation’s identity provider (IdP) and require phishing-resistant multi-factor authentication (MFA) for all remote viewing and listening sessions.
- [ ] Set up clear permission checks for who can view and listen (either by named users or by giving only the minimum necessary access), and include an approval process for any exceptional cases.
- [ ] Set up session binding so the viewer or listener stays connected only to the selected established session identifier.
- [ ] Adjust streaming settings to prevent any deliberate delay, and confirm that the total end-to-end delay meets the organisation’s real-time expectations.
- [ ] Enable security information and event management (SIEM) reporting for audit logs for every “attach” event, including the identity of the person or system that initiated it, the target session ID, the start and stop times, and whether viewing or listening was enabled.
- [ ] Check that privacy and data-minimisation controls work properly (for example, limiting what each session can access and any available masking or redaction), and document the steps operators must follow.


---

### AU-16 — Cross-organizational Audit Logging (Control)

This requirement is about making sure that when your organisation asks an external organisation for a service, there is a clear and trustworthy record showing who requested it, when it was requested, where it came from, and what was requested. Without this, it is difficult to investigate issues, confirm what was authorised, and identify misuse between organisations. Records could also be incomplete, changed, or shared in ways that break agreements or privacy expectations.

To meet this requirement, your organisation must put in place a coordinated approach to share audit information with external organisations. This should use a consistent event format that the other organisation can understand, protect the records digitally so they can be checked for tampering, and share them only through secure channels covered by approved information-sharing agreements.

Your organisation must also define and document the process for coordinating these exchanges, assign named responsibilities for coordination and for information security and privacy, and ensure that the system design, configuration, plans, and stored audit records reflect how auditing is carried out across organisations.

##### Cross-org audit event schema, signing, and secure exchange pipeline

- Category: Software
- Priority: Critical

###### WHAT
Set up a coordinated, cross-organisation approach for recording and sharing audit information when it is sent between organisations. This approach must:
- use a standard format for audit events,
- include the person or system that made the request (requestor identity),
- include the date and time (timestamps),
- include the identifier of the system that produced the event (source system identifier),
- include the relevant audit event details,
- protect audit records digitally so they cannot be altered without detection, and
- share them only through approved information-sharing agreements and secure methods.

###### WHY (control requirement)
AU-16 requires the organisation to “employ methods for coordinating audit information among external organisations when audit information is transmitted across organisational boundaries” and to coordinate the defined “audit information” (requestor identity, timestamps, source system identifiers, and audit event details). Guidance expects a coordinated approach because keeping the same identity across organisational boundaries can be difficult and may raise privacy and performance concerns. Therefore, the approach should usually record requestor identity at the first system, and ensure later systems record that the request came from an authorised person. It also expects processes for coordinating audit information requirements and protecting audit information within the information exchange agreements.

###### HOW (specific steps/approach)
1. **Define the cross-boundary audit event standard**: create a standard audit event structure for cross-boundary service requests that includes, at minimum: requestor identity, timestamp, source system identifier, and audit event details (as per `au-16_odp.02`). Add correlation identifiers so the original request can be linked to later processing.
2. **Set an authoritative identity capture point**: ensure the first system (or service gateway) records the requestor identity when the request enters the system, and that later components record that the request came from an authorised identity (for example, using a stable requestor identifier and/or signed token claims).
3. **Digitally protect audit records**: sign audit records (or use per-record hashes with verifiable supporting information) before exporting them. Use a signing key controlled by the organisation (preferably protected by a hardware security module) and include key identifiers and signature details so recipients can check integrity and authenticity.
4. **Use secure, agreement-controlled exchange**: export signed audit events to each external organisation only under approved information-sharing agreements and using secure transport (for example, mutually authenticated endpoints or approved managed connectors). Keep an approved list of partners/destinations and enforce encryption while data is in transit.
5. **Coordinate requirements and protection in the agreements**: for each external organisation, document in the information exchange agreement the required schema version, required fields, signing and verification expectations, retention and handling expectations, and privacy/data minimisation rules for any requestor identity information.
6. **Make verification and evidence operational**: when events are received (where applicable), verify signatures before accepting them. Quarantine or reject any failures and alert the security operations centre (SOC). Provide audit-ready evidence that the process enforces schema compliance, signing, and secure transport (for example, configuration snapshots, operational logs, and signature verification performance measures).

###### WHO (role responsible)
- **Security Architect / Compliance Lead**: owns the AU-16 method, the schema standard, and the agreement requirements.
- **Platform/Integration Engineering Lead**: builds the audit event pipeline, signing, and secure exchange.
- **Identity and Access Management (IAM) / Identity Engineering**: ensures authoritative requestor identity capture and stable identifiers.
- **Legal/Privacy Officer + Contract Manager**: ensures information exchange agreements include coordination and protection requirements.
- **SOC/Monitoring Lead**: owns how verification failures are handled, how alerts are raised, and how evidence is collected.

###### Acceptance criteria
- Cross-boundary audit events exported to external organisations follow the agreed standardised schema and include **requestor identity**, **timestamps**, **source system identifiers**, and **audit event details**.
- Every exported audit record is **digitally signed** before transmission, and recipients (or the receiving pipeline) can **verify signatures**.
- Audit events are transmitted only via **approved information-sharing agreements** using **secure transport**, with partner/destination allowlisting enforced.
- For each external organisation, the information exchange agreement documents schema versioning, required fields, signing and verification expectations, and privacy/data protection handling for requestor identity.
- Signature verification failures are handled in a consistent way (quarantine/reject) and trigger operational alerts and audit evidence.

###### Actions Required for Compliance

- [ ] Define and publish a standard format for audit records shared across different systems, including who made the request, the date and time, the system where the request came from, and the audit details.
- [ ] Set up an official request capture process so that later records show each request came from an authorised person.
- [ ] Set up an audit export process that digitally signs each audit record (or creates a unique hash for each record) before sending it, and include the signature details needed to verify it.
- [ ] Set up secure, contract-approved export routes with approved partner and destination lists (allowlists) and encryption while data is being sent
- [ ] Update information-sharing agreements to clearly state the data format version (schema version), the required fields, what signing and verification are expected, and how privacy and data protection will be handled for the requestor’s identity.
- [ ] Where applicable, enable signature verification when receiving documents, and if verification fails, quarantine or reject the item. Also alert the security operations centre (SOC) when signature verification fails.


---

#### AU-16.1 — Identity Preservation (Enhancement)

This requirement is about making sure that, when action records are shared between organisations, the person responsible for each action can still be clearly identified. Without this, wrongdoing or mistakes can be hidden behind unclear or missing identities, which makes it harder to investigate problems, assign responsibility, protect people’s privacy, and meet legal or contractual duties across organisational boundaries.

To meet this expectation, the organisation must ensure that audit records created or used across organisations always include enough information to identify the individual who carried out the action. It must also make sure that this identity information is not changed at any point when records are shared or accessed by another organisation.

The organisation should document how this is achieved in its audit and accountability policy and related procedures. Where personal data is involved, it should include this in its system and privacy planning. It should also describe it in its system design and configuration documentation. Finally, the audit records themselves must keep the identity details needed for authorised reviewers to trace each action back to the specific person.

##### Immutable actor identity in cross-org audit trails

- Category: Software
- Priority: Critical

###### WHAT
Set up an audit record design that keeps a reliable, unchanging identity for the person (or service) who took the action. Every audit record the application creates must include this authoritative identity (for example, the enterprise identity provider’s (IdP) permanent employee or subject identifier). That same identity must stay exactly the same when audit records are exported, shared, or imported by other organisations.

###### WHY (control requirement)
AU-16(1) (Enhancement) requires the organisation to **keep individuals’ identities consistent in audit trails that cross organisational boundaries**, so actions taken across organisations can still be traced back to the specific individual.

###### HOW (specific steps/approach)
1. **Define an “actor identity contract” for audit events**: create a fixed audit event format that always includes unchangeable actor details (for example, `actor.id` from the enterprise IdP permanent identifier, `actor.type`, `actor.tenant/org`, and optional display details like `actor.name`). Also include an event identifier (`eventId`) and the time the event occurred.
2. **Capture identity at the source from the authoritative identity information**: make sure the application takes actor identity from the authenticated session or token details issued by the enterprise identity provider (not from information supplied by the client, such as headers or parameters). For service accounts, use a separate `actor.type` and still ensure the identity is stable and can be attributed.
3. **Prevent changes to identity through the audit process**: configure logging and forwarding so actor identity fields cannot be altered later (for example, ignore any incoming attempts to override them, store audit logs in an append-only way, and stop any later “enrichment” steps from overwriting `actor.id`).
4. **Strengthen cross-organisation sharing and data movement with checks**: when sending audit records to partners/regulators/security operations centres (SOCs) or importing them into a third-party security information and event management (SIEM) system, apply controlled transformations that validate the actor identity contract. Reject or flag events where actor identity fields are missing, blank, or do not meet required format and consistency rules.
5. **Keep audit evidence usable for review**: document this identity-preservation approach in the system design and configuration. Ensure each audit record contains enough information for an authorised reviewer to trace each action to the same individual across organisational boundaries.

###### WHO
- **Application Security Architect / Security Engineering Lead**: defines the actor identity contract and the rules that prevent identity changes.
- **Application Engineering Team**: implements identity capture from the enterprise IdP context and ensures audit events follow the contract.
- **Platform/Logging Engineering (SIEM/ETL owners)**: implements identity checks, controlled transformations, and identity immutability in the log pipelines.
- **Compliance/Assurance Lead**: confirms the audit evidence is sufficient for cross-organisation tracing.

###### Acceptance criteria
- In cross-organisational audit sharing flows, every exported or imported audit event includes a non-empty, stable `actor.id` that matches the authoritative IdP permanent identifier.
- Actor identity fields (`actor.id`, `actor.type`, `actor.tenant/org`) remain unchanged from when the event is created through to export and import (verified by an end-to-end test comparing source and destination records).
- Events that do not contain valid actor identity fields are rejected or placed in a quarantine process (not silently turned into records with missing or unclear identities).
- An authorised reviewer can pick an audit event from the cross-organisation trail and trace it to the same individual using the preserved identity fields alone.

###### Actions Required for Compliance

- [ ] Set a fixed audit event format (the “actor identity” rule), including an unchangeable `actor.id` taken from the organisation’s identity provider (IdP).
- [ ] Update the application to generate audit events using actor identity only from the claims in an authenticated session or token.
- [ ] Set up audit and log pipelines so that the “actor identity” details cannot be changed after they are first recorded (ignore or remove any later attempts to override them).
- [ ] Add data format checks to the cross-organisation export and import (extract, transform, load) process so that any events with missing or incorrect actor identity are either rejected or moved to a quarantine area.
- [ ] Add end-to-end tests that compare the audit records at the source and destination to confirm the actor’s identity has not changed.
- [ ] Publish system design and configuration documentation that explains how identity is kept consistent from start to finish for cross-organisation audit trails.


---

#### AU-16.2 — Sharing of Audit Information (Enhancement)

This requirement is about making sure your organisation shares its audit records with the Department of Defense (DoD) Component Security Operations Centres and the Joint Regional Security Operations Centre (JRSOC) in a controlled, agreed way. This helps other organisations correctly identify possible misuse and investigate issues that involve more than one organisation. Without this, important evidence could be missing, sent to the wrong parties, or shared in a way that does not follow legal or contractual rules—making security and privacy risks harder to detect and fix.

To meet this expectation, you must:

- Identify the two receiving parties.
- Share audit information only under Department of Defense (DoD)-approved cross-organisational audit information sharing agreements that include the Criminal Justice Information Services (CJIS)/DoD data-sharing terms and the Capability Maturity Model Certification Level 2 and Level 3 (CMMC-L2/L3) requirements.
- Have documented, practical procedures that explain exactly how the sharing will happen.
- Assign named individuals who are responsible for carrying out the sharing and for overseeing information security and privacy.
- Ensure your audit and accountability policy, system security plan, and privacy plan explicitly cover this sharing.
- Keep the approved agreements and supporting records so you can prove compliance.

##### Agreement-governed cross-org audit export to DoD SOC/JRSOC

- Category: Software
- Priority: Critical

###### WHAT
Set up an agreement-controlled method to share audit information across organisations with the **DoD Component Security Operations Centres** and the **Joint Regional Security Operations Centre (JRSOC)**. Use only the **DoD-approved cross-organisational audit information sharing agreements** that include the **CJIS/DoD data-sharing terms** and **CMMC Level 2 (CMMC-L2) / Level 3 (CMMC-L3) requirements**.

###### WHY (control requirement)
The NIST AU-16(2) enhancement requires: **“Provide cross-organizational audit information to {{organizations}} based on {{cross-organizational sharing agreements}}.”** The goal is to make sure audit records are shared with the correct external parties and in a way that supports effective analysis across organisations.

###### HOW (specific steps/approach)
1. **Lock sharing destinations to configuration**: hard-code or use an allow-list so that only the two recipient organisations (DoD Component Security Operations Centres and JRSOC) are allowed as external destinations for audit export.
2. **Lock sharing authorisation to a specific agreement**: create an internal “agreement registry” that stores the **approved agreement identifier/version** and its effective dates. The export process must reference the agreement ID/version and must not run without it.
3. **Check agreement rules before exporting**: add policy checks in the export process to ensure the exported audit data set follows the agreement’s **CJIS/DoD terms** and **CMMC-L2/CMMC-L3 requirements** (for example: allowed event types, required data minimisation/redaction rules, permitted time windows, and any required handling constraints).
4. **Create an evidence package for every sharing event**: for each export/transfer, produce a manifest (source systems, event types, time range, record counts/hashes) and record transfer logs (who started it, who approved it, agreement ID/version, destination, timestamps, and whether the transfer succeeded).
5. **Use a controlled transfer method**: send audit exports only through an approved secure channel/integration (for example, mutually authenticated Transport Layer Security (TLS) or an organisation-approved secure file transfer service). The destination must match the configured recipient allow-list.
6. **Put responsibilities into practice**: require named roles for (a) requesting the export and (b) approving/overseeing compliance with the agreement and information security/privacy requirements. Ensure the workflow separates these responsibilities.
7. **Update governance records to cover this sharing**: make sure the system’s security/accountability documentation and privacy documentation explicitly reference this cross-organisational audit sharing process and the agreement-controlled workflow.

###### WHO
- **Security Operations (SOC) Engineering Lead**: responsible for the export workflow configuration, evidence generation, and destination allow-list.
- **Information Security Officer / Compliance Lead**: responsible for the agreement registry and for checking that the workflow enforces the correct CJIS/DoD and CMMC-L2/CMMC-L3 constraints.
- **Privacy Officer (or Data Protection Lead)**: confirms the privacy-related handling/redaction rules used by the workflow.
- **System Owner / Identity and Access Management (IAM) Owner**: ensures only authorised named roles can initiate/approve sharing.

###### Acceptance criteria
- The system can export and transfer audit information **only** to the configured **DoD Component Security Operations Centres** and **JRSOC**.
- Every sharing event is linked to a **specific DoD-approved agreement ID/version** that includes **CJIS/DoD terms** and **CMMC-L2/CMMC-L3 requirements**. Exports must fail if no valid agreement is referenced.
- The export workflow enforces agreement-based constraints (data minimisation/redaction/event/time-window rules) before any transfer occurs.
- For each sharing event, an auditable evidence package exists containing: agreement ID/version, initiator, approver, destination, time range, event types, record counts/hashes, and transfer logs.
- Separation of duties is enforced so the same named role cannot both initiate and approve the sharing event (unless there is an explicit justification and governance approval).

###### Actions Required for Compliance

- [ ] Create an agreement register that lists the Department of Defense (DoD)-approved cross-organisation audit information-sharing agreements with the Federal Bureau of Investigation Criminal Justice Information Services (CJIS) and DoD terms, and the requirements for Cybersecurity Maturity Model Certification Level 2 and Level 3 (CMMC-L2 and CMMC-L3), including version numbers and start (effective) dates.
- [ ] Set up an approved (allow-list) list of recipient organisations that are permitted to receive information, limited to Department of Defense (DoD) Component Security Operations Centres and the Joint Regional Security Operations Centre (JRSOC).
- [ ] Set up checks before data is transferred to ensure the transfer follows the required CJIS and Department of Defense (DoD) rules and the required Cybersecurity Maturity Model Certification level 2 (CMMC-L2) or level 3 (CMMC-L3) rules, including the allowed event types, allowed time windows, and any data minimisation or redaction requirements. If no valid agreement is referenced, block the transfer (fail closed).
- [ ] Automate the creation of an evidence pack for each sharing activity, including: a data list with checksums, counts, and the time range; the agreement identifier and version; the person who started and the person who approved; the destination; and the transfer records.
- [ ] Set up the export process to send files using a controlled, secure transfer method that uses mutual authentication and only allows approved destination addresses (destination allow-listing).
- [ ] Set up workflow controls so that the person who starts a request is different from the person who approves it, using named roles for each step. Also document the operational runbook that explains how sharing requests are handled.


---

#### AU-16.3 — Disassociability (Enhancement)

This requirement is about sharing audit records without revealing who the person really is. When audit information is shared between organisations, there is a risk that names or other direct details could let others track, build profiles of, or single out individuals—especially if the same person’s activity can be connected over time.  

To reduce that risk while still keeping the organisation accountable, the organisation must ensure that audit events shared across organisational boundaries use temporary coded identifiers instead of direct personal details. These codes must change over time using a defined rotating approach.  

At the same time, the organisation must keep a secure, controlled link between each temporary code and the person’s real identity. This link must be owned and managed by the audit governance office. Only authorised audit governance staff should be able to look up the real identity when there is a legitimate need for accountability.  

The organisation must also be able to demonstrate—through its policies, procedures, system design, configuration, and audit evidence—that the shared records contain only coded identifiers and that the codes rotate as expected.

##### Cross-boundary audit pseudonyms with rotating keys and governed mapping

- Category: Software
- Priority: Critical

###### WHAT
Implement privacy-enhancing cryptographic pseudonymisation for audit information that is shared between organisations, so that shared audit records use coded identifiers instead of direct personal identifiers. Keep a tightly controlled and auditable way to map these coded identifiers back to the real identities, which are owned by the audit governance office.

###### WHY (control requirement)
NIST AU-16(3) requires implementing **au-16.03_odp (measures to separate individuals from audit information shared between organisations)**. The guidance explains that keeping people’s identities in audit records can create privacy risks (for example, tracking or profiling). These risks increase when information is shared between organisations. Privacy-enhancing cryptographic methods should reduce privacy risk while still supporting accountability.

###### HOW (specific steps/approach)
1. **Define the scope of audits shared across boundaries**: identify which audit events, and which identity-related fields (for example, user name, email, subject distinguished name (DN), employee ID) are included in exports to other organisations and security information and event management (SIEM) partners. Confirm these are the only fields that will be separated (pseudonymised).
2. **Implement a pseudonymisation mechanism (software)**:
   - Create an “Audit Pseudonymiser” component/library used by the audit export process.
   - For each identity value, generate a coded identifier using a keyed cryptographic pseudonymisation method (for example, a pseudo-random function (PRF) or hash-based message authentication code (HMAC) over a normalised identifier), with **key versioning**.
   - Make pseudonyms **rotate** by tying the token to a rotation window (for example, a time-based window such as daily or weekly, or event-based windows), so the same person’s pseudonym changes across the defined periods.
3. **Apply transformation at export time (software)**:
   - Update the audit export process so that, for cross-boundary sharing, the exported audit record contains only the coded identifier(s) and removes direct identifiers.
   - Allow internal/local audit storage to keep direct identifiers if needed for internal operations, but ensure cross-boundary exports are separated (pseudonymised).
4. **Govern and secure the reverse mapping (software + manual governance)**:
   - Store only the minimum required mapping information (or enable reverse lookup) in a restricted system owned by the **audit governance office**.
   - Use least-privilege access (role-based access control (RBAC) and attribute-based access control (ABAC)), separation of duties, and strong authentication for lookups.
5. **Controlled lookup workflow (manual + software support)**:
   - Require a ticket and approval process for identity resolution requests, including justification and approval by authorised audit governance roles.
   - Log every lookup attempt, decision, requester, purpose, and the pseudonym/key version used.
6. **Key rotation operations and evidence (manual + software)**:
   - Set rotation frequency and triggers that align with au-16.03_odp “rotating keys”.
   - Record key roll events and ensure the pseudonymiser uses the correct active key version for each rotation window.

###### WHO (roles responsible)
- **Audit Governance Office**: owns the mapping system, approves lookup requests, defines rotation policy parameters, and reviews evidence.
- **Security Engineering / Platform Team**: builds the Audit Pseudonymiser, integrates it into the audit export process, and manages cryptographic configuration.
- **SIEM/Monitoring Integration Team**: ensures cross-boundary exports use the pseudonymised fields and checks that exported payloads are correct.
- **Compliance/Audit Team**: checks evidence and performs disassociability checks during assessments.

###### Acceptance criteria
- Cross-boundary audit exports contain **only coded identifiers** for the selected identity fields; direct identifiers are not included in the transmitted payload.
- Pseudonyms **rotate** according to the defined rotation window (for example, daily or weekly), and the exported token includes (or corresponds to) the correct key version for that window.
- The reverse mapping is accessible only to authorised audit governance roles through an auditable, approved lookup process.
- Evidence is available for: (a) key rotation events, (b) pseudonymisation configuration and versioning, and (c) all mapping lookups (including approvals and justifications).

###### Actions Required for Compliance

- [ ] Define the scope for sharing audit records across organisational boundaries (which events and identity details are included), and confirm which identity fields must be removed from that shared data.
- [ ] Implement an audit pseudonymiser that creates coded identifiers using a secret key–based method for replacing personal data, with support for different key versions.
- [ ] Add the pseudonymiser to the audit export process so any data that crosses boundaries does not include direct personal identifiers, and instead includes only coded identifiers.
- [ ] Set up and run rotating encryption keys by defining the key rotation time window and the conditions that trigger rotation, and ensure the correct (active) key version is used within each window.
- [ ] Set up a restricted mapping store that is owned by the audit governance office, and limit access to the minimum permissions needed (least-privilege access controls).
- [ ] Set up an approved, auditable process for checking identities and record every identity-check activity in the logs.
- [ ] Collect and keep evidence of key rotations, the contents of exported data, and the results of mapping lookups for audit review.

