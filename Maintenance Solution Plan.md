### MA-1 — Policy and Procedures (Control)

This requirement is about making sure your organisation has clear, written rules for how maintenance work is planned, carried out, recorded, and checked—and that these rules are kept up to date. Without this, maintenance may be done inconsistently, important safety and control steps could be missed, and updates made after an incident, a major system change, or new legal requirements might not be reflected. This increases the risk of service disruption, data loss, or failing to meet legal and regulatory requirements.

To meet this expectation, the organisation must create and document an organisation-wide maintenance policy. This policy must explain its purpose, what it applies to, who is responsible for what, how leadership supports it, how different teams work together, and how compliance will be handled. The policy must also align with all relevant laws and internal standards.

The Security Policy Office is responsible for creating, documenting, and sharing the policy and the supporting procedures with the Chief Information Security Officer (CISO), the Security Policy Office, the relevant security officers, and system owners. It must also share the procedures with system owners, operational technology (OT) and information technology (IT) operations managers, and maintenance technicians.

Both the maintenance policy and the supporting procedures must be reviewed and updated at least every year, and also after security incidents or breaches, audit findings, major system changes, or changes to the laws and regulations that apply.

##### Org-level maintenance policy & procedures with trigger-event reviews

- Category: Manual
- Priority: Critical

###### WHAT
Create and maintain an organisation-level **Maintenance Policy** and supporting **Maintenance Procedures** that explain how maintenance is planned, authorised, carried out, checked, and recorded across IT and OT activities.

###### WHY (control requirement)
MA-1 requires that the organisation has **maintenance policy and procedures** that cover the MA family controls implemented in systems/organisations, are aligned with the **risk management strategy**, and are kept up to date. The guidance also requires **security and privacy programme collaboration**, clearly **defined roles for sharing** the documents, and **review/update** of both the policy and procedures **every year and after trigger events** (for example: security incidents/breaches, audit findings, major system changes, and changes to relevant laws/regulations). Simply repeating the controls is not enough.

###### HOW (specific steps/approach)
1. **Security Policy Office** produces one organisation-level Maintenance Policy (or a small set of linked policies) and a Maintenance Procedures set, using a standard template that includes: purpose, scope (IT/OT maintenance), who it applies to, management commitment, the coordination approach between security/privacy and operations, roles and responsibilities, how compliance will be handled, and references to relevant standards/laws.
2. Set dissemination targets exactly as defined by the organisation:
   - **Policy** shared with: **Chief Information Security Officer (CISO), Information System Security Officer (ISSO) / Information System Security Officers, and system owners**.
   - **Procedures** shared with: **system owners, OT/IT operations managers, and maintenance technicians**.
3. Use a **controlled document lifecycle** (versioning, effective dates, approval records, and distribution/acknowledgement logs) in the organisation’s document/governance, risk and compliance (GRC) repository, so audit evidence is available.
4. Set a **review/update schedule** and a **trigger-event process**:
   - Review/update **annually**.
   - Review/update **after trigger events**: security incidents or breaches, audit findings, major system changes, or changes to relevant laws/regulations.
   - Route trigger information from the security operations centre (SOC)/security operations (SecOps), Internal Audit, Change Management, and Legal/Compliance into a documented intake queue with an assigned owner and a documented decision (update or no update, with reasons).
5. Make sure procedures are practical (not just a repeat of MA control statements): include clear steps for maintenance activities (for example: security checks before maintenance, what authorisation/approval is expected, how maintenance will be checked/validated, what to do if work needs to be rolled back where applicable, and what records/evidence must be kept).

###### WHO (role responsible)
- **Security Policy Office**: owns the policy and procedures; writes, maintains, and shares the Maintenance Policy and Maintenance Procedures.
- **CISO**: approves/endorses the Maintenance Policy and ensures it matches the risk management strategy.
- **ISSO/System owners**: acknowledge the policy and ensure alignment at system level.
- **OT/IT operations managers and maintenance technicians**: acknowledge the procedures and follow them during maintenance activities.

###### Acceptance criteria
- An organisation-level Maintenance Policy and Maintenance Procedures set exists, is approved, and is stored in a controlled repository with version history.
- Evidence shows the policy and procedures were shared and acknowledged by the specified roles.
- Document review/update records show **annual review** and **response to trigger events** (at least one workflow run per trigger type, or a documented reason for not updating).
- Procedures include practical guidance on how maintenance is carried out, checked, and recorded, rather than only repeating control statements.
- Evidence of security and privacy programme collaboration exists (for example: review/consultation sign-off or tracked comments from both programmes).

###### Actions Required for Compliance

- [ ] Draft an organisation-wide maintenance policy that sets out its purpose, what it covers, who is responsible for what, how different teams coordinate, how compliance will be checked, and how it aligns with relevant legal and regulatory requirements.
- [ ] Draft maintenance procedures that turn the policy into practical, step-by-step actions across the maintenance lifecycle, including the required records and supporting evidence.
- [ ] Make the Security Policy Office the official owner responsible for maintaining the security policy and procedures.
- [ ] Publish both documents in a controlled document library with version control, approval records, and distribution and acknowledgement logs.
- [ ] Share the Maintenance Policy with the Chief Information Security Officer (CISO), the Information System Security Officer (ISSO) and information system security officers, and the system owners, and obtain written confirmation that they have received it.
- [ ] Share the maintenance procedures with system owners, operational technology (OT) and information technology (IT) operations managers, and maintenance technicians, and get confirmation that they have received them.
- [ ] Set up an annual review timetable and a process for logging and handling trigger events for incidents or breaches, audit findings, major system changes, and legal or regulatory changes.


---

### MA-2 — Controlled Maintenance (Control)

This requirement is about making sure that any repairs, servicing, or part replacements are planned, approved, properly recorded, and checked. The goal is to ensure that nothing sensitive is exposed and that security is not accidentally weakened. Without this, equipment could be serviced without oversight, important settings could be changed or turned off, and when devices are taken off-site for repair, stored information could be left behind or recovered by mistake. This creates a serious risk of data loss or unauthorised access.

The organisation must schedule maintenance using the manufacturer or supplier’s instructions (and its own rules), record exactly what was done, and review the records afterwards. Every maintenance activity—whether carried out on-site or remotely, and whether parts remain on-site or are moved—must be approved and monitored. Any removal of equipment for off-site maintenance must be explicitly authorised by the Authorising Official or the system Security Officer.

Before any equipment leaves the premises, the organisation must securely erase all stored information, including secret keys and any backup copies and logs. After maintenance, it must check any areas that could have been affected to confirm they still work correctly. It must also keep clear records showing when the work happened, what was done, who was involved, any escort details, and which components or equipment were removed or replaced.

##### ITSM-controlled maintenance with AO off-site approval and sanitisation evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled maintenance process within the organisation’s IT service management (ITSM) system. This process must cover every maintenance, repair, and replacement activity for system components, including work carried out off-site by local or non-local providers. It must require clear approval before any off-site removal, ensure all stored information is wiped or otherwise sanitised before anything is handed over off-site (including encryption keys, configuration backups, and logs where applicable), record the required maintenance details, and require a security check after maintenance is completed.

###### WHY (control requirement)
MA-2 requires that maintenance is controlled through the organisation’s maintenance programme, including:

- **Clear approval** before removing the system or any components from the organisation’s premises for off-site maintenance or repairs (MA-02 ODP.01).
- **Clear information handling rules**: the information that must be removed from any associated media before off-site removal must be defined (MA-02 ODP.02). This includes encryption keys and backups/logs.
- **Clear maintenance record content**: maintenance records must include the date/time, a description of the work, the names of the people involved, the escort name (if applicable), and the identifiers of any components/equipment that were removed or replaced (MA-02 ODP.03).

###### HOW (specific steps/approach)
1. **Create a “Controlled Maintenance” work-order template** in the ITSM system with required fields matching MA-02 ODP.03: date/time, maintenance description, names of the people carrying out the maintenance, escort name (if applicable), and the identifiers of any equipment/components that are removed or replaced.
2. **Add an “Off-site removal” flag** to the work order. When this flag is set, use **role-based approval routing** so that only the **Authorising Official (AO)** or the system **Security Officer** can approve the off-site removal request (MA-02 ODP.01). Technician approval on its own must not be enough to proceed.
3. **Require proof of sanitisation** for any component or media that stores information and is being taken off-site. Require an attached **sanitisation record/certificate** that names a **National Institute of Standards and Technology (NIST) Special Publication 800-88 compliant sanitisation** method and clearly covers stored data and **encryption keys**, including **configuration backups and logs** (MA-02 ODP.02).
4. **Include remote maintenance in the same process**: link the work order to the remote maintenance session record (start/end time, identity of the remote operator, and a brief summary of actions where available) so the maintenance is monitored and can be traced even when done remotely.
5. **Require a post-maintenance security check** as part of closing the work order: use a checklist tailored to the component type (for example, checks on configuration integrity, continuity of logging/telemetry, and restoration/validation steps where backups were used). Attach evidence that these checks were completed to the work order.
6. **Carry out a record review**: require a second-person review sign-off (system owner/security function) confirming the work order is complete, matches vendor/manufacturer instructions, and that any potentially affected security-relevant functions were checked.

###### WHO (role responsible)
- **ITSM Process Owner / Service Management Lead**: sets up the work-order template, required fields, and workflow approval gates.
- **Authorising Official (AO) / System Security Officer**: approves off-site removal requests.
- **System Owner / Security Reviewer**: performs the post-maintenance record review and provides verification sign-off.
- **Maintenance Provider / Technician**: completes the maintenance details, identifies removed/replaced components, and attaches sanitisation evidence where required.

###### Acceptance criteria
- Off-site removal requests cannot be submitted or closed without approval from the AO or the system Security Officer.
- Work orders include all MA-02 ODP.03 record fields (date/time, description, personnel names, escort name if applicable, and removed/replaced component/equipment identifiers).
- For any off-site removed component/media that contains stored information, the work order includes sanitisation evidence covering stored data and encryption keys, including configuration backups and logs, aligned to NIST Special Publication 800-88.
- Remote maintenance activities are linked to session records and can be traced to the responsible individuals.
- Work orders cannot be closed without post-maintenance security verification evidence and a documented review sign-off.

###### Actions Required for Compliance

- [ ] Create an information technology service management (ITSM) work-order template for controlled maintenance. The template must include mandatory fields for: the date and time, a description of the maintenance, the names of the personnel involved, the escort name (if applicable), and the identifiers of any components or equipment that were removed or replaced.
- [ ] Implement an “off-site removal” workflow flag that sends every request to remove something from organisational facilities to the Authorising Officer (AO) and the system Security Officer for approval.
- [ ] Set up rules so that any off-site handover of storage or media must include a sanitisation record that meets **NIST Special Publication 800-88** requirements. This record must cover the stored data and the encryption keys, including configuration backups and logs.
- [ ] Link remote maintenance session details to the relevant work-order record, including the session start and end times and the remote operator’s identity and a summary of actions taken (where this information is available).
- [ ] Add a post-maintenance security verification checklist for each component type, and require supporting evidence to be attached before the work order can be closed.
- [ ] Require a second person to review and formally approve the records to confirm they are complete and that any security-relevant functions that may have been affected were checked and verified.


---

#### MA-2.2 — Automated Maintenance Activities (Enhancement)

This requirement is about making sure all system maintenance, repairs, and replacements are planned, carried out in a controlled way, and fully recorded from start to finish. Without this, important work could be missed, done at the wrong time, or carried out without clear evidence of what changed—leaving the organisation unable to prove what was done and when, and making it harder to spot problems or repeat safe fixes.

To meet this expectation, the organisation must use automated scheduling to plan every maintenance, repair, and replacement activity within agreed maintenance windows, and use automated tools to apply updates and carry out controlled repairs. It must also automatically create maintenance records from the maintenance requests and change logs, keeping them up to date, accurate, and complete, and showing the status of each item as requested, scheduled, in progress, and completed.

##### Automated maintenance lifecycle with ITSM scheduling and CMDB-backed records

- Category: Software
- Priority: Critical

###### WHAT
Put in place automated mechanisms that (1) plan maintenance, repairs, and replacements using the maintenance time windows defined in IT service management (ITSM), (2) carry out patching and repairs in a controlled way using configuration management automation, and (3) automatically create and keep maintenance records up to date using ITSM ticket activity (from start to finish) and configuration database (CMDB) and configuration change logs.

###### WHY (control requirement)
The MA-2(2) enhancement guidance requires automated mechanisms to manage and control system maintenance programmes and activities so that maintenance records are **on time, correct, complete, and consistent**. This approach ensures every maintenance action is planned, carried out using controlled automation, and recorded from **requested → scheduled → in progress → completed**.

###### HOW (specific steps/approach)
1. **Set up maintenance request types and required information in ITSM** (for example: maintenance, repair, replacement). Each request must include: the affected configuration item (CI) or asset identifiers, the environment (production/test/disaster recovery), the risk level, the required maintenance time window, whether downtime is needed, the rollback or contingency reference, and the security impact classification.
2. **Create and enforce scheduled maintenance time windows in ITSM** (fixed time periods, including blackout periods). Set workflow rules so that any maintenance/repair/replacement that requires downtime must reference a valid window, and block any attempt to run it outside that window.
3. **Link ITSM to the CMDB/asset inventory** so each ticket is matched to the correct, authoritative CIs (using asset tags/serial numbers and environment identifiers). Make sure the workflow checks that the CI exists and that the environment matches, to prevent mismatches over time.
4. **Automate the controlled work using configuration management** (for example, Ansible). Start automation only when the ITSM ticket moves to **approved/scheduled**. Use automation safeguards (policy-as-code) to ensure only approved patch baselines are used, required pre-checks are completed (such as backups/health checks), and the size of the change stays within limits.
5. **Record results and update status automatically**: when automation starts and finishes, update the ITSM maintenance record to **in progress** and then **completed** (or **failed/aborted** with a reason). Do not allow closure until supporting evidence is attached (for example, job/run identifiers, logs, and validation results).
6. **Automatically create and keep maintenance records updated** by matching ITSM ticket activity (requested/scheduled/in progress/completed) with CMDB and configuration change logs (what changed, when, and which automation run carried it out). Keep refreshing the record so it is **up to date** at the time of assessment.

###### WHO (role responsible)
- **ITSM Process Owner / Change Manager**: defines request types, required fields, and rules for managing maintenance windows.
- **Configuration Management Engineer**: builds Ansible playbooks, safeguards, and evidence capture.
- **CMDB/Asset Data Steward**: maintains CI mappings and ensures the asset-to-CI relationships are authoritative.
- **Security/Compliance Lead**: checks that records are ready for audit and that automation safeguards match organisational security standards.

###### Acceptance criteria
- For each maintenance/repair/replacement activity carried out through the workflow, the system produces a maintenance record showing **requested, scheduled, in progress, and completed** (or failure) statuses with timestamps.
- Maintenance records are **on time** (created/updated at each stage of the ticket lifecycle), **correct** (CI mapping validated against the CMDB), and **complete** (no missing actions or outdated states at the time of assessment).
- Controlled patching and repairs are triggered only from ITSM when a valid maintenance time window and required approvals are in place.
- Supporting evidence is attached automatically (automation run identifiers/logs/validation results), and closure is blocked until evidence requirements are met.

###### Actions Required for Compliance

- [ ] Set up IT service management (ITSM) processes for maintenance, repairs, and replacements so that they require the following details: configuration item (CI) or asset, environment, risk tier, the time window needed, and a rollback reference.
- [ ] Set up planned maintenance time slots in IT service management (ITSM) and apply workflow rules that prevent maintenance work from being carried out outside the approved time slots.
- [ ] Link information technology service management (ITSM) tickets to the configuration management database (CMDB) so each ticket is connected to the correct, official configuration items (CIs) and checks that environment and asset identifiers are valid.
- [ ] Set up configuration management automation (for example, Ansible) so it runs only when the information technology service management (ITSM) status changes to an approved or scheduled state. The automation must apply only the approved patch standards (patch baselines) and run required checks before patching.
- [ ] Automate the creation of maintenance records and the updating of their status using information from IT service management (ITSM) lifecycle events and the configuration management database (CMDB) and configuration change logs (requested, scheduled, in progress, completed).
- [ ] Require automatic collection of proof (automation run identifiers, logs, and validation results) and do not allow the item to be closed until the evidence has been attached.


---

### MA-3 — Maintenance Tools (Control)

This requirement is about ensuring that only approved maintenance tools are used when fixing or diagnosing systems, and that their use is monitored. Without this, staff could use the wrong tool, or a harmful tool could be introduced to a device or downloaded, allowing malicious software to enter your organisation’s systems during routine repairs.

To meet this expectation, the organisation must create a clear, documented process for approving maintenance tools (including software, hardware devices, and firmware). It must assign specific named people or teams to approve tools, control how they are used, and monitor their use. The organisation must keep an up-to-date list of approved tools and make sure maintenance work uses only tools on that list, with evidence showing they were approved and what they are allowed to be used for.

The organisation must also review all previously approved tools every 90 days and remove approval for any that are outdated, no longer supported, no longer relevant, or no longer used.

##### Approved maintenance tool allowlist with 90-day recertification

- Category: Manual
- Priority: Critical

###### WHAT
Set up an official, version-controlled list (allowlist) of approved maintenance tools (hardware, software, and firmware). Only allow maintenance work to use tools from this list, and record tool use against the approved entry. Review (recertify) the allowlist at least every **90 days** and remove approval for tools that are outdated, no longer supported, not relevant, or no longer used.

###### WHY (control requirement)
MA-3 requires organisations to **approve, control, monitor, and review maintenance tools** used for diagnostic and repair work on organisational systems. This includes keeping an approval record and doing a **regular review** to remove approval for tools that are no longer appropriate. Maintenance tools can introduce malicious code or create unwanted routes into systems, so the approved tool set must be controlled and monitored.

###### HOW (specific approach)
1. **Create a maintenance tool catalogue (official list)** covering every maintenance tool used for diagnostics and repairs. Include:
   - tool identity (name and version)
   - tool type (diagnostic or repair)
   - vendor or source
   - cryptographic hash or signature where feasible
   - **scope** (which authorised systems, environments, and maintenance use-cases the tool is allowed for)
2. **Set up and document an approval process** in the organisation’s change or ticketing system:
   - the maintenance team submits a tool request
   - security reviews the risk (for example, whether the tool can scan, capture data, stay installed, or move code)
   - an authorised approver grants approval
   - record the decision and supporting evidence (ticket ID, approver, date, scope, and expiry/recertification date) against the catalogue entry
3. **Apply the allowlist at the point of use** for maintenance access routes used by staff (for example, maintenance jump hosts/workstations, remote administration consoles, controlled maintenance virtual desktop infrastructure):
   - only approved tool binaries/scripts/packages can be installed from an internal repository
   - execution is limited to approved tool identities (hash/signature or managed package IDs) and only for authorised maintenance roles
   - maintenance sessions must be linked to an approved work order/ticket reference
4. **Set up monitoring and keep review evidence**:
   - centralise logs for maintenance session start and stop, operator identity, target system(s), and the tool identity used
   - raise alerts for:
     - use of a tool that is not on the allowlist
     - tool use without a matching approved ticket/work order reference
     - tool use against systems outside the approved scope
5. **Run a 90-day recertification process**:
   - every 90 days, review each approved tool’s continued relevance, support status, and actual usage
   - remove approval (and revoke permission to execute/install) for tools that are outdated, unsupported, irrelevant, or no longer used
   - record the recertification result and evidence in the catalogue

###### WHO (roles responsible)
- **Maintenance Operations Lead**: maintains the tool catalogue entries and submits tool requests.
- **Information Security (or Security Governance)**: performs the risk review and confirms approvals are appropriate.
- **Authorised Approver (as defined by the organisation)**: grants or removes approval and signs off recertification.
- **Platform/IT/Operational Technology (where applicable)**: implements allowlist enforcement and logging.
- **Security Information and Event Management (SIEM) / Monitoring Owner**: ensures alerts and evidence retention support auditability.

###### Acceptance criteria
- There is an official maintenance tool catalogue that includes tool identity/version and scope for every maintenance tool used for diagnostics and repairs.
- Every approved tool has recorded approval evidence (approver, date, scope, and linkage to the ticket/work order).
- Maintenance access routes enforce that only allowlisted tool identities can be installed and executed, and tool use is logged with the operator and target system.
- Alerts are generated for non-allowlisted tool execution and for tool use without a matching approved ticket/work order reference.
- The approved tool set is reviewed at least every **90 days**. Tools removed from the list are no longer able to be executed or installed, and recertification outcomes are recorded.

###### Actions Required for Compliance

- [ ] Create and keep up to date an official list of maintenance tools, including each tool’s identity and version, and the specific scope they are authorised to cover (systems, environments, and use cases).
- [ ] Set up a documented approval process in the change or ticketing system, with specific named approvers and saved proof of approval (ticket ID, approver name, date, and scope).
- [ ] Put controls in place for access to controlled maintenance routes so that only approved tool identities can be installed and run, and only when linked to authorised work orders.
- [ ] Set up central logging and security information and event management (SIEM) to track maintenance session activity and the identity of the tools used. Create alerts when tools are not on the approved list (allowlist) or when actions target systems outside the agreed scope.
- [ ] Complete a 90-day review to re-check the approved tool catalogue. Remove approval and take away permission to run and install tools that are outdated, no longer supported, irrelevant, or no longer used.
- [ ] Keep records of approvals and re-checks so audits can be completed, and confirm that any tools that have been withdrawn can no longer be used.


---

#### MA-3.1 — Inspect Tools (Enhancement)

This requirement is about making sure the tools used by maintenance staff are trustworthy before they are used, whether they are brought onto the site or downloaded from a supplier. Without this, someone could accidentally (or deliberately) introduce a tool that has been changed in the wrong way, changed without permission, or secretly contains harmful software. That could then be used to disrupt operations, steal information, or cause safety and financial damage.

To meet this expectation, the organisation must set clear rules and step-by-step procedures for checking every maintenance tool before use. This includes checks for unauthorised or improper changes and checks for harmful software. The organisation must also keep a record showing what was checked, when it was checked, and the result.

If any tool fails these checks, the organisation must treat it as an incident, follow its incident-handling process, record what happened, and make sure the tool is dealt with appropriately so it is not used again until it has been cleared.

##### Quarantine and verify maintenance tools before use

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled “maintenance tool intake” process so that every maintenance tool used by maintenance staff—whether it is brought into the site or downloaded from a supplier—is checked before use for (1) improper or unauthorised changes and (2) malicious software. Any tool that fails the check is quarantined or rejected and dealt with as an incident.

###### WHY (control requirement)
MA-3(1) Enhancement requires organisations to **inspect maintenance tools** for **improper or unauthorised changes** and to detect **malicious software**, with any failures handled in line with **incident handling policies and procedures**. The guidance specifically includes tools **brought into the site** and tools **downloaded from a supplier website**.

###### HOW (specific approach)
1. **Define what tools are in scope and when they must be checked**: keep an official list of maintenance tool types (for example, supplier diagnostic utilities, firmware updaters, scripts, installers, USB media). Require inspection **before first use** in any in-scope production or test environment.
2. **Route every tool entry through a staging/quarantine workflow**:
   - **For brought-in media/tools**: register them at a controlled intake point (for example, an inspection workstation or managed intake service) before connecting them to any in-scope network.
   - **For supplier downloads**: only download through approved routes (for example, a managed repository or an authenticated supplier portal). Then submit the downloaded package into the same intake workflow.
3. **Carry out two checks on every tool**:
   - **Improper/unauthorised change check**: confirm the tool’s expected integrity using supplier signatures or checksums where available. If not available, compare it against an approved baseline (a controlled list of expected checksums/files) and flag any differences.
   - **Malicious software check**: scan the tool contents for malicious software (for example, executable files, scripts, installers, archives, and macros where applicable). Where possible, use a sandbox or static analysis for installers.
4. **Only allow use after passing both checks, with recorded evidence**: release the tool for maintenance work only after it passes both checks. Keep inspection evidence including the tool identifier (asset tag/serial number/version/package name), source (brought-in vs supplier), date and time, what checks were performed, the results, and any scan or report identifiers.
5. **Treat failures as incidents**: if a tool fails either check, start the organisation’s incident handling process, quarantine the tool (remove it from the maintenance workflow), and stop it being used again until security clears it.
6. **Make responsibilities operational**: assign intake and inspection execution to maintenance tooling administrators and IT/operational technology security operations, and require information security oversight and approval for release decisions.

###### WHO
- **Maintenance tooling administrator / IT–operational technology (IT-OT) support lead**: runs the intake workflow and performs or coordinates the inspections.
- **Information Security (or security operations centre / incident response team)**: provides oversight, approves release decisions for borderline cases, and leads incident handling for failures.
- **Maintenance staff**: submit tools for inspection and use only tools that have been released or cleared after quarantine.

###### Acceptance criteria
- **100%** of maintenance tools used in in-scope environments are processed through the intake workflow **before first use**.
- For every released tool, inspection records exist showing both: (a) verification of improper/unauthorised change checks and (b) malicious software scan results.
- Any tool that fails either check is quarantined or rejected, and an incident is raised and handled in line with the organisation’s incident handling procedures.
- Audit sampling (for example, the last 90 days) shows inspection evidence is complete and traceable to the tool used (identifier/version/package).

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date list of all maintenance tools that are in scope, including both tools supplied by others and tools downloaded from vendors.
- [ ] Set up a controlled intake and staging process that prevents tools from connecting to the in-scope environments until the inspection is complete.
- [ ] Set up integrity checks using vendor-provided signatures or hashes where available and approved baselines where they are not.
- [ ] Enable malware scanning (and, where feasible, automated testing in a safe environment and static code analysis) for all tool packages, archives, scripts, and installers.
- [ ] Record inspection evidence for every released tool, including the tool identifier, source, date and time, checks performed, results, and scan or report identifiers.
- [ ] Link inspection failures to the organisation’s incident management process, and quarantine or reject the tool until security clearance is granted.


---

#### MA-3.2 — Inspect Media (Enhancement)

This requirement is about making sure any removable or downloaded items used to fix, test, or maintain a system are checked for harmful software before they are used. Without this, a virus or other malicious code could be brought in on a memory stick, software installer, diagnostic package, or even the files that come with a maintenance tool, and then run during maintenance—potentially causing disruption, data loss, or unauthorised access.

To meet this expectation, the organisation must have a clear, documented process for checking maintenance, diagnostic, and test media for malicious code. This includes the maintenance tools themselves and any related documentation, and it must use an approved checking method. Staff responsible for maintenance must follow this process every time and keep evidence in maintenance records showing the check was completed before use.

If malicious code is found, it must be treated as an incident and handled according to the organisation’s incident response procedures. The result must be recorded and kept.

##### Media inspection airlock with scan evidence before maintenance use

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled “media inspection and release” process for any maintenance, diagnostic, or test media (for example: USB drives, downloaded installers/packages, firmware bundles, and diagnostic tools). The media must be checked for malicious code **before** it is used in the system. If malicious code is found, treat it as an incident in line with the organisation’s incident handling procedures.

###### WHY (control requirement)
MA-3(2) enhancement requires: **“Check media containing diagnostic and test programs for malicious code before the media are used in the system.”** The guidance also requires that if malicious code is found, the incident is handled consistently with the organisation’s incident handling policies and procedures.

###### HOW (specific steps/approach)
1. **Create and maintain an auditable media inspection workflow** with clear checkpoints: *receive/import → scan/inspect → record evidence → quarantine/reject or release → only then connect/use*.
2. **Use an approved inspection method for all relevant media types:**
   - For removable media: scan the full contents (at file level) using approved on-demand/offline scanning where feasible.
   - For downloaded maintenance/diagnostic packages: treat downloads as “media” and scan the package contents before running them.
   - For suspicious files (for example, executables or scripts): carry out extra checks (for example, sandbox/detonation where available) before release.
3. **Record and store inspection evidence before any release**, in the maintenance work order/ticket:
   - media identifier (for example, serial number or hash where feasible),
   - list of files/artifacts scanned,
   - scanning method/tool and version, and the scan result,
   - date/time and operator,
   - decision outcome (*released* / *quarantined* / *rejected*) and any approval reference.
4. **Apply workflow controls** so media cannot be marked “ready for use” unless the scan report and evidence record are attached.
5. **Link to incident handling**: if the scan indicates malicious code, route the ticket into the incident process automatically (for example: create an incident record, preserve evidence, quarantine the media, and stop release).

###### WHO (role responsible)
- **Information Security / Security Operations Centre (SOC)**: approve the scanning approach/tools and incident routing rules; review exceptions.
- **IT Operations / Maintenance Engineering**: carry out the workflow, provide media details, and ensure tickets include scan evidence.
- **Service Management (IT Service Management (ITSM)) Owner**: implement the workflow checkpoints and evidence requirements in the ticketing system.

###### Acceptance criteria
- For every use of maintenance/diagnostic/test media, there is a related ticket/work order that includes scan evidence recorded **before** the media is used.
- Media is not released/used unless the workflow has an attached scan report showing the recorded decision outcome.
- If malicious code is detected, the media is quarantined/rejected and an incident is created/handled in line with the organisation’s incident handling procedures.
- Inspection evidence can be retrieved for audit (operator, date/time, scanning tool/version, media identifier, scanned file list, and result).

###### Actions Required for Compliance

- [ ] Define and publish an auditable “media inspection and release” process, with a clear check that requires scanning before anything is used.
- [ ] Set up information technology service management (ITSM) and work-order templates so they must include: the media identifier, a list of scanned files, the scan tool and version, the date and time of the scan, the operator who performed it, and the scan decision outcome.
- [ ] Add approved malware scanning into the workflow, using on-demand or offline scanning where appropriate, so that scan results are attached before anything is released.
- [ ] Set up workflow checks so media cannot be marked “ready for use” unless there is an attached scan evidence record.
- [ ] Set up automatic routing to the incident response process when scans detect malicious code, including actions to quarantine or reject affected items.
- [ ] Test the full workflow from start to finish using realistic maintenance media, and confirm that audit evidence is recorded before the media is used.


---

#### MA-3.3 — Prevent Unauthorized Removal (Enhancement)

This requirement is about making sure maintenance equipment that could still contain your organisation’s information does not leave your site unless it has been properly checked or made safe. If it is not, a laptop, storage drive, or other maintenance device could be taken away and its stored information could be read by someone who should not have access. This could lead to data leaks, fraud, and regulatory and reputational damage.

To meet this expectation, the organisation must first define what counts as organisational information. It must then set out and follow a clear process every time maintenance equipment is due to be removed. Before removal, staff must either:

- check that the equipment contains no organisational information and record the result, or  
- securely clean the equipment so the data cannot be recovered, or  
- destroy it, or  
- keep it on site.

If removal is ever needed without checking or cleaning, the organisation must get an explicit written exemption from the Chief Information Security Officer and the Authorising Official for the affected system. This exemption must state that removal of the specific equipment is authorised. The organisation must also keep records of the checks, cleaning or destruction carried out, and any exemptions.

##### Maintenance equipment removal gate with sanitise/verify evidence

- Category: Software
- Priority: Critical

###### WHAT
Put in place a controlled “removal gate” so maintenance equipment that may contain organisational information cannot leave the facility unless one of the approved outcomes is completed and recorded: (1) verified to contain no organisational information, (2) securely cleaned (sanitised), (3) destroyed, (4) kept on-site, or (5) removed only with an explicit written exemption authorised by the Chief Information Security Officer (CISO) and the Authorising Official (AO) for the affected system.

###### WHY (control requirement)
NIST Special Publication (SP) 800-53 Media Access (MA)-3(3) (enhancement) requires stopping unauthorised removal of maintenance equipment that may contain organisational information. “Organisational information” includes information owned by the organisation and information provided to the organisation that it manages as an information steward. The guidance also expects that verification, sanitisation, destruction, or retention can be checked later through audit records, and that exemptions are handled in a clearly documented way.

###### HOW (specific steps/approach)
1. **Define scope and roles**: Keep an up-to-date list of maintenance equipment categories that may contain storage (for example: laptops, diagnostic tools, Universal Serial Bus (USB)/Secure Digital (SD) media, network testers with internal storage). Define the “people or roles who can approve removal” as **the CISO and the AO for the affected system**.
2. **Create an official equipment record**: For each equipment item, keep an asset ID, the type of storage/media it contains, and the relevant verification/sanitisation/cleaning profile.
3. **Apply the removal gate in the IT service management (ITSM) / ticketing process**: Configure the workflow so an asset cannot be marked “released” for off-site movement unless the operator selects exactly one allowed outcome (verify / sanitise / destroy / retain / exemption) and attaches the required proof.
4. **Verification path (when selected)**: Require standard, auditable checks appropriate to the equipment type (for example: a physical inspection checklist and an attestation that no storage is present; where relevant, checks for any leftover partitions, user accounts, credentials, or encryption keys). Save the completed checklist/attestation against the asset ID.
5. **Sanitisation/destruction path (when selected)**: Require sanitisation tools that generate verifiable records (for example: wipe/erase confirmation where supported) and/or destruction evidence (for example: a destruction certificate with a serial number and a chain-of-custody record). Save the evidence and tool output against the asset ID.
6. **Retention path (when selected)**: If the equipment is not verified and not sanitised/destroyed, force it to stay on-site by setting the workflow outcome to “retain on-site” and blocking release.
7. **Exemption path (when selected)**: Use an exemption request form that cannot be approved unless it has explicit written authorisation from **both** the CISO and the AO for the affected system. Record the exemption against the specific equipment item (asset ID) and the removal event.
8. **Audit readiness**: Produce an auditable report (asset ID, outcome chosen, date and time, references to evidence, and identities of exemption approvers) for periodic compliance checks.

###### WHO (role responsible)
- **CISO and AO (authorisation)**: Approve written exemptions for specific equipment removal.
- **ITSM / Asset Management owner**: Set up and maintain the removal gate workflow, asset records, and evidence requirements.
- **Maintenance / Infrastructure operations (performers)**: Carry out verification/sanitisation/destruction/retention steps and submit evidence.
- **Security assurance / compliance**: Review audit reports and the quality of evidence.

###### Acceptance criteria
- No maintenance equipment within scope can be released off-site without selecting one allowed outcome and attaching evidence.
- For “verify”, the workflow requires completion of the defined verification checklist/attestation, and the evidence is stored against the asset ID.
- For “sanitise” and “destroy”, the workflow requires verifiable wipe logs and/or destruction certificates/chain-of-custody evidence stored against the asset ID.
- For “retain”, the workflow blocks release and records the retention decision.
- For “exemption”, the workflow requires explicit written approval by both the CISO and the AO for the affected system, and records the exemption against the specific asset and removal event.
- An audit report can be produced showing the outcome, evidence, timestamps, and exemption approvers for all removal events.

###### Actions Required for Compliance

- [ ] Set out in policy which maintenance equipment categories are in scope because they may contain organisational information, and specify the required end results for handling them (check, sanitise, destroy, keep, or grant an exemption).
- [ ] Set up the IT service management (ITSM) and asset workflow so that an off-site release cannot be completed unless the user selects an approved outcome and attaches supporting evidence linked to the asset’s ID.
- [ ] Set up verification checklists and require signed or formally confirmed proof for the “verify” outcome. Store this proof for each asset and each time the asset is removed.
- [ ] Integrate sanitisation tools that produce verifiable records of each wipe or erase action, and require those records as evidence that the “sanitise” step has been completed.
- [ ] Set up evidence capture for destruction (using numbered certificates and a documented chain of custody) and make it mandatory when the outcome is “destroy”.
- [ ] Set up an exemption request process that needs explicit written approval from both the Chief Information Security Officer (CISO) and the Authorising Officer (AO) for the affected system, and records each exemption against the specific asset it applies to.
- [ ] Produce and review an auditable report of all removal gate events on a set schedule, including the outcome, references to the supporting evidence, the date and time, and the people who approved any exemptions.


---

#### MA-3.4 — Restricted Tool Use (Enhancement)

This expectation is about making sure only the right people can use the special tools used to maintain and fix your systems. If unauthorised staff could use these maintenance tools, they could accidentally cause outages or, worse, make changes that are difficult to detect—potentially leading to service disruption, fraud, or data loss.

To meet this expectation, your organisation must:
- Clearly define which tools are classed as maintenance tools.
- Document how each maintenance tool is to be used during maintenance.
- Keep an up-to-date list of the specific people authorised to use each tool.

You must also:
- Keep records every time a maintenance tool is used, including who used it and when.
- Keep maintenance records that link the work carried out to the specific tool used.

Finally, your documented plans and responsibilities must name who carries out maintenance and who oversees information security, and your procedures must include checks that prevent unauthorised use.

##### Privileged maintenance tool access via PAM with tool-specific authorisation

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled, identity-based way to access each maintenance tool used for maintenance work. Only formally authorised staff should be able to use each tool, and every time a tool is used must be recorded and traceable to an approved maintenance activity (for example, a work order or change record).

###### WHY (control requirement)
MA-3(4) (Restricted Tool Use) requires that maintenance tools are used only by authorised personnel. The guidance applies to systems used to carry out maintenance work. This approach enforces the restriction technically (not just by policy) and creates audit evidence that links tool use to the specific maintenance activity.

###### HOW (specific steps/approach)
1. **Define what counts as “maintenance tools”** for the maintenance activities covered by this application/system (for example: vendor or administrator consoles, privileged scripts, remote management sessions, diagnostic tools, privileged database consoles, break-glass accounts, and any tools that can change configuration or data during maintenance).
2. **Create and keep up to date a tool-to-user authorised list** (who is authorised to use each tool), including an approval reference, the valid time period (start/end), and a link to the maintenance activity/work order/change record.
3. **Use named access only**: remove shared accounts for maintenance tool access; require an individual identity for every maintenance tool session.
4. **Route maintenance tool access through privileged access management (PAM)** (or an equivalent privileged access gateway) so access is granted only when the requesting identity is on the authorised list for that specific tool and within the approved time period.
5. **Record sessions and actions where possible** (PAM session logs and command/session details) and send the logs to the organisation’s security information and event management (SIEM) or logging platform.
6. **Link tool use to maintenance records**: require the maintenance ticket/work order/change record identifier to be provided/associated when requesting access (or link it automatically using a correlation rule), and store this link in the maintenance record.
7. **Keep evidence for audit**: keep PAM/identity provider (IdP) logs and the maintenance-record linkage for the organisation’s required retention period, with safeguards to protect integrity (for example, write-once/immutable log storage).

###### WHO (role responsible)
- **Identity and access management (IAM)/privileged access management (PAM) Engineer**: implement PAM/privileged access workflows, session recording, and log forwarding.
- **Application/Infrastructure Maintenance Owner**: define which tools are in scope and ensure work orders include the required linkage identifier.
- **Information Security (or Security Governance)**: approve the authorised list process, confirm evidence requirements, and review authorisations on a regular basis.

###### Acceptance criteria
- Every maintenance tool access is controlled through PAM (or an equivalent privileged access control) and is blocked when the user/tool/time period is not authorised.
- Shared accounts for maintenance tools are removed (or clearly controlled and justified if outside scope).
- For every maintenance activity, there is an auditable record showing: **who** used **which** maintenance tool, **when**, **against which target system**, and **linked to an approved maintenance work order/change record**.
- PAM/IdP logs are sent to SIEM and kept for the required period using tamper-evident storage.
- Regular reviews confirm the authorised list is current and matches actual maintenance tool usage patterns.

###### Actions Required for Compliance

- [ ] Take an inventory of all maintenance tools used for maintenance activities across the application and system environments, and categorise them.
- [ ] Define and publish a tool-specific authorised register format that includes: tool name, identity, approval reference, validity dates, and the scope of what it covers.
- [ ] Set up individual (named) accounts for maintenance tools, and turn off shared accounts for those access routes.
- [ ] Set up privileged access management (PAM) so it only allows sessions when the user’s identity is listed in the authorised register for that specific tool and the request is made within the approved time window.
- [ ] Enable and centralise logging of maintenance tool sessions and commands, and send the logs to security information and event management (SIEM).
- [ ] Update the maintenance ticket and change request workflows to require a maintenance record identifier, so privileged access management (PAM) can capture and link it to the relevant activity.
- [ ] Set log storage and tamper-protection controls for privileged access management (PAM) and identity provider (IdP) evidence, and run an initial audit check to confirm that all tool actions can be traced.


---

#### MA-3.5 — Execution with Privilege (Enhancement)

This requirement is about closely monitoring special maintenance tools that can be used with higher access than normal users. That extra access could be misused to view or change sensitive information and systems. If these tool uses are not monitored and recorded, unauthorised activity could go unnoticed, mistakes could be difficult to investigate, and the organisation would struggle to show who did what, when, and why.

To meet this expectation, the organisation must:
- clearly define which maintenance tools count as “higher access”
- keep an up-to-date list of the specific people authorised to use each tool
- have written rules and step-by-step instructions for how each tool must be used

Every time an authorised person uses a higher-access maintenance tool, the organisation must record:
- the person’s name
- the time of use
- the tool used
- the stated purpose

The organisation must also keep maintenance records that can be linked back to these tool-use entries. The organisation must then review the records to confirm that only authorised use occurred and that each use matched the approved maintenance purpose.

##### Privileged maintenance tool monitoring with ticket-linked audit logs

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled way to run maintenance tools that require higher permissions, and continuously track and record every time they are used. Each record must include the user identity, date and time, the tool used, and the stated reason for the maintenance. These records must be linked to the approved maintenance work order/change ticket.

###### WHY (control requirement)
MA-3(5) enhancement requires the organisation to **monitor the use of maintenance tools that run with higher permissions**. This is to make sure privileged maintenance activity can be traced to a specific person, reviewed, and investigated if it is misused.

###### HOW (specific steps/approach)
1. **Create and maintain a list of approved privileged maintenance tools (allow-list):** Define which tools count as “maintenance tools that run with higher permissions” (for example: tools that run as local/system, elevated permissions, privileged remote session utilities, database administration tools, endpoint remediation agents). Give each tool a stable identifier.
2. **Make privileged tool use go through an identity-checked access route:** Limit use of privileged tools to approved jump hosts/admin workstations or a managed privileged access service (where possible). Make sure the tool runs under a named user identity (no shared accounts) and that the execution is captured by the execution platform (for example, session management or privileged access management audit logs).
3. **Capture the maintenance reason at the time of execution:** Link the privileged execution process to the organisation’s ticketing/change system so the operator must enter or confirm an approved work order/change ID and maintenance purpose before the privileged tool can run. Save the entered purpose and ticket reference with the execution record.
4. **Log and centralise privileged tool usage events:** Collect audit records from the point of execution (for example, session management, privileged access management, endpoint audit, or command-line auditing where applicable) and send them into the security information and event management (SIEM) system/log platform. Ensure each record includes: user identity, date and time, tool identifier, and the maintenance purpose/ticket reference.
5. **Link execution logs to maintenance records for traceability:** Use correlation (automation or a SIEM rule) to connect each privileged tool execution record to the matching approved ticket/work order (including environment/asset identifiers where available).
6. **Carry out regular reviews and raise alerts:** Run scheduled reviews (for example, monthly or quarterly based on risk) of all privileged tool usage against the allow-list and authorised users, and check that the ticket/purpose matches. Set up real-time alerts for: privileged tool use without a valid ticket reference, use by non-authorised identities, or use outside approved maintenance windows (if these windows are tracked).

###### WHO
- **Security Engineering / Identity and Access Management (IAM) and Privileged Access Management (PAM) Owner:** Own the privileged tool allow-list, identity enforcement, and logging requirements.
- **Infrastructure/Platform Engineering:** Build the controlled execution route (jump host/PAM/session tooling) and integrate ticket-to-execution.
- **Security Operations Centre (SOC) / Security Operations:** Own alerting, monitoring, and the periodic review process.
- **Change Management Owner:** Ensure tickets/work orders include the required fields (purpose, environment, assets) so they can be linked.

###### Acceptance criteria
- A documented allow-list exists for privileged maintenance tools, and only tools on the allow-list can be run via the controlled privileged execution route.
- Every privileged tool execution produces an audit record containing: **named user identity, date and time, tool identifier, and maintenance purpose/ticket reference**.
- Execution records are **able to be linked** to the corresponding approved maintenance work order/change ticket (evidence: correlation output or a stored reference in the logs).
- Monitoring is in place and alerts are triggered for missing/invalid ticket references and non-authorised identities.
- Evidence of periodic review is produced showing authorised use and correct purpose alignment for the review period.

###### Actions Required for Compliance

- [ ] Create and get approval for an approved list (allow-list) of privileged maintenance tools, using unique tool identifiers and a clear classification of the level of execution privilege each tool has.
- [ ] Limit use of privileged tools to an approved, identity-checked route (such as a jump host or administrator workstation, or a privileged access management session manager), using named user accounts.
- [ ] Integrate the privileged access workflow with the change and work-order system so that a valid ticket reference is required and the maintenance purpose is recorded.
- [ ] Set up audit logging at the point where the action is carried out to record the user, the time and date, the tool used, and the ticket or purpose, then send it to the security information and event management (SIEM) system.
- [ ] Set up a link between logs and work tickets so that every use of a privileged tool can be traced back to the approved maintenance record.
- [ ] Set up alerts and detection rules for privileged tool use when there is no valid ticket reference or when the user is not an authorised identity.
- [ ] Carry out and record periodic reviews of privileged tool execution records to confirm they are authorised and used for the intended purpose.


---

#### MA-3.6 — Software Updates and Patches (Enhancement)

This requirement is about making sure the tools your organisation uses to maintain and manage systems are kept up to date, with the latest fixes and security updates installed. If these maintenance tools use outdated or unpatched software, they can be an easy way for attackers to gain access or take advantage of weaknesses, which can cause major disruption and expensive recovery.

To meet this expectation, the organisation must clearly set out which maintenance tools are included, create and follow step-by-step instructions for checking whether each tool is up to date and applying updates when needed, and confirm that the tool documentation matches what is actually installed.

The organisation must also ensure that only authorised people carry out these checks and updates, assign named responsibility for the work, and keep reliable records showing who carried out the work, what was checked, what updates were applied (or that none were needed), and the result each time. This allows the organisation to demonstrate that systems remain current.

##### Automate maintenance-tool patch compliance with auditable evidence

- Category: Software
- Priority: Critical

###### WHAT must be done
Maintain a process that can be checked by auditors and repeated reliably to inspect every maintenance tool in scope, and ensure each one is running the latest vendor-approved software and security updates.

###### WHY (control requirement)
MA-3(6) requires that maintenance tools are inspected to confirm the latest software updates and security patches are installed. Maintenance tools that are outdated or unpatched can be used as an entry point for attackers and can create significant security weaknesses.

###### HOW (specific steps/approach)
1. **Define and maintain an authoritative list (scope) of maintenance tools** (for example, remote administration consoles, deployment and automation agents, configuration management tools, and vendor support utilities). Include each tool’s owner, where it is installed, and the specific documentation/runbook set that matches each tool version.
2. **Set a patch/update baseline for each tool** (the latest vendor security release, or an approved baseline set). Define **exceptions** with an expiry date and compensating controls.
3. **Put in place an inspection method** that, on a planned schedule, gathers each tool’s current version and patch level (for example, using endpoint management inventory, configuration management records, or controlled remote checks) and compares it to the baseline.
4. **Use a controlled method to apply updates** (for example, a software distribution pipeline or a configuration management deployment). Include checks before updating (compatibility and dependencies), use controlled change windows, and record proof of what happened before and after (tool version, patch level, and the deployment result).
5. **Check that documentation matches reality** by requiring each tool’s inventory record to point to the exact vendor documentation/runbook version that corresponds to the installed tool version and patch state. Highlight any mismatches for review.
6. **Record responsibility and results** by linking every inspection and update action to an authorised person (or service account). Capture the date and time, whether it was compliant or not, and the evidence (inspection output and update logs) for audit.

###### WHO (role responsible)
- **IT/Operational Technology (OT) Platform Engineering Lead / Tooling Owner**: owns the tool scope and baselines.
- **Configuration Management / Patch Management Team**: carries out inspection and update automation.
- **Security Compliance / Governance, Risk and Compliance (GRC)**: checks that the evidence is sufficient and that exceptions are governed properly.
- **Privileged Access Administrator (PAM) / Identity and Access Management (IAM) Admin**: ensures only authorised users can run the maintenance-tool patch/update processes.

###### Acceptance criteria
- Every maintenance tool in scope has an inventory record showing its current version/patch level, the date it was last inspected, and linked evidence.
- Inspection results are produced on the agreed schedule and clearly state whether each tool matches the approved baseline.
- Any tool that is not compliant triggers tickets/workflows to bring it up to the approved patch level within the agreed timeframes (or an exception is recorded with an expiry date and compensating controls).
- For every update, evidence is available showing the tool’s version/patch level before and after, and the operator/service account that made the change.
- The documentation/runbook references in the inventory match the installed tool version/patch state, or any differences are explicitly tracked and resolved.

###### Actions Required for Compliance

- [ ] Create and get approval for an official list of all in-scope maintenance tools, including who is responsible for each one, where they are installed, and the related documentation and runbooks.
- [ ] Set a separate patch baseline for each tool (either the latest vendor security release or an approved baseline set), and set exception rules with expiry dates.
- [ ] Set up an automated check that collects each tool’s current version and patch level, then compares it against the agreed baseline.
- [ ] Set up a controlled update process (software distribution and configuration management) that installs patches only during approved change windows, and keeps records showing the system state before and after the update.
- [ ] Use privileged access management (PAM) and identity and access management (IAM) roles, along with service account controls, to ensure only authorised users and systems can run inspection and update workflows.
- [ ] Store inspection and update evidence (inspection results, deployment records, and the operator’s identity) in an audit-ready file, and review any queues of non-compliance.


---

### MA-4 — Nonlocal Maintenance (Control)

This expectation is about ensuring that any remote help or troubleshooting carried out on your systems is tightly controlled, properly authorised, and fully recorded from start to finish. Without this, someone could use remote access to make unauthorised changes, run hidden checks, or leave access open after the work is finished—raising the risk of fraud, disruption, or data loss.

The organisation must approve every remote maintenance and diagnostic activity before it starts and must actively monitor it while it is happening. Only tools that the organisation has explicitly allowed may be used, and these approved tools and conditions must be written into the system’s security plan.

Starting any remote maintenance session must require strong identity checks using more than one proof of who the person is, and these checks must not be reusable. The organisation must keep clear records of who did what, when, and which tools were used. As soon as the maintenance is completed, it must immediately end both the remote session and the underlying network connection.

##### Approved nonlocal maintenance via ZTNA with MFA and auto teardown

- Category: Software
- Priority: Critical

###### WHAT
Set up remote (network-based) maintenance and diagnostic access using a controlled access route (for example, zero trust network access (ZTNA) or a jump service). This route must allow only **pre-approved** maintenance sessions. Each session must be set up using **strong, replay-resistant multi-factor authentication**. The session must be **actively monitored**, and the activity must be **recorded** so it can be linked to audit evidence. When maintenance finishes, the system must **automatically end** both the session and the underlying network connection immediately.

###### WHY (control requirement)
MA-4 requires that remote maintenance and diagnostic work is carried out by people who connect over a network, with authentication meeting the requirements of identity assurance (IA-2). It also requires **strong authentication** (replay-resistant and multi-factor) and that enforcement is supported by other controls. This approach directly meets the MA-4 expectations for remote maintenance: approval, strong authentication, monitoring, recordkeeping, and termination.

###### HOW (specific steps/approach)
1. **Define maintenance access as a separate, time-limited rule** in the identity provider (IdP) and ZTNA/jump service. Limit it to the: target system(s), allowed connection methods (for example, secure shell (SSH)/remote desktop protocol (RDP)), and the maximum session length.
2. **Only allow session creation when there is an approved work order/change ticket**: link ticket/work-order approval to automatic setup of a time-limited access permission (policy-as-code). Deny access by default, and only allow it after approval.
3. **Use strong, replay-resistant multi-factor authentication for maintenance sessions**, using phishing-resistant methods (for example, FIDO2/passkeys or certificate-based authentication). Require extra (“step-up”) authentication for maintenance even if the user already has an active corporate session.
4. **Send all remote maintenance traffic through the controlled access gateway/jump service**, so that session start/stop, identity, device status (if available), destination, and connection details are visible.
5. **Actively monitor and record**: send ZTNA/jump monitoring data and identity provider session events to the security information and event management (SIEM) system, so logs can be matched to the work order/change ticket ID (where possible, include the ticket ID in the session details). Keep audit records of who carried out maintenance, when, which system was accessed, and what tools were used.
6. **Automatically terminate**: when maintenance is marked complete (ticket closed/explicit “maintenance complete” event), revoke the ZTNA application/session and close the tunnel/connection. Confirm termination by checking that both the session end and the network path shutdown are recorded in the logs.
7. **Document the allowed tools and conditions** in the system security plan by configuring the gateway/jump host to enforce an allow-list of maintenance tools/commands where technically possible, and ensure the security plan reflects the permitted tools and conditions for remote maintenance.

###### WHO
- **Security Architect / identity and access management (IAM) Lead**: designs IdP and ZTNA maintenance rules and multi-factor authentication requirements.
- **Privileged Access Management (PAM) / Platform Engineering**: builds the ticket-to-access automation, gateway routing, and session end (lifecycle) shutdown.
- **Security Operations Centre (SOC) / Monitoring Team**: sets up SIEM data intake, alerts, and monitoring views for maintenance sessions.
- **System Owner / Change Manager**: ensures work orders/tickets are used and marked complete to trigger shutdown.

###### Acceptance criteria
- A remote maintenance session cannot be started unless there is an **approved** work order/change ticket.
- Maintenance sessions require **phishing-resistant, replay-resistant multi-factor authentication** (for example, FIDO2/certificate) and step-up authentication.
- All maintenance sessions are **routed through** the controlled access gateway/jump/ZTNA path and are **actively monitored**.
- Audit evidence exists showing: **user identity, date/time, target system, session start/stop, and linkage to the work order/ticket ID**.
- When the ticket is closed or “maintenance complete” is triggered, the system shows **automatic termination** of both the session and the underlying network connection (confirmed in logs).

###### Actions Required for Compliance

- [ ] Create a dedicated identity provider (IdP) and zero trust network access (ZTNA) maintenance access policy for specific systems and protocols, with a maximum session length.
- [ ] Link work-order and change approvals to automated, time-limited access permissions for non-local maintenance staff.
- [ ] Set up maintenance sessions so that, before the session starts, users must complete step-up, phishing-resistant, replay-resistant multi-factor authentication (MFA) (for example, FIDO2 or a certificate).
- [ ] Send all non-local maintenance traffic through a controlled gateway, jump host, or zero trust network access (ZTNA) path, and collect information about each maintenance session from start to finish (session lifecycle telemetry).
- [ ] Turn on security information and event management (SIEM) logging for identity provider (IdP) session events and for gateway/zero trust network access (ZTNA) session start and stop events, and link the resulting logs to the work order/ticket ID.
- [ ] Set up automatic closing of sessions and tunnels when a ticket is closed or when a “maintenance complete” event is explicitly recorded.
- [ ] Update the system security plan to record which remote maintenance tools and conditions are allowed, as enforced by the gateway.


---

#### MA-4.1 — Logging and Review (Enhancement)

This requirement is about ensuring that, every time someone connects from outside the organisation to carry out remote maintenance or to run diagnostics, the organisation records a clear account of what happened and then checks those records for anything unusual. Without this, a legitimate maintenance or troubleshooting session could be used to hide unauthorised access, unexpected changes, or suspicious activity—problems that might not be noticed until real damage has been done.

To meet this requirement, the organisation must capture the complete set of required activity records for every remote maintenance session and every diagnostic session, and then regularly review those records to identify unexpected behaviour, such as actions outside the agreed purpose or activity at unusual times. These reviews must be carried out by the people responsible for maintenance and by those responsible for information protection and audit/review. The organisation must keep evidence showing that each session was checked and that any concerns were followed up appropriately.

##### Brokered remote sessions with AU-2a logging and review evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled “session broker” for all **non-local maintenance** and **diagnostic** remote access. This ensures every remote session generates the organisation-defined **AU-2a audit events**, and that those audit records are **reviewed**, with documented results and any required follow-up.

###### WHY (control requirement)
The MA-4(1) (Logging and Review) enhancement requires that audit logging for **non-local maintenance** is enforced by **AU-2**, using the specific audit event types defined in **AU-2a**. The organisation’s requirements for this enhancement state that **all AU-2a nonlocal maintenance session audit events** and **all AU-2a diagnostic session audit events** must be logged, and that **diagnostic and nonlocal maintenance session audit events** must be reviewed.

###### HOW (specific steps/approach)
1. **Route remote access through the broker**: Identify the approved remote maintenance/diagnostic access routes (for example, vendor remote support, administrator “jump” hosts, and remote troubleshooting tools). Then enforce that access must go through the session broker, blocking direct routes where possible.
2. **Link each session to the right scope and person**: Require authenticated user identity (integrated with the organisation’s enterprise identity provider) and require an approved maintenance/diagnostic ticket/reference, the target system/service, and an allowed time window to be provided and checked before the session starts.
3. **Create AU-2a-aligned audit records**: Configure the broker to produce structured, tamper-evident audit records covering the full set of organisation-defined **AU-2a** event types for:
   - **Nonlocal maintenance sessions** (per `ma-04.01_odp.01`)
   - **Diagnostic sessions** (per `ma-04.01_odp.02`)
   At minimum, include the session start and end, checks for authorisation and scope, and any organisation-defined diagnostic/maintenance actions that map to **AU-2a**.
4. **Centralise and protect the logs**: Send the broker’s audit records to the central security information and event management (SIEM) / logging platform with integrity protections and retention periods aligned to organisational policy, so review evidence is suitable for audit.
5. **Run a documented review process**: Put in place a repeatable review process (for example, security operations centre (SOC) first-line triage plus security and audit oversight) that periodically checks diagnostic and nonlocal maintenance session audit records for unusual activity (for example, scope mismatches, actions outside the agreed time window, or unusual session length/frequency). Record review outcomes and any follow-up actions, linked back to the session and ticket/reference.

###### WHO (role responsible)
- **Security Engineering / Identity and Access Management (IAM) & Privileged Access team**: implement broker enforcement, identity linking, and audit record generation.
- **SOC / Security Operations**: carry out first-line review and investigate anomalies.
- **Information Security / Audit & Compliance**: set the review frequency, ensure evidence is captured, and confirm follow-up is completed.
- **Application/Infrastructure owners**: ensure the target systems/services are correctly included in the broker’s allowed scope.

###### Acceptance criteria
- All in-scope non-local maintenance and diagnostic remote sessions are broker-mediated, with no approved bypass routes remaining.
- For each session, the SIEM contains the complete set of organisation-defined **AU-2a nonlocal maintenance session audit events** and **AU-2a diagnostic session audit events** (as per `ma-04.01_odp.01` and `ma-04.01_odp.02`).
- Audit records are reviewed within the defined review schedule, with documented outcomes and evidence of follow-up for any anomalies.
- Review evidence can be traced to the specific session and the associated maintenance/diagnostic ticket/reference.

###### Actions Required for Compliance

- [ ] Identify and record all in-scope remote access routes used for non-local maintenance and diagnostics, and remove or disable any direct bypass routes.
- [ ] Set up the session broker so that a user must be signed in (authenticated) and their access ticket, allowed permissions (scope), and valid time window are checked and approved before the session starts.
- [ ] Match audit events created by the message broker to the organisation’s AU-2a event lists for non-local maintenance and diagnostic sessions
- [ ] Set up the broker to send audit event records to the organisation’s central security information and event management (SIEM) system, with protections to keep the records trustworthy and with storage periods suitable for audit evidence.
- [ ] Set up a review process (who reviews, how often, and how issues are escalated) that records the results of each review and links them to the relevant session or ticket references.
- [ ] Run a test set using realistic user sessions to confirm that all required AU-2a event types are covered, and review the proof (evidence) that is produced.


---

#### MA-4.3 — Comparable Security and Sanitization (Enhancement)

This requirement is about ensuring that when someone carries out remote maintenance or checks your equipment, they do not accidentally expose your information or introduce harmful software.

Without this, a remote technician could:
- access your systems from a less secure environment,
- handle a part in a way that leaves your confidential information behind, or
- introduce malware during the work, which could then be quietly connected back to your live systems.

To meet this requirement, the organisation must either:
- use a maintenance or diagnostic setup provided by the service provider that has security protections at least as strong as those on the equipment being serviced, and keep evidence of this; **or**
- remove the component before the remote work begins.

If the component is removed, it must be:
1. cleaned to remove organisational information,
2. checked after the service for potentially malicious software and cleaned again if needed, and
3. only then reconnected.

The organisation must document the process, assign responsible roles, ensure service provider agreements reflect this approach, and keep records showing the correct sequence of steps and the results.

##### Provider maintenance enclave with attested comparable security

- Category: Software
- Priority: Critical

###### WHAT
Set up a controlled “provider maintenance enclave” (or an equivalent provider-managed environment) for all non-local maintenance and diagnostic work. Make sure the security protections on the provider’s systems, diagnostic tools, and equipment are **at least as strong** as those on the system being serviced.

###### WHY (control requirement)
MA-4(3) (Comparable Security and Sanitization) requires that any maintenance or diagnostic activity done remotely uses systems, tools, and equipment with **comparable security capability** to the serviced system. If comparable security cannot be guaranteed, you must use the alternative sanitisation route: remove the component, sanitise organisational information, check for malicious software, and reconnect only after verification.

###### HOW (specific steps/approach)
1. **Define a “comparable security” baseline for each system type** (for example: server, workstation, network device, or cloud workload). Map this to your security baseline for the serviced systems. Include, at minimum: identity and authentication strength, privileged access controls, logging and auditing, endpoint and malware protections, secure configuration baselines, and network segmentation.
2. **Create an approval process for using the provider maintenance enclave**: providers must submit evidence (overall design, control mapping, configuration evidence, and security attestations) showing their maintenance enclave meets or exceeds the comparable-security baseline for the specific serviced system type.
3. **Use identity-first, least-privilege access for maintenance sessions** with named user accounts (no shared credentials), phishing-resistant multi-factor authentication (MFA), conditional access, and role-based authorisation limited to the maintenance task.
4. **Limit provider connectivity and tools** using zero trust network access (ZTNA) / secure access service edge (SASE) or an equivalent brokered access method. Use allowlisted destinations, restrict administrative tools, and apply network segmentation so provider activity cannot move freely into production beyond what is required.
5. **Provide session-level accountability and monitoring** for maintenance activities (for example, session recording where feasible, logging of commands and actions, and sending logs into a security information and event management (SIEM) system). Ensure logs show who did what, when, and from where.
6. **Control reconnection/enablement actions**: if maintenance requires temporary changes to security settings (for example, firewall rule changes, temporary enabling of credentials, or installing tools), require an internal approval step before the serviced system returns to its normal security configuration.
7. **Keep auditable records for each work order**: provider enclave approval reference, evidence of comparable security, maintenance work order details, session logs/records, and any post-maintenance security posture verification or approvals.

###### WHO
- **Information Security / Security Architecture Lead**: defines comparable-security baselines and approval criteria.
- **IT Operations / Service Management (ITSM) Owner**: ensures work orders reference the approved enclave and include the required evidence.
- **Privileged Access Management (PAM) / Identity Team**: sets up named accounts, multi-factor authentication (MFA) and conditional access, and least-privilege authorisation.
- **Security Operations Centre (SOC) / Monitoring Team**: ensures maintenance session logs are collected, retained, and reviewed in line with policy.
- **Third-Party Management / Procurement**: ensures provider contracts and service level agreements (SLAs) require enclave evidence, logging, and adherence to the comparable-security approach.

###### Acceptance criteria
- For each serviced system type, there is an approved comparable-security baseline mapping provider enclave controls to the serviced-system security baseline.
- Every provider maintenance or diagnostic engagement uses an **approved** maintenance enclave (or a documented exception route using the remove-and-sanitise approach) before any non-local access begins.
- Maintenance sessions use named accounts with phishing-resistant multi-factor authentication (MFA) and least-privilege authorisation.
- Session/accountability evidence (session logs/records and security information and event management (SIEM) ingestion) is available for audit for each work order.
- Any temporary security setting changes are followed by an internal approval and verification step before the system returns to normal operation.

###### Actions Required for Compliance

- [ ] Set security baseline standards that are comparable for each type of service system, and link (map) each one to the organisation’s overall security baseline.
- [ ] Set up an approval process that requires proof from the provider enclave before any non-local maintenance can start.
- [ ] Require named user accounts, use phishing-resistant multi-factor authentication (MFA), and apply least-privilege access for provider maintenance sessions
- [ ] Set up brokered or segmented access for provider maintenance connections (for example, zero trust network access (ZTNA) or secure access service edge (SASE) with approved destination addresses).
- [ ] Set up and centralise records of maintenance sessions, and send the event details to the security information and event management (SIEM) system so they are kept for audit purposes and future review.
- [ ] Add an information technology service management (ITSM) work-order checkpoint that points to the approved secure enclave and requires a security status check and approval after maintenance is completed.
- [ ] Keep auditable records for each work order, including the enclave approval reference, session evidence, and the approvals for reconnection and enablement.


---

#### MA-4.4 — Authentication and Separation of Maintenance Sessions (Enhancement)

This requirement is about ensuring that anyone connecting from outside the office to carry out system maintenance does so using a specially protected route that is clearly different from normal access. Without these protections, an attacker could trick staff into using stolen login details, or could use a maintenance connection to access parts of the system they are not authorised to reach, which could lead to disruption or data loss.

To meet this expectation, the organisation must require phishing-resistant multi-step sign-in for every remote maintenance session. This should use a security key approach that responds to a live challenge, so old sign-in attempts cannot simply be reused. The organisation must also keep maintenance communications separate from all other network communications to the system. This can be done either by using physically separate connections, or—if this is not used—by using logically separate, encrypted pathways.

##### Maintenance-only ZTNA with FIDO2/WebAuthn and encrypted session separation

- Category: Software
- Priority: Critical

###### WHAT must be done
Protect **non-local maintenance sessions** by (1) requiring **phishing-resistant, replay-resistant** sign-in and (2) ensuring maintenance messages are **kept separate in a controlled way** from all other network traffic using **encryption**.

###### WHY (control requirement)
NIST MA-4(4) enhancement requires that non-local maintenance sessions are protected by sign-in checks, and that the communication route is **kept separate in a controlled way** using encryption. The organisation-defined setting requires **sign-in methods that cannot be reused (replayed)**. The default guidance is **multi-factor authentication using FIDO2/WebAuthn (phishing-resistant) with challenge-response**.

###### HOW (specific steps/approach)
Set up a **maintenance-only access route** using a ZTNA/access broker (or equivalent access gateway) that:
1. **Creates a dedicated maintenance access rule** that applies only to **non-local maintenance** (for example, contractor/vendor/remote support) and only to an explicit **set of maintenance applications** (jump hosts, remote management portals, break-glass admin interfaces).
2. **Enforces phishing-resistant multi-factor authentication using FIDO2/WebAuthn** at the ZTNA entry point, using **challenge-response**, with **no weaker multi-factor authentication fallback options** for this maintenance rule.
3. **Ensures replay resistance** by using standard WebAuthn/FIDO2 authenticators (challenge-response) and by blocking older methods such as one-time passwords (OTP) used on their own for maintenance sessions.
4. **Provides controlled separation** by routing/authorising maintenance traffic only to the maintenance application set, and blocking access to general user/admin applications from the same maintenance session.
5. **Ensures encryption** for the controlled maintenance route (for example, TLS-encrypted ZTNA tunnels/channels) and checks that maintenance sessions cannot be used to reach other network services.
6. **Creates audit evidence**: record ZTNA session setup, the multi-factor authentication method (must show WebAuthn/FIDO2), the maintenance rule match, the target application, the source location (non-local), and the access decisions; send this to **security information and event management (SIEM)**.
7. **Checks with tests**: confirm that (a) non-local maintenance requires WebAuthn/FIDO2, (b) attempts using password-only or OTP-only fail, and (c) maintenance sessions cannot access non-maintenance applications/services.

###### WHO (role responsible)
- **Identity and Access Management (IAM) / Identity Engineer**: configure the identity provider (IdP) for WebAuthn and set the conditional access/maintenance rule.
- **Network/Security Engineer**: implement ZTNA access broker routing, the maintenance-only application set, and enforcement of encrypted sessions.
- **Security Operations Centre (SOC) / Governance, Risk and Compliance (GRC)**: define logging requirements, review evidence, and confirm audit readiness.

###### Acceptance criteria
- Every **non-local maintenance session** is handled through the **maintenance-only** access rule and can reach **only** the approved maintenance application set.
- Sign-in for maintenance sessions uses **FIDO2/WebAuthn** with **challenge-response**; logs must show WebAuthn/FIDO2 as the multi-factor authentication method.
- **Replay resistance** is demonstrated by requiring a new WebAuthn challenge for each session attempt and blocking non-WebAuthn sign-in methods for maintenance.
- Maintenance communications are **kept separate in a controlled way** and **encrypted**; attempts to access non-maintenance applications/services from the maintenance session are blocked.
- Audit evidence is available: ZTNA session logs + multi-factor authentication method + access decision records are retained according to the organisation’s logging and retention requirements.

###### Actions Required for Compliance

- [ ] Set up a clearly defined list of applications that are allowed for maintenance only, and block access to every other application not on that list.
- [ ] Set up the identity provider (IdP) and zero trust network access (ZTNA) integration so that the “maintenance-only” access policy requires multi-factor authentication (MFA) using FIDO2/WebAuthn, with no weaker MFA fallback options.
- [ ] For every non-local maintenance session attempt, enable and confirm Web Authentication (WebAuthn) challenge-response, and block older authentication methods for maintenance.
- [ ] Set up encrypted, separate maintenance connections using the zero trust network access (ZTNA) access broker, and control the routing so maintenance sessions cannot access general network services.
- [ ] Set up audit logging to record when a non-local maintenance session is started, which multi-factor authentication (MFA) method is used (WebAuthn/FIDO2), which target application is being accessed, and the result of the policy decision.
- [ ] Run validation tests to confirm that attempts using only a password or only a one-time passcode (OTP) fail, and that maintenance sessions cannot access non-maintenance endpoints.


---

#### MA-4.5 — Approvals and Notifications (Enhancement)

This requirement is about making sure that any maintenance carried out on your systems from outside the usual location is properly checked and that the right people are informed in advance. Without this, important changes could be made without the right oversight, increasing the risk of service disruption, accidental exposure of sensitive information, or delays in responding if something goes wrong.

To meet this requirement, the organisation must get approval for every non-local maintenance session before it starts. Both the Information System Security Officer and the System Owner must agree that the planned work is appropriate. The organisation must also notify the Information System Security Officer, the System Owner, and the on-call Incident Response Lead of the planned date and time for each non-local maintenance session. This notification can be sent by the maintenance staff, as long as it reaches the named recipients.

The people giving approval must have enough knowledge to judge whether the maintenance is suitable.

##### Dual-approval workflow and date/time notifications for nonlocal maintenance

- Category: Software
- Priority: Critical

###### WHAT
Put in place a controlled process for every **remote (nonlocal) maintenance** session so that it is **approved before it starts** by the required authorities, and the required people are **told the planned date and time**.

###### WHY (control requirement)
MA-4(5) (Enhancement) requires that:
- **Approval** for each **remote (nonlocal) maintenance** session is obtained **before the session begins**.
- Approval is given by staff with **enough information security knowledge and system understanding** to judge whether the proposed maintenance is appropriate.
- The **planned date and time** for remote (nonlocal) maintenance is shared with the defined roles.

###### HOW (specific approach)
###### 1) Define the approval and notification roles (from organisation-defined parameters)
- **Approvers (two-person approval):**
  - **Information System Security Officer (ISSO)**
  - **System Owner**
  (ma-04.05_odp.01)
- **Notification recipients:**
  - **ISSO**
  - **System Owner**
  - **On-call incident response lead**
  (ma-04.05_odp.02)

###### 2) Enforce “approval before start” using an IT service management (ITSM) workflow gate
- Create a dedicated **IT service management (ITSM) workflow** (or extend an existing change/maintenance workflow) for **remote (nonlocal) maintenance**.
- For each request, require mandatory details, at minimum:
  - system/application identifier
  - vendor/contractor identity
  - remote access method
  - **planned start date/time** (including time zone)
  - maintenance scope/justification
  - maintenance window end time (if available)
  - reference to the remote access session ticket/identifier
- Set the workflow so the request cannot move to **“Approved/Scheduled/Ready to start”** until **both**:
  - ISSO has approved, and
  - the System Owner has approved.
- Ensure the workflow prevents the maintenance from running by requiring the remote access tools to use the **approved IT service management (ITSM) ticket ID** (for example, the ticket ID must be provided/checked before access is granted).

###### 3) Ensure approvers have sufficient knowledge (enforced in practice)
- Assign ISSO and System Owner responsibilities to named roles (or role groups) and ensure only those identities can approve in the workflow.
- Require the request to include enough technical and security context for approvers to judge suitability (scope, risk level, and what impact/rollback is expected).
- For higher-risk maintenance categories (for example, changes affecting authentication/authorisation, data stores, or production configuration), require an extra internal review step by the relevant application/system engineering lead **before** ISSO approval (to support “sufficient system knowledge”).

###### 4) Send notifications from maintenance staff while ensuring recipients are informed
- Allow maintenance staff (or the requester) to **submit** the request and start the workflow.
- Configure automated notifications so that when the request is submitted and/or when it reaches the approved/scheduled stage, the system sends the **planned date and time** to:
  - ISSO
  - System Owner
  - on-call incident response lead
- Link to an on-call routing service (for example, PagerDuty/Opsgenie) so the **on-call incident response lead** is the correct person at the time of notification.

###### 5) Keep audit-ready evidence
- Retain:
  - approval records (who approved, when, and which ticket)
  - the planned date/time captured at submission
  - notification delivery logs (and/or message IDs) showing the required recipients were notified
  - a link between the approved ticket and the remote access session

###### WHO
- **IT service management (ITSM) / Service Management Owner**: sets up and maintains the workflow and ticket fields.
- **Information System Security Officer (ISSO)**: approves each remote (nonlocal) maintenance session.
- **System Owner**: approves each remote (nonlocal) maintenance session.
- **Maintenance staff / requester**: submits the remote (nonlocal) maintenance request and provides the required information.
- **Incident Response Lead (on-call)**: receives planned date/time notifications.

###### Acceptance criteria
- For every remote (nonlocal) maintenance session, the IT service management (ITSM) workflow shows **two-person approval** by ISSO and the System Owner **before** the session can be scheduled/executed.
- The workflow records and sends the **planned date and time** (including time zone) to **ISSO, System Owner, and on-call incident response lead**.
- Remote access tools cannot be used for the maintenance session unless they reference the **approved** IT service management (ITSM) ticket ID.
- Audit evidence exists for each session: approvals (identities and timestamps) and notification records (delivery logs or equivalent).

###### Actions Required for Compliance

- [ ] Create a dedicated IT service management (ITSM) workflow for non-local maintenance. Make these details mandatory: the planned start date and time (including the time zone) and the maintenance scope.
- [ ] Set up workflow enforcement so that execution and scheduling are blocked until both the Information System Security Officer (ISSO) and the System Owner have given approval and their approvals are recorded.
- [ ] Link the remote access tool to the IT service management (ITSM) ticket, so remote access is only granted when there is an approved non-local maintenance ticket reference number.
- [ ] Set up automated notifications when a request is submitted or approved to the information system security officer (ISSO), the system owner, and the current on-call incident response lead, including the planned date and time.
- [ ] Set up the workflow so that only the Information System Security Officer (ISSO) and System Owner role groups can approve actions, and restrict approval permissions to those groups.
- [ ] Add an internal pre-approval review step for high-risk maintenance categories so that people approving work have enough knowledge of the systems involved.
- [ ] Keep audit records for approval decisions, notification delivery, and the link between the approved ticket and the maintenance session.


---

#### MA-4.6 — Cryptographic Protection (Enhancement)

This requirement is about protecting any remote maintenance or diagnostic messages. It ensures that only the right people can access them, and that no one can secretly alter them while they are being sent.

Without strong protection, an unauthorised person could intercept a remote session, pretend to be a trusted party, and then:
- insert malicious code,
- make unauthorised changes to settings, or
- steal sensitive organisational information,

which could harm business or mission outcomes.

To meet this expectation, the organisation must configure all non-local maintenance and diagnostic communications to use the latest secure web-style encryption: Transport Layer Security 1.3 (TLS 1.3). It must use:
- Advanced Encryption Standard 256-bit in Galois/Counter Mode (AES-256-GCM) for confidentiality (keeping information secret) and tamper detection (detecting changes), and
- Elliptic Curve Diffie-Hellman Ephemeral (ECDHE) for key exchange.

The organisation must also require both sides to prove their identity using digital certificates before any connection is allowed.

Finally, the organisation must use only cryptographic components that have been validated to meet Federal Information Processing Standards 140-3 (FIPS 140-3), and must keep evidence showing which validated modules are in use.

##### Enforce mTLS over TLS 1.3 for nonlocal maintenance/diagnostics

- Category: Software
- Priority: Critical

###### WHAT
Implement encryption and authentication for **remote (nonlocal) maintenance and diagnostic communications** using the organisation-approved mechanisms: **Transport Layer Security version 1.3 (TLS 1.3)** with **Advanced Encryption Standard 256-bit in Galois/Counter Mode (AES-256-GCM)** and **Elliptic Curve Diffie-Hellman Ephemeral (ECDHE)**, and **mutual certificate authentication** (mutual TLS, or **mTLS**). Use **only cryptographic modules validated under Federal Information Processing Standards Publication 140-3 (FIPS 140-3)** for the TLS/mTLS enforcement point(s).

###### WHY (control requirement)
National Institute of Standards and Technology (NIST) Special Publication 800-53 **MA-4(6)** enhancement requires: “**Implement the following cryptographic mechanisms to protect the integrity and confidentiality of nonlocal maintenance and diagnostic communications**: {{ insert: param, ma-04.06_odp }}.” The guidance notes that if these communications are not protected, attackers could intercept them, pretend to be authorised users, insert malicious code, change parameters without permission, and steal data.

###### HOW (specific steps/approach)
1. **Identify and force all remote maintenance/diagnostic routes** (for example: vendor remote support portals, virtual private network (VPN)-based maintenance, diagnostic web consoles, application programming interface (API)-based diagnostics, and secure shell (SSH)-over-tunnel workflows) so they **cannot bypass** the encryption/authentication enforcement point.
2. **Create or extend a dedicated maintenance access endpoint** (gateway or reverse proxy) that handles the encrypted connection and enforces **TLS 1.3 only**.
3. Configure the endpoint to allow **only**:
   - **TLS 1.3**
   - Cipher suite(s) using **AES-256-GCM**
   - **ECDHE** key exchange
4. Enforce **mutual certificate authentication**:
   - Require client certificates for all maintenance/diagnostic sessions.
   - Check server and client certificates (including the trust chain, certificate expiry, and revocation/validity checks such as Certificate Revocation List (CRL) or Online Certificate Status Protocol (OCSP) where applicable).
5. Ensure the TLS/mTLS enforcement components use **FIPS 140-3 validated cryptographic modules**. Record the **module identifiers and validation evidence** for the specific components in use.
6. Keep **audit-ready configuration evidence** showing the enforced TLS version, cipher suite policy, mTLS requirement, and the FIPS 140-3 module validation details.

###### WHO
- **Security Architect / Compliance Lead**: sets the cryptographic policy baseline and acceptance criteria.
- **Network/Platform Engineering**: configures TLS 1.3 + AES-256-GCM + ECDHE + mTLS and ensures traffic is routed through the enforcement point.
- **Public Key Infrastructure (PKI)/Identity Team**: issues certificates, manages trust anchors, and performs revocation/validity checks.
- **Security Operations**: checks that evidence is complete and supports ongoing monitoring.

###### Acceptance criteria
- All remote maintenance/diagnostic communications pass through the enforcement point(s) with **no bypass routes**.
- For these communications, the connection setup (TLS handshake) negotiates **TLS 1.3 only**.
- The agreed cipher suites use **AES-256-GCM**, and the key exchange uses **ECDHE**.
- **mTLS is enforced**: connections without valid client certificates are rejected.
- Certificate checks include **trust chain** and **expiry** checks, and revocation/validity checking is configured.
- The TLS/mTLS enforcement components are supported by **FIPS 140-3 validated cryptographic modules**, and evidence of the specific validated modules in use is retained.
- Configuration and evidence are clearly auditable (for example, exported gateway/TLS configuration and documented references to the FIPS module validations).

###### Actions Required for Compliance

- [ ] Identify and list all remote maintenance and diagnostic communication routes, and document any possible ways they could be bypassed.
- [ ] Set up the maintenance and diagnostic enforcement endpoint to use Transport Layer Security version 1.3 (TLS 1.3) only, with Advanced Encryption Standard 256 in Galois/Counter Mode (AES-256-GCM) and Elliptic Curve Diffie–Hellman Ephemeral (ECDHE) for key exchange.
- [ ] Set up mutual certificate authentication and require a client certificate for every maintenance or diagnostic session.
- [ ] Check certificates before starting a session, including whether the certificate’s trust chain is valid, whether it has expired, and whether it has been revoked (or is otherwise still valid).
- [ ] Select and set up Transport Layer Security (TLS) termination components that use Federal Information Processing Standards (FIPS) 140-3 validated encryption modules, and keep records showing the validation evidence for those modules.
- [ ] Prevent direct access to maintenance and diagnostic services, so all traffic must pass through the enforcement point(s), and confirm this by running test connection handshakes.


---

#### MA-4.7 — Disconnect Verification (Enhancement)

This expectation is about ensuring that when remote help or troubleshooting is finished, the access routes used during that work are fully closed. If connections are not properly ended, they could potentially be reused to get back in, bypass safeguards, or keep access for longer than intended—creating a real risk of unauthorised access and misuse.

To meet this expectation, the organisation must, after each completed period of remote (non-local) maintenance and diagnostics, review the relevant records to confirm that both:
- the remote user session, and
- the network connection(s) created for that work

have been ended and are no longer available.

The organisation should clearly link these checks to the specific maintenance activity, carry out the verification only after the work is marked complete, and keep dated evidence showing what was checked and the result. This evidence should include references to the session and network termination records used.

##### Automated disconnect verification after non-local maintenance

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, audit-ready check that confirms **both** (1) the **remote session** and (2) the underlying **network connection(s)** created for each **finished non-local maintenance/diagnostic session** have been ended and are no longer available.

###### WHY (control requirement)
MA-4(7) Enhancement requires the organisation to **confirm that sessions and network connections are ended after non-local maintenance/diagnostic work is finished**, so that any connections created during that activity cannot be used afterwards.

###### HOW (specific steps/approach)
1. **Standardise correlation identifiers**: Make sure every non-local maintenance/diagnostic access uses an approved remote-access route (for example: virtual private network (VPN)/remote access gateway/zero trust network access (ZTNA)/bastion). This route must record a consistent set of identifiers (user, source internet protocol (IP) address, destination system, gateway/tunnel/session ID, and the maintenance/work-order/ticket ID).
2. **Create and keep proof of termination**: Configure the remote-access gateway and any intermediate components (for example: VPN concentrator, ZTNA proxy, bastion/jump host, and firewall/network address translation (NAT) session logging where applicable) to produce log events for the session lifecycle (established/terminated/disconnected) and for network shutdown (tunnel down, session end, connection teardown). Include timestamps and the correlation identifiers.
3. **Run the check only after completion**: In the maintenance process (ticketing/change system), record a clear **completion time** and mark the maintenance window as **completed**. Start the verification immediately after this update.
4. **Match completed work to termination events**: An automated job searches the security information and event management (SIEM) system/logs for all session and network events linked to the maintenance/work-order ID and the relevant time window, then confirms:
   - a termination/disconnect event exists **after** the completion time for the session(s) created for that work, and
   - a network teardown event exists **after** the completion time for the matching tunnel/connection(s).
5. **Produce audit evidence**: Create a “Disconnect Verification” record that includes: maintenance/work-order ID, completion time, the exact log query/time range used, the specific event references (event IDs/hashes), and a pass/fail result.
6. **Handle exceptions safely**: If termination proof is missing, or if shutdown appears delayed, automatically raise an exception for the named approvers and (where permitted) start a forced session shutdown through the remote-access platform, while recording what was done and the evidence produced.

###### WHO (role responsible)
- **Security Operations / security operations centre (SOC) Automation Engineer**: implement the correlation logic, SIEM queries, and evidence record creation.
- **Infrastructure/Network Administrator (Privileged Access Owner)**: ensure remote-access gateways produce the required termination logs, and that any forced shutdown (if used) is operationally safe.
- **Information Security / Compliance Approver**: review and approve exceptions and ensure evidence is kept for the required audit period.

###### Acceptance criteria
- For each completed non-local maintenance/diagnostic ticket/window, the system produces a Disconnect Verification record showing **session termination** and **network connection teardown** evidence that occurs **after** the ticket completion time.
- Verification records include unchangeable references to the exact log events/queries used (suitable for audit).
- If termination evidence is missing, the workflow raises an exception to the named approvers (and forced shutdown is only carried out if explicitly authorised by policy).
- Evidence is kept for the organisation’s defined audit retention period.

###### Actions Required for Compliance

- [ ] Ensure that all remote maintenance and diagnostics that are not performed locally use only approved remote-access gateways (also known as bastions), and that each activity uses consistent reference details (such as the ticket or work-order ID, the user, and the session or tunnel ID).
- [ ] Set up remote access and network equipment to record, with timestamps and matching reference keys, both (1) when a session ends and (2) when the network connection is shut down.
- [ ] Set up the maintenance workflow so checks are only started after the work order or time window is marked as completed, with the completion date and time recorded.
- [ ] Set up security information and event management (SIEM) and log-analytics checks that, for each completed time window, confirm that termination events are recorded after the window ends for both the session and the network connection(s).
- [ ] Create and store a record of the Disconnect Verification that can be audited, and link it to the exact log searches and event IDs used to decide pass or fail.
- [ ] Set up an exception process for when termination evidence is missing or arrives late, including named approvers and documented steps for how the issue will be handled.


---

### MA-5 — Maintenance Personnel (Control)

This requirement is about making sure only approved maintenance staff—including external suppliers—can work on your systems, and that they have the right level of access for the task. Without this, the wrong person could tamper with equipment or software, access sensitive information, or make changes that are difficult to trace—especially when maintenance is arranged at short notice or without someone from your organisation overseeing the work.

To meet this expectation, the organisation must:
- use a clear, documented process to approve maintenance staff and organisations
- keep an up-to-date list of who is allowed to maintain which systems, and update it whenever permissions change
- check that any maintenance worker who is not escorted has the correct access permissions before starting work
- appoint internal staff who are suitably authorised and technically capable to supervise maintenance activity when the external worker does not have the required access

If temporary access is needed, it must be limited to a specific time period and recorded.

##### Authorised maintenance access workflow with time-bound credentials

- Category: Software
- Priority: Critical

###### WHAT
Set up a documented, auditable process to authorise maintenance staff (including external suppliers) to carry out maintenance on organisational systems. The process must ensure that: (a) only authorised maintenance staff or organisations are allowed to maintain the specific systems or areas, (b) maintenance staff who are not supervised (unescorted) are only given the access permissions needed to carry out the maintenance, and (c) if the required access is not fully granted, the maintenance is overseen by technically competent, authorised internal organisational staff.

###### WHY (control requirement)
MA-5 requires that maintenance staff are authorised and that access matches the maintenance being carried out. The guidance also states that people not previously identified as authorised maintenance staff (for example, suppliers, integrators, consultants) may need privileged access. If temporary credentials are issued, they must be based on risk, time-limited, and recorded.

###### HOW (specific steps/approach)
1. **Create a maintenance authorisation process** integrated with the organisation’s identity and access management (IAM) and IT service management (ITSM) tools (for example, ServiceNow plus IAM/privileged access management (PAM)). The process must require a maintenance work order reference and record: the identity of the maintenance person or supplier, the systems or areas to be maintained, the maintenance activities to be carried out, whether the work is **escorted** or **unescorted**, the maintenance window (start and end), and the requested access level.
2. **Maintain an authoritative “authorised maintenance list”** (system of record in IAM/governance, risk and compliance (GRC)) that lists each authorised maintenance person or organisation with enough detail to confirm scope: which systems or areas they can access, which activities they can perform, the escalation route, and whether they are **Active** or **Inactive**. The process must check incoming maintenance requests against this list.
3. **Check access for unescorted maintenance**: if the work order is marked unescorted, the process must verify that the maintenance identity has the required access permissions for the exact systems and roles before maintenance starts. If permissions are missing or do not match the requested scope, the process must block or pause the work order.
4. **Only issue temporary credentials through the process** when risk assessments show they are needed. Temporary credentials must be **time-limited** (one-time or short-lived) and tied to the work order and the maintenance window. Credential issuance and expiry must be recorded and linked to the work order.
5. **Assign and verify supervisors for restricted access situations**: if maintenance staff do not have the required access permissions, require assignment of an internal organisational supervisor who is both (a) authorised for the relevant access and (b) technically competent for the type of maintenance. The process must prevent unescorted maintenance from proceeding without the required supervisor assignment where needed.
6. **Automatically produce audit-ready evidence**: store the approval trail, authorised maintenance list checks, credential issuance and expiry records, access permission checks, and the link to the maintenance work order. This allows auditors to confirm who was authorised, for what scope, for what time, and under what supervision.

###### WHO
- **Security and Compliance lead**: owns the MA-5 control design, the risk criteria for temporary credentials, and the audit evidence requirements.
- **IAM/PAM engineer**: implements process enforcement, permission checks, and time-limited credential issuance.
- **ITSM/Operations manager**: ensures maintenance work orders are raised with the correct scope and the correct escorted/unescorted flags.
- **System and application owners**: approve scope and confirm the technical competence requirements for supervisors.

###### Acceptance criteria
- Maintenance work orders cannot be started for unescorted maintenance unless the maintenance identity has been validated against the authorised maintenance list and/or granted the required access permissions for the exact scope.
- Temporary credentials are issued only through the process, are time-limited, and are recorded with work order linkage and expiry.
- Where required access is not fully granted, an internal supervisor is assigned and verified as both authorised and technically competent before maintenance proceeds.
- Evidence exists for each maintenance event: authorisation approvals, authorised maintenance list validation, access checks, credential issuance and expiry, and supervisor assignment (where applicable).

###### Actions Required for Compliance

- [ ] Define and document the process for approving maintenance work, including the rules for whether staff must be escorted or can work unescorted, and what supporting evidence is required.
- [ ] Set up identity and access management (IAM) and IT service management (ITSM) integration so that maintenance work orders automatically trigger entitlement checks and require approval before access is granted.
- [ ] Create and keep an official authorised maintenance list that records: which systems or areas are allowed, which maintenance activities are allowed, and the current status.
- [ ] Set unescorted maintenance to be blocked unless the required access permissions match the work order scope before the start time.
- [ ] Set up time-limited temporary access credentials using privileged access management (PAM) and just-in-time (JIT) access only through the approved workflow, and record when each credential is issued and when it expires, linked to the relevant work order.
- [ ] Put in place controls that assign supervisors only when needed, ensuring that the supervisor is an internal authorised person with the required technical competence whenever the requested access is not fully granted.
- [ ] Check that audit evidence is produced correctly by running end-to-end tests for authorised, unescorted, and temporary-credential maintenance scenarios.


---

#### MA-5.1 — Individuals Without Appropriate Access (Enhancement)

This requirement is about stopping sensitive information from being viewed, copied, or altered during maintenance work by people who do not have the right clearance or are not allowed to access it. Without these safeguards, an unauthorised visitor could see confidential information while repairs are being done, or leave behind information on parts of the system that still store data.

To meet this requirement, the organisation must have clear procedures for using maintenance staff. Maintenance staff must always be escorted and supervised by approved staff who are fully cleared, properly authorised, and technically competent. Before any work starts, the organisation must remove or clear any temporary stored data, and remove or physically disconnect any storage media that holds data, then secure that media.

If any part cannot be cleared, removed, or physically disconnected, the organisation must isolate it in a locked area, disconnect all connections, allow only read-only access, and record all activity until the clearing work is complete.

##### Escort-gated maintenance sessions with media protection and logging

- Category: Software
- Priority: Critical

###### WHAT
Put in place documented procedures and a controlled access process so that people who do not have the right security clearance/authorisation (or who are not United States citizens) can only carry out maintenance and diagnostics while an approved, eligible escort or supervisor is authorised at the same time and is physically present. The process must also require protection of sensitive storage before work starts (including safely clearing volatile data and removing or disconnecting non-volatile media). If sanitisation, removal, or disconnection cannot be completed, the system must carry out agreed backup measures (locked “enclave” isolation, disable all interfaces, give read-only access, and record everything in full logs).

###### WHY (control requirement)
MA-5(1) enhancement requires procedures to ensure people without the right security clearance or who are not United States citizens do not have visual or electronic access to classified or controlled unclassified information on organisational systems. This includes specific handling for maintenance staff, set out in security plans. The organisation-defined parameter (ma-05.01_odp) also sets out the required backup measures when a component cannot be sanitised, removed, or disconnected.

###### HOW (specific steps/approach)
1. **Create and maintain an approved escort list**: Keep a controlled list of eligible escorts or supervisors who are fully cleared/authorised and technically competent for the specific system(s). Re-check eligibility on a set schedule and whenever someone’s role changes.
2. **Mark maintenance staff eligibility in identity records**: Mark maintenance users as “ineligible” when they do not have the required clearance/authorisation or are not United States citizens, using official human resources (HR) and identity attributes.
3. **Set up an “escort-gated maintenance session” workflow** (identity provider/portal plus access enforcement):
   - Require a work order ID, system ID, maintenance time window, the ineligible person’s identity, and the escort’s identity.
   - Block maintenance administrator and diagnostic access unless the escort is authorised at the same time for the same work order and system.
   - Require extra verification for the escort (for example, phishing-resistant multi-factor authentication (MFA)) and link the session to the escort’s identity.
4. **Make media protection a strict “go/no-go” step before maintenance can start**:
   - Require proof or confirmation that **volatile storage** has been sanitised.
   - Require proof or confirmation that **non-volatile storage media** has been removed or physically disconnected and secured.
5. **If sanitisation/removal/disconnection is not possible, apply the required backup measures** (per ma-05.01_odp):
   - Put the component in a **locked enclave**.
   - **Disable all interfaces** to prevent any visual or electronic access routes.
   - Allow **read-only access** for the ineligible person.
   - **Record all activity** until sanitisation is completed.
   - Capture completion evidence and automatically end the maintenance session.
6. **Produce audit-ready evidence for every maintenance event**:
   - Escort eligibility and authorisation records.
   - Session start and end logs showing escort concurrence.
   - Media protection checklist evidence.
   - Records showing when backup measures were applied and completed, including confirmation that read-only access was enforced.

###### WHO (role responsible)
- **System Owner / Security Officer**: approves the escort list, defines system-specific maintenance procedures, and signs off the backup-measure playbooks.
- **Identity and Access Management (IAM) Engineer**: implements conditional access and session controls, and links the session to the escort’s identity.
- **Operational Technology (OT) / Infrastructure Maintenance Lead**: ensures media protection steps are carried out and provides evidence for volatile sanitisation and non-volatile removal/disconnection.
- **Security Operations Centre (SOC) / Security Information and Event Management (SIEM) Analyst (or Monitoring Team)**: ensures logging, alerts, and retention for maintenance sessions and backup-measure activity.

###### Acceptance criteria
- For any maintenance session started by an ineligible person, access to maintenance and diagnostic interfaces is **blocked** unless an approved escort is authorised at the same time for the same work order and system.
- The session cannot start until there is evidence or confirmation that volatile sanitisation and non-volatile media removal/disconnection and securement have been completed.
- If any component cannot be sanitised, removed, or disconnected, the system must enforce locked enclave isolation, disable interfaces, provide read-only access, and record all activity until completion.
- Audit logs must show: (a) the ineligible identity, (b) escort identity concurrence, (c) media protection evidence, and (d) backup-measure activation and completion for each maintenance event.

###### Actions Required for Compliance

- [ ] Define and get approval for system-specific maintenance procedures for staff who are not authorised to work on the system, including requirements for escort or supervision and steps to protect any media used.
- [ ] Create and keep an official escort roster that lists each escort’s security clearance or authorisation status and confirms they have the required technical competence.
- [ ] Set up identity details to identify maintenance staff who are not allowed to access systems (for example, they do not have the required clearance or authorisation, or they are not United States citizens).
- [ ] Set up conditional access and session controls so that maintenance access interfaces are blocked unless an approved escort is authorised at the same time for the same work order and system.
- [ ] Set up a pre-session checklist “gate” that requires evidence that volatile data has been sanitised, and that non-volatile media has been removed, disconnected, and securely stored.
- [ ] Create compensating-control playbooks that keep the secure enclave isolated and locked down, disable external interfaces, allow only read-only access, and record activity continuously until sanitisation is complete.
- [ ] Set up security information and event management (SIEM) logging and retention for maintenance sessions, to protect and retain evidence from media, and to record when compensating controls are activated and completed.


---

#### MA-5.2 — Security Clearances for Classified Systems (Enhancement)

This requirement is about ensuring that only properly checked and authorised people can work on systems that handle classified information, even for routine repairs and diagnostics. If this is not in place, someone who does not have the right clearance or formal authorisation for the system’s sensitivity could accidentally view, change, or reveal information during maintenance. This creates a serious risk of unauthorised disclosure or misuse.

To meet this requirement, the organisation must:
- Identify every person who carries out maintenance or diagnostic work on any classified system.
- Check that each person holds the correct security clearance for at least the system’s highest classification level, and for every information compartment they could come across during the work.
- Confirm that each person also has matching formal authorisation for those same levels and compartments.

The organisation must then:
- Prevent maintenance from going ahead if either the security clearance or the formal authorisation is missing or not sufficient.
- Keep clear evidence in personnel and access records.
- Ensure maintenance logs record who carried out the work.
- Use documented procedures so these checks are completed before work starts and remain valid.

##### Gate classified maintenance by clearance and compartment authorisation

- Category: Software
- Priority: Critical

###### WHAT must be done
Make sure that anyone carrying out maintenance or diagnostic work on a system that processes, stores, or transmits classified information has:

1. **A security clearance** at least as high as the system’s **highest classification level**, and for the **relevant information compartments**; and  
2. **Formal access approvals/authorisations** at least at the same levels and for the same compartments.

If either requirement is missing or not sufficient, **maintenance must be blocked**.

###### WHY (control requirement)
MA-5(2) enhancement requires proof that maintenance and diagnostic staff have both the correct security clearance and the correct formal access approvals for the system’s highest classification level and the compartments involved. The guidance notes that maintenance staff may be exposed to classified information during maintenance, so clearance and formal authorisation must reduce that risk.

###### HOW (specific steps/approach)
Set up a “maintenance gate” that checks, before any work starts, that each named person’s clearance and compartment permissions match what the maintenance activity could access. The check must be **fail-closed** (if anything is missing or unclear, the work is stopped).

1. **Create an official clearance and compartment record** in the organisation’s identity system (or a connected authorisation service). Store:
   - clearance level  
   - list of compartments  
   - validity/expiry dates  
   Ensure these details come from personnel security records, not self-service.
2. **Record what each system requires** in a configuration register for every classified system (or maintenance target). For each one, store:
   - system identifier  
   - highest classification level  
   - the compartments that maintenance could encounter
3. **Require work orders to state what is needed**:
   - the target system  
   - the required classification level and compartment list  
   - the name(s) of the technician(s) who will do the work
4. **Run a pre-start authorisation check (fail closed)** in the maintenance process and/or the privileged access process:
   - when the work order is approved, and again immediately before the session starts, confirm the technician’s clearance level is **at least** the system’s highest classification level  
   - confirm the technician is authorised for **all** compartments listed for that maintenance activity  
   - if clearance or compartment authorisation is missing or insufficient, **automatically deny** the maintenance session and require escalation to the security/authorisation authority
5. **Provide privileged maintenance access only through this gated process** (for example, a privileged session broker). Ensure the session is linked to:
   - the named technician  
   - the target system  
   - the required compartment set
6. **Create evidence that can be audited**:
   - keep records linking each technician to their clearance level and compartment authorisations (including validity dates)  
   - keep maintenance logs showing who did the work, the target system, the approved classification/compartments, and the time window

###### WHO (role responsible)
- **Security clearance and authorisation owner** (for example, Personnel Security / Security Governance): keeps the official clearance and compartment records and approves exceptions.
- **Identity and privileged access (IAM/PAM) engineer**: builds the attribute model, enforces the policy checks, and implements the gated access process.
- **Change/maintenance process owner (IT service management (ITSM) / operational technology (OT) maintenance manager)**: ensures work orders include the required system classification/compartments and the technician names.
- **System owner / security approver**: confirms the system-to-compartment requirement definitions are correct.

###### Acceptance criteria
- For every maintenance/diagnostic work order on a classified system, the workflow records show:
  - the named technician(s)  
  - the target system  
  - the required highest classification level and compartments
- No maintenance session starts unless the technician’s clearance and compartment authorisation are checked and confirmed as sufficient for the required levels/compartments (**fail-closed**).
- Evidence is kept to show:
  - (a) each technician’s clearance level and compartment authorisation, and  
  - (b) maintenance logs identifying the authorised personnel who carried out the work.
- The checks are repeated immediately before the session starts (or at least when privileged access is issued), so expired or changed authorisations cannot be used.

###### Actions Required for Compliance

- [ ] Create a system registry that lists each classified system and records (1) its highest classification level and (2) the compartments that are relevant for maintenance.
- [ ] Create an official identity information model for clearance level, compartment authorisations, and validity dates, using data from personnel security records.
- [ ] Update the maintenance and diagnostic work-order template to require: the target system identifier, the required classification level, the required compartments, and the named technician(s).
- [ ] Implement a “fail-closed” check before starting maintenance that blocks the session if the required security clearance or compartment authorisation is missing or not sufficient.
- [ ] Link privileged maintenance access approval to the controlled workflow, so access sessions are created only for verified technicians and approved compartment sets.
- [ ] Set up audit logs and retention so they record the technician’s identity, evidence of their clearance or compartment access, the target system, the approved access levels or compartments, and the maintenance time window.


---

#### MA-5.3 — Citizenship Requirements for Classified Systems (Enhancement)

This requirement is about ensuring that only the right people work on sensitive, classified systems. If maintenance or diagnostic work is carried out by someone who is not a United States citizen, there is a real risk that classified information could be seen, handled incorrectly, or exposed during repairs, testing, or troubleshooting.

To meet this expectation, the organisation must set a clear rule that anyone who carries out maintenance or diagnostic activities on systems that process, store, or transmit classified information must be a United States citizen, and the organisation must apply this rule in day-to-day operations. This means:

- documenting the rule in maintenance procedures  
- training staff to follow it  
- checking citizenship before anyone is assigned to do the work  

The organisation must also keep reliable records showing the citizenship status of maintenance and diagnostic personnel, and ensure that maintenance access permissions, credentials, and work records can be traced back to these citizenship checks.

##### US-citizen gating for classified-system maintenance access

- Category: Software
- Priority: Critical

###### WHAT
Set up a workflow that can be audited and that checks whether staff are **United States citizens** before they carry out any maintenance or diagnostic work on systems that **process, store, or transmit classified information**.

###### WHY (control requirement)
**MA-5(3)** requires the organisation to confirm that staff carrying out maintenance and diagnostic work on classified systems are **United States citizens**, using the same restriction applied when granting access to classified information.

###### HOW (specific steps/approach)
1. **Create a citizenship eligibility rule** for maintenance/diagnostic access to classified systems (for example, `US_CITIZEN=true`). Use the organisation’s official **human resources (HR) / personnel records** as the source, and include validity dates.
2. **Build the rule into the maintenance process** for classified systems: update **IT service management (ITSM)** work-order templates and maintenance checklists so the work order cannot move forward to **privileged access** or **session start** unless there is a recorded reference showing citizenship was verified.
3. **Apply the eligibility check at the identity and privileged access layer** for maintenance tools (for example, a **jump host**, **privileged access management (PAM)**, and remote support tools, plus privileged roles). Only identities with the required eligibility attribute can be granted maintenance/diagnostic privileges for classified systems.
4. **Link approval and proof to the work order**: make sure the privileged access request/approval and the session start event are recorded with the **work order ID** and the **citizenship verification reference**.
5. **Keep maintenance records** that show who performed the work and allow cross-checking against the citizenship verification evidence (for example, **security information and event management (SIEM)** and **ITSM** logs that connect the performer’s identity, the work order, and the eligibility decision).
6. **Stop workarounds** by configuring the workflow and privileged access controls so privileged maintenance access cannot be granted unless the citizenship eligibility check has been completed (for example, using “policy as code” and access request guardrails in the access request automation).

###### WHO (role responsible)
- **Security Engineering / Identity and Access Management (IAM) Lead**: implement the eligibility attribute, enforce privileged access, and ensure logging and traceability.
- **ITSM/Operations Manager**: update work-order templates, maintenance checklists, and workflow gates.
- **System Owner / Authorising Official**: confirm that classified-system maintenance procedures require the citizenship verification reference.
- **Privileged Access/PAM Administrator**: configure session start controls and ensure logs include the work order linkage.

###### Acceptance criteria
- For any maintenance/diagnostic activity on a classified system, **privileged access/session start is blocked** unless a **citizenship eligibility verification reference** is present and shows **United States citizen**.
- Evidence is auditable: each maintenance work order records the performer’s identity and links to the citizenship verification reference, and privileged access/session logs reference the **same work order ID**.
- Requests for privileged maintenance access without eligibility evidence are **rejected** and **recorded**.
- The controls are demonstrable for both **remote** and **on-platform** maintenance routes used for classified systems (as applicable to the organisation’s maintenance model).

###### Actions Required for Compliance

- [ ] Create an eligibility attribute for access to maintenance and diagnostic services for people who are United States citizens. Use official human resources (HR) or personnel records as the source, and include the dates for when the eligibility is valid.
- [ ] Update the information technology service management (ITSM) work-order templates and maintenance checklists for classified systems so they require a mandatory citizenship verification reference before any privileged access or session begins.
- [ ] Set up identity and privileged access controls (for example, privileged access management, a jump host, and remote support tools) so that maintenance and diagnostic permissions are granted only when the eligibility attribute shows the person is a United States citizen.
- [ ] Link privileged access requests and the start of each session to the work order ID and the citizenship verification reference in the logs.
- [ ] Put in place automated controls (policy-as-code and workflow enforcement) to stop privileged maintenance access being issued unless the citizenship check has been completed.
- [ ] Validate that audit records can be traced by running routine maintenance tests and confirming that the security information and event management (SIEM) and IT service management (ITSM) records link the person who did the work, the work order, and the checks used to verify citizenship.


---

#### MA-5.4 — Foreign Nationals (Enhancement)

This requirement is about ensuring that only people who have the correct security clearance—specifically, properly cleared foreign nationals—are allowed to carry out maintenance and diagnostic work on classified systems. It also limits this work to the specific cases where the system is covered by the correct ownership and operating arrangements with allied governments.

Without this control, sensitive information could be exposed through unauthorised access, there could be confusion about who is allowed to do which tasks, or work could be carried out on systems that are not covered by the agreed arrangements.

To meet this expectation, the organisation must confirm that any foreign national carrying out this work has the appropriate security clearance. It must also confirm that the classified system is either:
- jointly owned and operated by the United States and allied governments, or
- owned and operated solely by allied governments.

Before any such work begins, the organisation must have a Memorandum of Agreement in place. This document must clearly record the approvals and consents, and set out the detailed operating conditions for using foreign nationals for that maintenance and diagnostic activity.

##### MoA-gated access for foreign nationals on classified systems

- Category: Software
- Priority: Critical

###### WHAT
Set up an end-to-end “MoA-gated” access approval process for foreign nationals carrying out **maintenance and diagnostic** work on **classified systems**. This ensures they are **security-cleared** and that the **system ownership/operating rules** are met. Access is granted only when there is a relevant **Memorandum of Agreement (MoA)** for the specific system and activity, and that MoA includes the required **approvals, permissions, and detailed operating conditions**.

###### WHY (control requirement)
MA-5(4) enhancement requires that if non-citizens are allowed to perform maintenance/diagnostics on classified systems, the organisation must make sure no agreements or restrictions are breached. This is done by adding extra checks (security clearance) and confirming the system is covered by the correct ownership/operating arrangements. The required **approvals/permissions** and **detailed operating conditions** must be recorded in an MoA.

###### HOW (specific steps/approach)
1. **Create an official register of classified systems**. For each classified system, record its **ownership/operation model** (for example, joint ownership/operation with the United States and allies versus ally-only ownership/operation) and the **types of maintenance/diagnostic activities** that are allowed.
2. **Add identity and clearance information** into the organisation’s main identity and access management layer, so access rules can check each person’s status (including whether they are a foreign national) and their **security clearance** (for example, using human resources/contractor records and a clearance authority feed).
3. **Set up an MoA register** (document storage with structured information fields) that records, for each system and activity type:
   - the named foreign-national roles/contractor organisations,
   - **approvals** and **permissions**,
   - **detailed operating conditions** (for example: scope of work, how access is granted, handling of media, escort requirements, what must be logged, time windows, and any restrictions).
4. **Use policy rules (policy-as-code) to decide access** at the access broker / privileged access management layer, so a maintenance/diagnostic access request is approved only if all conditions are met:
   - the requester is a **foreign national** (where applicable),
   - the clearance information matches the **system/task requirement**,
   - the system’s ownership/operation model is one of the allowed cases,
   - an MoA exists for the **specific system plus activity type** and is **active**,
   - the MoA information confirms **approvals/permissions/detailed operating conditions** are present and complete.
5. **Apply MoA-gated sessions** by blocking privileged/session access to classified systems unless the MoA check succeeds. Store the MoA reference/ID with the session for audit purposes.
6. **Produce audit evidence automatically**: record the person’s identity, the clearance information used for the decision, the relevant system register entry, the MoA ID/version, and the result of the completeness checks.

###### WHO
- **IAM/PAM Engineer**: integrate identity attributes, implement policy-as-code, and enforce MoA-gated access.
- **Security Governance/Compliance Lead**: define the MoA information structure (schema) and the completeness requirements aligned to MA-5(4).
- **Classified System Owner / Authorising Official**: maintain the classified system register and approve the MoA content for the relevant system/activity.

###### Acceptance criteria
- For any maintenance/diagnostic access request by a foreign national to a classified system, access is **denied** unless:
  - the person’s clearance information is verified as suitable,
  - the system ownership/operation model is permitted,
  - an **active MoA** exists for the exact system and activity type,
  - the MoA includes recorded **approvals, permissions, and detailed operating conditions** (as defined by the organisation’s completeness rules).
- Every approved session includes an auditable link to the **MoA ID/version** and the decision inputs (identity, clearance information, system register entry).
- Regular access reviews can show that foreign-national maintenance/diagnostics only took place under valid MoA coverage and permitted ownership/operation conditions.

###### Actions Required for Compliance

- [ ] Create and keep up to date a register of classified systems, including who owns and operates each system, and which maintenance and diagnostic activities are permitted.
- [ ] Add foreign-national status indicators and security clearance details to the organisation’s identity and access management (IAM) and privileged access management (PAM) decision inputs.
- [ ] Set up a memorandum of agreement (MoA) register with structured information to record approvals, consents, and the detailed operating conditions for each system and each type of activity.
- [ ] Define “model of authority” (MoA) completeness rules and link them to policy-as-code authorisation checks.
- [ ] Set up the access broker and privileged access management (PAM) to block privileged maintenance and diagnostic sessions unless the required clearance, the correct ownership and operating model, and the “MoA” completeness checks all pass.
- [ ] Enable audit logging that records, for every authorised session: the identity of the person requesting access, the clearance level used, the system record entry, and the MoA (Memorandum of Agreement) ID and version.


---

#### MA-5.5 — Non-system Maintenance (Enhancement)

This requirement is about ensuring that people who carry out maintenance work nearby, but are not part of the system team, can only enter the relevant areas after they have been properly approved. Without this, staff who are not authorised—or who have not been properly checked—could accidentally or deliberately access sensitive equipment or areas. That would increase the risk of disruption, damage, or exposure of information.

To meet this expectation, the organisation must clearly define:
- which roles count as non-escorted maintenance staff (for example, facilities and cleaning teams), and  
- what “near the system” and “non-system maintenance” mean in practice.

Before any work starts, the organisation must confirm that each person has the correct, up-to-date permission for the specific physical areas they will enter. This must be done through an authorised approval process that includes the required personnel checks and any relevant security requirements.

The organisation must also keep records of permissions and maintenance activity, ensure this approach is included in the system’s security plan, and keep related policies and procedures consistent with it.

##### Authorise non-escorted maintenance via zone/time work orders

- Category: Manual
- Priority: High

###### WHAT
Make sure that maintenance staff who are not escorted—because they are working near the system but not directly on it—only get access approvals for the specific areas (and time periods) they need to enter.

###### WHY (control requirement)
MA-5(5) requires that non-escorted maintenance staff working near the system have the correct access approvals. This helps prevent unauthorised access to sensitive system areas and ensures access decisions are recorded, based on where and when access is needed.

###### HOW (specific approach)
Set up a zone-based physical access approval process that starts when a maintenance work order or ticket is raised, and is enforced at the point of entry.

1. **Define proximity zones and allowed maintenance types**
   - Create an “area catalogue” that links physical areas (for example, rooms, corridors, equipment enclosures, server and telecommunications cupboards) to the systems they protect.
   - Define maintenance types (for example, cleaning, building repairs, heating, ventilation and air conditioning (HVAC) filter changes) and state which zones each type can access.
   - Clarify in procedure what counts as “non-system maintenance” (that is, work not directly related to operating or administering the system).

2. **Require work-order details before access is approved**
   - Configure the facilities or maintenance ticketing system so that any request for non-system maintenance near a system must include: the named staff member(s), the maintenance type, the exact zone(s) and door(s) and/or room(s), and the requested time window.
   - Stop the request (or send it for approval) if any zone, time, or person details are missing.

3. **Create access approvals for the right zone and time, using an authorised process**
   - Link the ticketing process to the Physical Access Control System (PACS) or the access approval workflow so access is only granted after required approvals are completed (for example, facilities and security approval, and any required personnel security checks).
   - Ensure approvals are limited to the specific zone(s) and time window, not general-purpose access.

4. **Enforce access at entry and link it to the work order**
   - Configure entry control so that badge or credential access is checked against the PACS approval, and—where supported—against the work-order reference.
   - Record entry events and match them to the work order.

5. **Keep evidence for audit and reference it in the system security plan**
   - Keep: access approval logs, approval records, work-order references, and entry verification records.
   - Update the system security plan to explain the process, including how access is checked before entry and how exceptions are handled.

###### WHO (roles responsible)
- **Facilities/Operations Manager**: defines maintenance types and the zone access rules.
- **Security Officer / Authorising Official**: approves access and ensures personnel security responsibilities are met.
- **Physical Security / PACS Administrator**: sets up the PACS integration, door and zone mappings, and logging.
- **Maintenance Supervisor**: raises work orders with the correct zone, time, and staff details.

###### Acceptance criteria
- For any non-escorted maintenance activity near the system, access is granted only after the work order or ticket names the staff member(s) and specifies the exact zone(s) and time window.
- PACS blocks entry when there is no valid, limited (zone and time) approval.
- Access approval and entry verification events are logged and kept for audit.
- The system security plan documents the access approval process and how exceptions are handled.

###### Actions Required for Compliance

- [ ] Define and document the system’s proximity zones or areas, and link each zone or area to the systems it applies to and the types of maintenance work that are allowed there.
- [ ] Update the facilities and maintenance work-order process so that every non-system maintenance request includes: named personnel, a maintenance category, the exact zone or zones, and the specific time window.
- [ ] Set up an authorised approval process (Security Officer and Authorising Official) to approve and issue access permissions for each zone and time period.
- [ ] Set up the public access controls (PACS) and access control rules to allow only the specific, authorised permissions (scoped grants), and block access if authorisation is missing or outside the allowed scope.
- [ ] Set up logging and retention for authorisation issuance, approval, and entry verification events, and link these events to work orders.
- [ ] Update the system security plan to explain the process for allowing maintenance work without an escort, including how exceptions are handled.


---

### MA-6 — Timely Maintenance (Control)

This requirement is about making sure that when important equipment or software stops working, you can get the right help or replacement parts quickly. Without this, a server, network, security device, storage system, or essential software licence could stay out of service for too long, leading to major disruption to services, financial loss, and damage to customer trust.

To meet this expectation, the organisation must clearly identify which servers, devices, storage systems, and software licences are mission-critical. For each one, it must be clear what maintenance support and spare parts are needed to restore service. The organisation must also have a documented maintenance policy and procedures, including named people responsible for raising requests, ordering parts, and coordinating any necessary security-related checks.

In addition, the organisation must have supplier contracts and agreed service commitments that allow the required maintenance help and/or parts to be obtained within 24 hours of the failure being confirmed. This must be supported by an up-to-date list of spare parts and evidence that these arrangements work in practice.

##### SLA-backed 24-hour maintenance support for mission-critical assets

- Category: Software
- Priority: Critical

###### WHAT must be done
For the organisation-defined **system components** (ma-06_odp.01) that are mission-critical, make sure **maintenance support and/or spare parts** can be obtained **within the organisation-defined time period** (ma-06_odp.02) **after a failure is declared**.

###### WHY (control requirement)
NIST SP 800-53 **MA-6 Timely Maintenance** requires the organisation to obtain maintenance support and/or spare parts for the defined components **within the specified time period after a failure is declared**. It also expects that this is achieved through appropriate actions, such as **having suitable contracts in place**.

###### HOW (specific steps/approach)
1. **Create and keep up to date a component-to-maintenance entitlement matrix**. Cover every in-scope asset (servers, network/security devices, storage systems, and supporting software licences) and link each one to the **exact maintenance support and/or spare parts** needed to restore service.
2. **Negotiate and/or check contract terms** with each maintenance provider so the contract clearly requires **acknowledgement and/or dispatch/availability of the required support and/or spare parts within ma-06_odp.02** after a failure is declared (use contract wording that matches your operational definition of “failure declaration”).
3. **Define “failure declaration” operationally** (for example, an incident severity or service-impact threshold) and ensure it is **recorded with a timestamp** in your IT service management (ITSM) or operations system. That timestamp starts the **ma-06_odp.02** timing window.
4. **Set up an automated maintenance request process** from your ITSM tool. When a failure is declared for an in-scope component, it should open a vendor case (portal/application programming interface (API)/email/call script) with the required details (asset tag/serial number, model, part numbers, symptoms, environment, and escalation contacts) and record the vendor’s acknowledgement and dispatch confirmations.
5. **Use role-based approvals and escalation** so only authorised operational roles can trigger vendor escalation and any security-relevant handling steps (for example, for security devices). Keep evidence of these actions in the ticket history.
6. **Collect and report evidence to show timeliness**. Record timestamps for (a) failure declaration, (b) vendor acknowledgement, and (c) dispatch/arrival confirmation (or equivalent contractual proof), and keep these records for audit.

###### WHO (role responsible)
- **Service Owner / Infrastructure & Operations Manager**: owns the component-to-entitlement matrix and ensures contracts meet ma-06_odp.02.
- **ITSM Process Owner**: defines the failure declaration process and ensures timestamps are accurate and reliable.
- **Procurement / Vendor Management**: negotiates and maintains maintenance contracts and service level agreements (SLAs).
- **System/Network/Storage Administrators (authorised roles)**: declare failures and raise vendor requests.
- **Information Security (as required by component criticality)**: reviews security-relevant escalation and handling steps.

###### Acceptance criteria
- For every component listed in **ma-06_odp.01**, there is a documented link to the **specific maintenance support and/or spare parts** required.
- For each provider in the mapping, the contract/SLAs explicitly support obtaining the required support and/or spare parts **within ma-06_odp.02 of failure declaration**.
- In the ITSM process, the **failure declaration timestamp** is recorded, and vendor acknowledgement/dispatch (or equivalent proof) is captured.
- For a sample of recent failures (or tabletop exercises if no failures occurred), the measured time from failure declaration to vendor acknowledgement/dispatch/arrival proof is **≤ ma-06_odp.02** for all in-scope components.

###### Actions Required for Compliance

- [ ] Create a matrix that links each asset in **ma-06_odp.01** to the maintenance permissions it requires.
- [ ] Update maintenance contracts and service level agreements (SLAs) to explicitly guarantee support and/or spare parts within **ma-06_odp.02** of the failure being declared.
- [ ] Define and document an operational “failure declaration” trigger, and ensure the time and date are recorded in the IT service management (ITSM) system.
- [ ] Set up an IT service management (ITSM) workflow with the supplier for maintenance requests. The workflow should automatically fill in the asset and part details, and it should record the supplier’s acknowledgement and proof of dispatch.
- [ ] Set up role-based controls so only authorised roles can start vendor escalation and any security-relevant handling steps.
- [ ] Create an audit report that measures how long it takes to acknowledge or dispatch, based on **ma-06_odp.02**, and keeps the supporting evidence so it can be reviewed.


---

#### MA-6.1 — Preventive Maintenance (Enhancement)

This requirement is about keeping important equipment working properly through planned, regular servicing and checks. The aim is to spot problems early, before they cause disruption. Without preventive maintenance at least once every quarter for network equipment, servers, storage systems, and critical security devices, worn parts or developing faults could fail unexpectedly. This could cause downtime, loss of service, and a greater risk of security weaknesses being exploited.

To meet this expectation, the organisation must:
- clearly define which equipment is covered
- set a quarterly maintenance schedule
- have clear written rules and step-by-step instructions for how maintenance is carried out, including inspection, testing, adjustments, parts replacement, and fixing developing issues

If external engineers are used, the organisation must have contracts and service expectations that require quarterly maintenance.

The organisation must also:
- keep an up-to-date list of the specific components that need maintenance
- assign named responsibilities to the right staff
- ensure the organisation’s security planning reflects maintenance activities
- keep maintenance records showing what was done and when

##### Quarterly preventive maintenance via CMMS with audit-ready evidence

- Category: Software
- Priority: Critical

###### WHAT
Set up a documented preventive maintenance programme that carries out preventive maintenance on the organisation-defined **system components** at the organisation-defined **time intervals** (at least quarterly), and keeps proof that the maintenance has been completed.

###### WHY (control requirement)
NIST SP 800-53 **MA-6(1)** enhancement requires: **“Perform preventive maintenance on {{param ma-06.01_odp.01}} at {{param ma-06.01_odp.02}}.”** Preventive maintenance must include proactive checks, tests, measurements, adjustments, replacing parts, and fixing early signs of failure to avoid or reduce the impact of equipment breakdowns.

###### HOW (specific steps/approach)
1. **Clear scope in the maintenance system (CMMS):** Keep an up-to-date CMMS (computerised maintenance management system) list of the organisation-defined **system components** (network devices, servers, storage systems, and critical security appliances). Each item must have a unique identifier and be linked to an equipment type.
2. **Quarterly schedule enforcement:** Set up repeating CMMS work orders so that **quarterly** preventive maintenance tasks are created for every item in scope (making sure the interval matches **ma-06.01_odp.02**).
3. **Standard maintenance instructions/checklists:** Create controlled, version-controlled checklists for each equipment type that describe the preventive maintenance activities (systematic inspection, tests, measurements, adjustments, parts replacement, and fixing early signs of failure). Link each checklist item to the relevant approved procedure or document.
4. **Structured proof of completion:** Require technicians to record, for each completed work order: date/time, asset identifier, what was done, test/measurement results, what was adjusted, parts replaced (including part/serial identifiers where applicable), outcomes (for example, “no issues found” or early failures identified), and sign-off. Attach supporting information (for example, command outputs, sensor readings, and firmware/configuration verification reports).
5. **Approvals based on roles and security importance:** Use a sign-off workflow so completion is confirmed by the right operational owner (for example, system/network administrator). If the asset is a security appliance or a security-relevant component, include an information security review/acknowledgement for any security-impacting findings.
6. **External maintenance integration (if used):** If third parties carry out maintenance, create provider work orders in the CMMS and require proof attachments and reporting that match the same quarterly schedule (including service reports and test results), aligned with contract/service level agreement (SLA) expectations.
7. **Monitoring and reporting for compliance:** Set up automated checks to highlight any asset with an overdue quarterly work order or missing proof, and produce an auditable maintenance compliance report (asset coverage, last completed date, and whether evidence is complete).

###### WHO
- **Infrastructure/Operations Manager:** Owns the preventive maintenance programme and the CMMS configuration.
- **System/Network Administrators and Maintenance Technicians:** Carry out the work orders and enter the structured proof.
- **Information Security Lead:** Reviews preventive maintenance outcomes that are security-relevant for security appliances and any security-impacting findings.
- **Procurement/Vendor Management (if applicable):** Ensures provider contracts/SLA require quarterly preventive maintenance proof.

###### Acceptance criteria
- Every in-scope asset in **ma-06.01_odp.01** has a CMMS record and is covered by a **quarterly** preventive maintenance work order per **ma-06.01_odp.02**.
- For each completed work order, the CMMS includes complete proof fields (tasks completed, results, adjustments/parts replaced where applicable, and sign-off).
- Overdue or missing maintenance can be identified through automated reporting, and the organisation can produce an audit-ready report showing maintenance completion dates and proof for the most recent quarterly cycle.
- If external maintenance is used, provider proof is recorded in the CMMS and linked to the quarterly schedule and contract/SLA expectations.

###### Actions Required for Compliance

- [ ] Maintain an up-to-date, official asset list in the computerised maintenance management system (CMMS) for the defined system components (network devices, servers, storage systems, and critical security appliances).
- [ ] Set up the computerised maintenance management system (CMMS) to automatically create recurring preventive maintenance work orders for every in-scope asset, running them on the agreed quarterly schedule.
- [ ] Create controlled, version-controlled preventive maintenance checklists for each type of equipment. Each checklist should cover inspection, tests, measurements, adjustments, replacement of parts, and correction of early signs of failure.
- [ ] Require structured evidence to be recorded in the computerised maintenance management system (CMMS) for every work order, including results, any adjustments made, parts that were replaced, the final outcome, and sign-off.
- [ ] Set up role-based approval steps for confirming maintenance is complete, including a requirement for information security sign-off for any security-relevant findings.
- [ ] If you use external maintenance providers, link their work orders to your computerised maintenance management system (CMMS) and require quarterly proof documents to be attached, matching what the contract and service level agreement (SLA) expects.
- [ ] Run automated checks to confirm compliance and produce an audit-ready report showing, for the most recent cycle, whether quarterly maintenance was completed and whether supporting evidence is complete.


---

#### MA-6.2 — Predictive Maintenance (Enhancement)

This requirement is about keeping your most important equipment under close watch. The goal is to spot early warning signs and plan repairs before anything starts to fail. Without predictive maintenance for critical on-premises servers, storage systems, network switches and routers, and industrial control equipment, problems can develop quietly. This can lead to unexpected downtime, reduced performance, expensive emergency repairs, and possible disruption to business operations.

To meet this expectation, the organisation must:
- keep an up-to-date list of the specific critical assets covered;
- continuously monitor the condition of those assets; and
- carry out scheduled inspections at least once every quarter.

The organisation must analyse the monitoring results to predict how each asset’s condition is likely to change. It must set clear thresholds for when performance is considered unacceptable, and schedule maintenance at the most cost-effective time—ensuring it is completed before performance falls below those thresholds.

The organisation should also:
- document how this will be done;
- assign named responsibilities; and
- keep maintenance records showing what was checked and what decisions were made.

If any maintenance is carried out by external providers, the organisation must ensure this is covered by contracts and supported by evidence that the required monitoring and quarterly inspections are delivered.

##### Predictive maintenance telemetry-to-CMMS workflow for critical assets

- Category: Software
- Priority: Critical

###### WHAT
Set up a predictive maintenance programme that continuously checks the condition of the organisation-defined **system components**. It must also carry out **scheduled predictive maintenance inspections at least every quarter**. Use the inspection results to forecast future condition changes and plan maintenance early, so performance does not drop below acceptable limits.

###### WHY (control requirement)
NIST SP 800-53 **MA-6(2)** enhancement requires: **“Perform predictive maintenance on {{param ma-06.02_odp.01}} at {{param ma-06.02_odp.02}}.”** The guidance also requires regular or continuous condition monitoring, forecasting trends (using statistical process control), and scheduling maintenance before performance reaches unacceptable thresholds.

###### HOW (specific steps/approach)
###### 1) Define what is monitored and how often (linked to the parameters)
- Use the organisation’s official asset register / configuration management database (CMDB) to identify the **system components** covered by MA-6(2) (for example: critical on-premises servers, storage systems, network switches/routers, and industrial control system (ICS) assets).
- Set the predictive maintenance schedule to meet **{{param ma-06.02_odp.02}}** (continuous monitoring with **scheduled inspections at least every quarter**).

###### 2) Set up continuous condition monitoring data
- For information technology (IT) assets: collect supplier information and health data (for example: hard drive SMART trend data, RAID (redundant array of independent disks) / controller health, power supply unit (PSU) and fan status, network interface error rates, temperature and other thermal sensor readings, and indicators such as central processing unit (CPU), memory, and input/output (I/O) delays).
- For operational technology (OT) / ICS assets: collect condition indicators using **non-disruptive** methods (for example: telemetry via a gateway, health signals from a historian or supervisory control and data acquisition (SCADA) system, and passive network or edge telemetry where possible).
- Make sure data collection is protected (for example: encrypted data transfer), and that measurements are time-stamped and clearly linked to specific assets.

###### 3) Use predictive analysis to forecast trends and apply thresholds
- Use statistical process control / trend analysis to forecast deterioration (for example: identify gradual changes or unusual patterns and estimate when a threshold will be reached).
- Define clear **acceptable condition/performance thresholds** for each type of asset, and convert analysis results into a risk score and a predicted “maintenance needed” timeframe.

###### 4) Carry out quarterly inspections and keep evidence
- Link the analysis results to the organisation’s computerised maintenance management system (CMMS) / enterprise asset management (EAM) system (or an equivalent maintenance system) so it automatically creates **quarterly work orders** for each asset in scope.
- Fill each work order with: the latest condition measurements, the predicted trend and risk score, and the reason for the prediction based on the analysis.
- Ensure the maintenance record shows one of the following auditable outcomes:
  - maintenance was carried out (with the work order reference), or
  - a “no action” justification, referencing the predicted trend and whether the threshold has been met.

###### 5) Make maintenance decisions and scheduling practical and cost-effective
- Configure the process so maintenance is scheduled within the organisation’s maintenance windows and change calendar. Maintenance should be done at the most cost-effective time **but always before the predicted threshold is breached**.

###### WHO (role responsible)
- **Asset Owner / Infrastructure Engineering Lead**: owns the mapping of which assets are in scope and the definitions of thresholds.
- **Reliability/Operations (site reliability engineering (SRE) / OT Maintenance) Manager**: owns the predictive maintenance process and ensures quarterly inspections are carried out.
- **Platform/Integration Engineer**: implements telemetry data collection, connects analytics, and integrates with the CMMS/EAM system.
- **Security/Compliance Lead**: checks that monitoring and records are auditable and that data handling meets the organisation’s security requirements.

###### Acceptance criteria (audit-ready)
1. The organisation can show that the **list of in-scope assets** matches **{{param ma-06.02_odp.01}}** and is up to date (for example, CMDB / asset register evidence).
2. The organisation performs **continuous monitoring** and produces **quarterly inspection work orders** for every in-scope asset, meeting **{{param ma-06.02_odp.02}}**.
3. For each quarterly inspection cycle, evidence exists showing the analysis outputs (trend/prediction/risk score) and the decision taken (maintenance carried out, or documented “no action” justification).
4. Maintenance is scheduled based on predicted deterioration against the defined thresholds (evidence that maintenance happens before unacceptable performance/condition thresholds are reached).
5. Maintenance records are kept and can be traced back to the specific asset and inspection period (an auditable link between telemetry/analytics and the CMMS/EAM outcomes).

###### Actions Required for Compliance

- [ ] Match the authoritative asset register and configuration management database (CMDB) to the in-scope **system components**, and tag each asset for MA-6(2) predictive maintenance.
- [ ] Set up continuous monitoring and health data collection for each type of asset (information technology (IT) and operational technology/industrial control systems (OT/ICS)), using methods that do not disrupt operations where needed.
- [ ] Use predictive analytics (statistical process control and trend forecasting) and set measurable condition and performance limits for each asset class.
- [ ] Connect the analytics results to the computerised maintenance management system (CMMS) / enterprise asset management (EAM) so that quarterly work orders are automatically created in line with **{{param ma-06.02_odp.02}}**
- [ ] Set up a workflow that produces an auditable record of inspection results, where each outcome must include either (1) a reference to the maintenance work carried out, or (2) a documented explanation for why no action was taken, linked to the predicted threshold levels.
- [ ] Set up maintenance scheduling to take place before the predicted point where limits will be exceeded, and only within the approved maintenance or change time windows.


---

#### MA-6.3 — Automated Support for Predictive Maintenance (Enhancement)

This requirement is about ensuring your equipment’s health information is sent automatically to your maintenance system, so repairs and inspections can be planned and tracked without delay. If this connection is missing or unreliable, warning signs may be missed, maintenance may be carried out too late or unnecessarily, and it becomes harder to show what was done and when—creating real operational and cost risks.

The organisation must set up an automated, secure connection that sends predictive maintenance data from the equipment condition monitoring platform to the maintenance management system using protected, code-based data feeds. It must also make sure the maintenance system receives and uses this information to support planning, carrying out work, and reporting.

The organisation must keep clear records showing that the transfer is working, that the connection is protected and authorised, that staff can monitor failures and confirm recovery, and that responsibilities, maintenance procedures, service arrangements, and upkeep records are documented for the platforms and the automated transfer mechanism.

##### Secure automated API feed for predictive maintenance data transfer

- Category: Software
- Priority: Critical

###### WHAT
Set up an automated, authenticated, encrypted way to move predictive maintenance (equipment condition) data from the equipment condition monitoring platform into the maintenance management system, without manual copying. Ensure the maintenance management system receives and uses this data for planning, carrying out maintenance work, and reporting.

###### WHY (control requirement)
NIST MA-6(3) enhancement requires: “Transfer predictive maintenance data to a maintenance management system using {{ insert: param, ma-06.03_odp }}.” The organisation-defined parameter **ma-06.03_odp** specifies **“automated mechanisms”**. The intended implementation is **secure, API-based data feeds** from the equipment condition monitoring platform to the maintenance management system.

###### HOW (specific steps/approach)
1. **Define the automated interface agreement**: Create a clear data format (payload schema) and mapping rules for predictive maintenance events (for example: asset/component identifiers, condition measure(s), alert/severity, event date/time, and any recommended maintenance action). Define which fields are required and how they will be checked for correctness.
2. **Build the integration method**: Use an event-driven approach (webhooks from the condition monitoring platform to an integration service) or, if webhooks are not available, use a polling approach that picks up new items using incremental cursors. Make sure the transfer runs automatically and keeps processing new predictive maintenance events.
3. **Secure the API data feed**: Require encrypted connections using Transport Layer Security (TLS) version 1.2 or later (TLS 1.2+), verify server certificates, and use strong authentication (for example: OAuth 2.0 client credentials, mutual Transport Layer Security (mTLS), or signed JSON Web Tokens (JWTs)). Store credentials and secrets in the organisation-approved secrets manager.
4. **Ensure dependable delivery and avoid duplicates**: Add retry behaviour with increasing delays (exponential backoff) when temporary issues occur. Use idempotency keys to prevent creating duplicate maintenance items, validate the data format, and use a dead-letter process for events that are malformed or cannot be processed.
5. **Ingest and use the data in the maintenance management system**: Configure the maintenance management system to receive the incoming data, store it in the correct places, and start or enable the processes needed for maintenance planning, execution, and reporting.
6. **Create evidence that can be audited**: Produce time-stamped logs and measures for each transfer attempt (success or failure, HTTP status, correlation identifiers, and processing results). Send logs to the enterprise logging and security information and event management (SIEM) platform and keep them according to organisational policy.

###### WHO
- **Integration/Platform Engineer**: Builds the integration service, defines the data interface and mapping, sets up security, and implements reliability controls.
- **Maintenance Management System Owner**: Configures how data is received, how it maps to maintenance items, and how downstream workflows are triggered.
- **Security Engineer**: Reviews and approves the approach for API authentication and encryption, how secrets are handled, and how audit evidence is produced.
- **Operations/Monitoring Lead**: Ensures monitoring, alerting, and log retention are in place.

###### Acceptance criteria
- Predictive maintenance events created in the condition monitoring platform are transferred to the maintenance management system **automatically** (with no manual involvement) within the agreed operational time window.
- All API calls use **encrypted transport** (TLS 1.2+) and **authenticated access** (no endpoints that can be accessed without authentication; secrets stored in an approved vault).
- The maintenance management system successfully **ingests, stores, and uses** the received predictive maintenance data to support planning, execution, and reporting (for example: creating or updating maintenance tasks/work orders or equivalent workflow outputs).
- Reliability controls are proven: retries happen for temporary failures; duplicates are prevented using idempotency; malformed payloads are captured for correction.
- Audit evidence exists: for a test event, logs show end-to-end linkage (the event identifier and timestamp appear in both systems) and record success/failure outcomes, with retention in the enterprise logging system.

###### Actions Required for Compliance

- [ ] Document the predictive maintenance event data format (schema) and how each data field maps to the maintenance management system objects.
- [ ] Set up an automated integration service that connects systems by using event-triggered webhooks or regular polling, and uses incremental cursors to track progress.
- [ ] Set up API security using Transport Layer Security (TLS) version 1.2 or later and strong sign-in controls, using one of the approved options (OAuth 2.0 client credentials, mutual Transport Layer Security (mTLS), or signed JSON Web Tokens (JWTs)). Use credentials stored in the approved vault.
- [ ] Add a unique “idempotency key” so the request can be safely repeated, retry failed requests using increasing delays (exponential backoff), check that incoming data matches the expected format (schema validation), and store any payloads that still fail in a “dead-letter” area for later review.
- [ ] Set up the maintenance management system to collect the incoming data, store it for future use, and start the next steps for planning, carrying out work, and reporting.
- [ ] Set up end-to-end logging using correlation identifiers, and send the transfer logs and performance measurements to the enterprise security information and event management (SIEM) system, keeping them for the length of time required by policy.


---

### MA-7 — Field Maintenance (Control)

This requirement is about protecting the most important equipment from casual repairs on customer sites. Only places that have been properly checked should be allowed to work on it. If critical systems are serviced at customer sites or other local locations, the checks may be less thorough, the records may be incomplete, and unauthorised access during diagnosis or repairs could go unnoticed—raising the risk of disruption or misuse.

To meet this expectation, the organisation must first write down exactly which systems and components it considers critical. For each one, it must then decide whether on-site (field) maintenance is restricted or completely prohibited. It must also document clear procedures for how field maintenance is handled, and ensure that any permitted work is carried out only at certified depots or contractor facilities that have approved security measures, using an up-to-date list of approved facilities.

For any diagnostic work carried out during maintenance, the organisation must require strong identity checks. It must also ensure that sessions and any related connections are ended when the work is finished, while keeping maintenance and diagnostic records and the supporting documentation.

##### Enforce critical-field maintenance via work-order gate

- Category: Software
- Priority: Critical

###### WHAT
Set up an operational “field maintenance gate” that stops on-site (field) maintenance for every organisation-designated critical system or component, and ensures that any permitted maintenance is carried out only at approved trusted maintenance facilities.

###### WHY (control requirement)
NIST SP 800-53 MA-7 requires restricting or prohibiting field maintenance on **{{ ma-07_odp.01 }} (systems or system components)** to **{{ ma-07_odp.02 }} (trusted maintenance facilities)**. The guidance notes that field maintenance may be less strictly controlled than depot maintenance for critical systems. Therefore, the organisation must enforce this restriction/prohibition in practice and require extra controls at trusted facilities.

###### HOW (specific steps/approach)
1. **Define coverage in an authoritative asset register/configuration management database (CMDB)**: Mark each system/component as “critical” (the set corresponding to **ma-07_odp.01**) and record the maintenance rule for it: **prohibited** or **restricted**.
2. **Create an approved facility registry**: Keep an approved list of **trusted maintenance facilities** (the set corresponding to **ma-07_odp.02**) including evidence that they have the required security controls, plus an expiry and re-check (re-certification) date.
3. **Enforce through the work-order/IT service management (ITSM) process**: In the work-order system, make maintenance location and facility mandatory fields. For any work order that references a critical item:
   - If the rule is **prohibited**, block scheduling if the location is any site other than an approved trusted maintenance facility.
   - If the rule is **restricted**, allow scheduling only when the selected facility is on the approved registry; otherwise reject the request.
4. **Allow exceptions only if policy permits**: If exceptions are allowed, require an exception record with security approval and a documented risk acceptance. If not, block exceptions.
5. **Use strong identity checks for diagnostic/maintenance sessions** (when diagnostics are carried out as part of maintenance): require phishing-resistant multi-factor authentication (MFA) for maintenance users and time-limited authorisation. When the work order is closed, end the session and revoke any remote access or connections used for the work.
6. **Automatically record audit evidence**: In the work-order system, capture: the critical item identifier, maintenance location, approved facility reference, authorising role(s), diagnostic start/end times, and confirmation that remote access was ended.

###### WHO (role responsible)
- **Application/Infrastructure Service Owner**: ensures the criticality tagging and maintenance rule mapping are correct.
- **ITSM/Work-Order Process Owner**: implements workflow checks and mandatory fields.
- **Information Security (identity and access management (IAM)/Privileged Access team)**: sets and enforces strong authentication and session-ending requirements for maintenance diagnostics.
- **Third-Party/Vendor Management**: maintains the trusted maintenance facility registry and the re-certification evidence.

###### Acceptance criteria
- For every critical system/component (ma-07_odp.01), the work-order workflow **prevents** scheduling on-site/field maintenance unless the maintenance location is an approved trusted maintenance facility (ma-07_odp.02), in line with the configured rule (prohibited/restricted).
- Any maintenance diagnostic/remote access linked to a maintenance work order is protected by phishing-resistant multi-factor authentication (MFA) and is **automatically ended** when the work order is closed.
- Audit evidence is produced for each work order: critical item, maintenance location, approved facility identifier, authorisation details, and diagnostic/session start/end times plus confirmation of termination.
- The approved trusted maintenance facility registry is kept up to date with re-certification dates and security-control evidence, and the workflow rejects facilities not listed in the registry.

###### Actions Required for Compliance

- [ ] Record all critical systems and components in the configuration management database (CMDB) / asset register, and set a maintenance rule for each item (either prohibited or restricted).
- [ ] Create and keep an approved register of trusted maintenance facilities, including evidence of security controls and the dates when each facility must be rechecked (recertified).
- [ ] Update the IT service management (ITSM) work-order process so that, for all critical items, the maintenance location and an approved facility are selected and recorded.
- [ ] Set up workflow controls to block or reject field or on-site maintenance requests that do not meet the MA-7 rule.
- [ ] Set up maintenance diagnostics and remote access so that it requires phishing-resistant multi-factor authentication (MFA) and time-limited permission.
- [ ] Automate the end of sessions and network tunnels, and revoke privileged access when the work order is closed.
- [ ] Ensure work orders record audit evidence, including the critical item, location, approved facility, the person who authorised the work, the start and end times of the diagnostic or session, and confirmation that the work was terminated.

